using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DB_SP_Examiner
{
    public partial class DBSPE : Form
    {
        private string DB = null;
        private DataSet Result = null;
        private List<string> AllSPs = new List<string>();
        private List<string> AllSchemas = new List<string>();

        public DBSPE()
        {
            InitializeComponent();

            txtSource.Text = Properties.Settings.Default["Source"].ToString();
            txtCatalog.Text = Properties.Settings.Default["Catalog"].ToString();
            txtUsername.Text = Properties.Settings.Default["Username"].ToString();
            chkWindowsAuth.Checked = (bool)Properties.Settings.Default["UseWindowsAuth"];

            ToggleAuthMode();

#if DEBUG
            TestFilter();
#endif
        }

        private void TestFilter()
        {
            AllSPs.Add("abc.[TEST]");
            AllSPs.Add("[abc].[TEST]");
            AllSPs.Add("[dbo].[TEST]");
            AllSPs.Add("[dbo].[ASDF]");
            AllSPs.Add("[dbo].[Calendar]");
            AllSPs.Add("[dbo].[asdf]");
            AllSPs.Add("[dbo].[TKGetData]");
            AllSPs.Add("[val].[TEST]");
            AllSPs.Add("[val].[getData]");
            AllSPs.Add("[val].[updateSubmitter]");

            AllSchemas.Add("All");
            AllSchemas.Add("[abc]");
            AllSchemas.Add("[dbo]");
            AllSchemas.Add("[val]");
            ddlSchema.DataSource = AllSchemas;

            tabControlMain.SelectedIndex = 1;
            FilterSPs();
        }


        private void SelectResultSet()
        {
            if (ddlDataSets.SelectedItem == null)
            {
                dgvOutput.DataSource = null;
                return;
            }
            var table = Result.Tables[(int)ddlDataSets.SelectedItem];
            dgvOutput.DataSource = table;


            if(table.Rows.Count == 0) { return; }
            var row = dgvOutput.Rows[0];
            foreach (DataGridViewColumn col in dgvOutput.Columns)
            {
                var dataColumn = table.Columns[col.Index];
                col.ToolTipText = $"Type: {row.Cells[col.Index].ValueType}\nNullable: {dataColumn.AllowDBNull}";
            }
        }

        private void FilterSPs(string startsWith = "All", string contains = null)
        {
            try
            {
                var temp = new List<string>();
                if (string.IsNullOrEmpty(startsWith) || startsWith == "All")
                {
                    temp.AddRange(AllSPs);
                }
                else {
                    temp.AddRange(AllSPs.FindAll(x => x.StartsWith(startsWith)));
                }

                var FilteredSPs = new List<string>();
                if (string.IsNullOrEmpty(contains))
                {
                    FilteredSPs.AddRange(temp);
                }
                else
                {
                    FilteredSPs.AddRange(temp.FindAll(x => x.ToLower().Contains(contains.ToLower())));
                }
                
                // Update list without changing selection
                ddlSP.DataSource = FilteredSPs;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleAuthMode()
        {
            txtUsername.Enabled = chkWindowsAuth.Checked;
            txtUsername.Text = string.Empty;
            txtPW.Enabled = chkWindowsAuth.Checked;
            txtPW.Text = string.Empty;
            SetConnectionString();
        }

        private void SelectSP()
        {
            // Only proceed if the selected item matches the current text
            if (string.IsNullOrEmpty(ddlSP.SelectedItem.ToString()) || !ddlSP.SelectedItem.ToString().Contains(".")) 
            { return; }
            
            tabIO.SelectedIndex = 0;
            var sp = ddlSP.SelectedItem.ToString().Split('.')[1].Replace("[", "").Replace("]", "");
            GetSPInputs(sp);
        }

        #region DB
        private void SetConnectionString()
        {
            if(chkWindowsAuth.Checked)
            {
                Properties.Settings.Default["Source"] = txtSource.Text;
                Properties.Settings.Default["Catalog"] = txtCatalog.Text;
                Properties.Settings.Default["Username"] = string.Empty;
                Properties.Settings.Default["UseWindowsAuth"] = true;
                Properties.Settings.Default.Save();
                DB = $"Data Source={txtSource.Text};Initial Catalog={txtCatalog.Text};Integrated Security=True;MultipleActiveResultSets=True";
                return;
            }

            Properties.Settings.Default["Source"] = txtSource.Text;
            Properties.Settings.Default["Catalog"] = txtCatalog.Text;
            Properties.Settings.Default["Username"] = txtUsername.Text;
            Properties.Settings.Default["UseWindowsAuth"] = false;
            Properties.Settings.Default.Save();

            DB = $"Data Source={txtSource.Text};Initial Catalog={txtCatalog.Text};User ID={txtUsername.Text};Password={txtPW.Text};MultipleActiveResultSets=True";

            // Log the connection string for debugging purposes
            System.Diagnostics.Debug.WriteLine($"Connection String: {DB}");
        }
        private DataTable GetTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0) { return ds.Tables[0]; }
            return null;
        }

        private DataSet GetDataSet(string query, IList<SqlParameter> sqlParameters = null)
        {
            DataSet output = new DataSet();
#if DEBUG
            return output;
#endif
            using (SqlConnection sqlConnection = new SqlConnection(DB))
            {

                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = query;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    if (sqlParameters != null)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (var param in sqlParameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }

                    sqlConnection.Open();
                    da.Fill(output);
                    sqlConnection.Close();
                }
            }
            return output;
        }


        private void GetSPs()
        {
            SetConnectionString();
            var query = $"SELECT SPECIFIC_SCHEMA, SPECIFIC_NAME FROM {txtCatalog.Text}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'";

            DataTable results = GetTable(query);

            AllSPs = new List<string>();
            AllSchemas = new List<string>();
            foreach (DataRow item in results.Rows)
            {
                var schema = $"[{item[0]}]";
                AllSPs.Add($"{schema}.[{item[1]}]");
                if (!AllSchemas.Contains(schema))
                {
                    AllSchemas.Add(schema);
                }
            }

            AllSchemas.Sort();
            AllSchemas.Insert(0, "All");
            AllSPs.Sort();
            ddlSchema.DataSource = AllSchemas;
            tabControlMain.SelectedIndex = 1;
            ddlSP.Focus();
            FilterSPs();
        }

        private void GetSPInputs(string SP)
        {
            if (string.IsNullOrEmpty(SP)) { return; }

            var query = $"SELECT pa.name AS [Name], UPPER(t.name) AS[Type] FROM sys.parameters AS pa INNER JOIN sys.procedures AS p on pa.object_id = p.object_id INNER JOIN sys.types AS t on pa.system_type_id = t.system_type_id AND pa.user_type_id = t.user_type_id WHERE p.name = '{SP}'";
            dgvInputs.DataSource = GetTable(query);
            dgvInputs.Focus();
            var inputIndex = dgvInputs.Columns["colInput"].Index;
            dgvInputs.CurrentCell = dgvInputs.Rows[0].Cells[inputIndex];
            dgvInputs.BeginEdit(true);
        }

        private void ExecuteSp()
        {
            var sp = ddlSP.SelectedItem.ToString();
            if (string.IsNullOrEmpty(sp)) { return; }
            ddlDataSets.SelectedItem = null;
            ddlDataSets.Items.Clear();

            var parameters = new List<SqlParameter>();
            foreach (DataGridViewRow row in dgvInputs.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colDBNull"].Value))
                {
                    parameters.Add(new SqlParameter(row.Cells["colName"].Value.ToString(), DBNull.Value));
                }
                else
                {
                    parameters.Add(new SqlParameter(row.Cells["colName"].Value.ToString(), row.Cells["colInput"].Value));
                }
            }

            try
            {
                Result = GetDataSet(sp, parameters);
                for (var i = 0; i < Result.Tables.Count; i++)
                {
                    ddlDataSets.Items.Add(i);
                }

                tabIO.SelectedIndex = 1;
            }
            catch (Exception x)
            {
                StringBuilder sbException = new StringBuilder();
                sbException.AppendLine(sp);
                foreach (var param in parameters)
                {
                    sbException.AppendLine($"{param.ParameterName}: {param.Value}");
                }
                sbException.AppendLine(x.Message);

                var tempException = x;
                while (tempException != null)
                {
                    sbException.AppendLine(tempException.Message);
                    tempException = tempException.InnerException;
                }

                MessageBox.Show(sbException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region actions
        private void btnGetSP_Click(object sender, EventArgs e)
        {
            GetSPs();
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            ExecuteSp();
        }
        private void ddlDataSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectResultSet();
        }
        private void chkWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            ToggleAuthMode();
        }
        private void ddlSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSPs(ddlSchema.SelectedItem.ToString(), txtFilter.Text);
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterSPs(ddlSchema.SelectedItem.ToString(), txtFilter.Text);
        }
        private void btnGetSPData_Click(object sender, EventArgs e)
        {
            SelectSP();
        }
        #endregion

    }
}
