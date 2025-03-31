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
        public DBSPE()
        {
            InitializeComponent();

            txtSource.Text = Properties.Settings.Default["Source"].ToString();
            txtCatalog.Text = Properties.Settings.Default["Catalog"].ToString();
            txtUsername.Text = Properties.Settings.Default["Username"].ToString();
        }

        private void SelectResultSet()
        {
            if (ddlDataSets.SelectedItem == null) {
                dgvOutput.DataSource = null;
                return; 
            }
            dgvOutput.DataSource = Result.Tables[(int)ddlDataSets.SelectedItem];

            var row = dgvOutput.Rows[0];
            foreach (DataGridViewColumn col in dgvOutput.Columns)
            {
                col.ToolTipText = row.Cells[col.Index].ValueType.ToString();
            }
        }

        #region DB

        private string DB = null;
        private DataSet Result = null;

        private void SetConnectionString()
        {
            Properties.Settings.Default["Source"] = txtSource.Text;
            Properties.Settings.Default["Catalog"] = txtCatalog.Text;
            Properties.Settings.Default["Username"] = txtUsername.Text;
            Properties.Settings.Default.Save();

            DB = $"Data Source={txtSource.Text};Initial Catalog={txtCatalog.Text};User ID={txtUsername.Text};Password={txtPW.Text};MultipleActiveResultSets=True";
        }
        private DataTable GetTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0) { return ds.Tables[0]; }
            return null;
        }

        private DataSet GetDataSet(string query)
        {
            DataSet output = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(DB))
            {

                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = query;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

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

            List<string> SPs = new List<string>();
            foreach (DataRow item in results.Rows)
            {
                SPs.Add($"[{item[0]}].[{item[1]}]");
            }

            SPs.Sort();

            ddlSP.Items.Clear();
            ddlSP.Items.AddRange(SPs.ToArray());

            ddlSP.Visible = true;
            pnlInit.Visible = false;
            tabIO.Visible = true;
        }

        private void GetSPInputs(string SP)
        {
            if (string.IsNullOrEmpty(SP)) { return; }

            var query = $"SELECT pa.name AS [Name], UPPER(t.name) AS[Type] FROM sys.parameters AS pa INNER JOIN sys.procedures AS p on pa.object_id = p.object_id INNER JOIN sys.types AS t on pa.system_type_id = t.system_type_id AND pa.user_type_id = t.user_type_id WHERE p.name = '{SP}'";
            dgvInputs.DataSource = GetTable(query); ;
        }

        private void ExecuteSp()
        {
            var sp = ddlSP.SelectedItem.ToString();
            if (string.IsNullOrEmpty(sp)){ return; }
            ddlDataSets.SelectedItem = null;
            ddlDataSets.Items.Clear();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"EXEC {sp} ");

            var tempInputs = new List<string>();
            foreach (DataGridViewRow row in dgvInputs.Rows)
            {
                tempInputs.Add($" {row.Cells["colName"].Value} = {row.Cells["colInput"].Value} ");
            }
            sb.AppendLine(string.Join(",\r\n", tempInputs.ToArray()));

            try
            {
                Result = GetDataSet(sb.ToString());
                for (var i = 0; i < Result.Tables.Count; i++)
                {
                    ddlDataSets.Items.Add(i);
                }

                tabIO.SelectedIndex = 1;
            }
            catch (Exception x)
            {
                StringBuilder sbException = new StringBuilder();
                sbException.AppendLine(sb.ToString());

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
        private void ddlSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabIO.SelectedIndex = 0;
            var sp = (sender as ComboBox).SelectedItem.ToString().Split('.')[1].Replace("[", "").Replace("]", "");
            GetSPInputs(sp);
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            ExecuteSp();
        }
        private void ddlDataSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectResultSet();
        }
        #endregion

    }
}
