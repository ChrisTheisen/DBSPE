namespace DB_SP_Examiner
{
    partial class DBSPE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSP = new System.Windows.Forms.Button();
            this.ddlSP = new System.Windows.Forms.ComboBox();
            this.dgvInputs = new System.Windows.Forms.DataGridView();
            this.tabIO = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.ddlDataSets = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.pnlInit = new System.Windows.Forms.Panel();
            this.chkWindowsAuth = new System.Windows.Forms.CheckBox();
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSP = new System.Windows.Forms.Panel();
            this.btnGetSPData = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlSchema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.tabData = new System.Windows.Forms.TabPage();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputs)).BeginInit();
            this.tabIO.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.pnlInit.SuspendLayout();
            this.pnlSP.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetSP
            // 
            this.btnGetSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetSP.Location = new System.Drawing.Point(922, 2);
            this.btnGetSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetSP.Name = "btnGetSP";
            this.btnGetSP.Size = new System.Drawing.Size(84, 27);
            this.btnGetSP.TabIndex = 0;
            this.btnGetSP.Text = "Get SPs";
            this.btnGetSP.UseVisualStyleBackColor = true;
            this.btnGetSP.Click += new System.EventHandler(this.btnGetSP_Click);
            // 
            // ddlSP
            // 
            this.ddlSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSP.FormattingEnabled = true;
            this.ddlSP.Location = new System.Drawing.Point(157, 33);
            this.ddlSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlSP.Name = "ddlSP";
            this.ddlSP.Size = new System.Drawing.Size(726, 24);
            this.ddlSP.TabIndex = 1;
            // 
            // dgvInputs
            // 
            this.dgvInputs.AllowUserToAddRows = false;
            this.dgvInputs.AllowUserToDeleteRows = false;
            this.dgvInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colInput,
            this.colDBNull});
            this.dgvInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInputs.Location = new System.Drawing.Point(3, 2);
            this.dgvInputs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInputs.Name = "dgvInputs";
            this.dgvInputs.RowHeadersVisible = false;
            this.dgvInputs.RowHeadersWidth = 72;
            this.dgvInputs.RowTemplate.Height = 31;
            this.dgvInputs.Size = new System.Drawing.Size(995, 660);
            this.dgvInputs.TabIndex = 2;
            // 
            // tabIO
            // 
            this.tabIO.Controls.Add(this.tabInput);
            this.tabIO.Controls.Add(this.tabOutput);
            this.tabIO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabIO.Location = new System.Drawing.Point(3, 76);
            this.tabIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIO.Name = "tabIO";
            this.tabIO.SelectedIndex = 0;
            this.tabIO.Size = new System.Drawing.Size(1009, 693);
            this.tabIO.TabIndex = 3;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.btnExecute);
            this.tabInput.Controls.Add(this.dgvInputs);
            this.tabInput.Location = new System.Drawing.Point(4, 25);
            this.tabInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInput.Size = new System.Drawing.Size(1001, 664);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExecute.Location = new System.Drawing.Point(885, 2);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(113, 660);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.dgvOutput);
            this.tabOutput.Controls.Add(this.ddlDataSets);
            this.tabOutput.Location = new System.Drawing.Point(4, 25);
            this.tabOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOutput.Size = new System.Drawing.Size(1001, 664);
            this.tabOutput.TabIndex = 1;
            this.tabOutput.Text = "Output";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOutput.Location = new System.Drawing.Point(3, 26);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.RowHeadersWidth = 72;
            this.dgvOutput.RowTemplate.Height = 31;
            this.dgvOutput.Size = new System.Drawing.Size(995, 636);
            this.dgvOutput.TabIndex = 0;
            // 
            // ddlDataSets
            // 
            this.ddlDataSets.Dock = System.Windows.Forms.DockStyle.Top;
            this.ddlDataSets.FormattingEnabled = true;
            this.ddlDataSets.Location = new System.Drawing.Point(3, 2);
            this.ddlDataSets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlDataSets.Name = "ddlDataSets";
            this.ddlDataSets.Size = new System.Drawing.Size(995, 24);
            this.ddlDataSets.TabIndex = 2;
            this.ddlDataSets.SelectedIndexChanged += new System.EventHandler(this.ddlDataSets_SelectedIndexChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(75, 2);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(465, 4);
            this.txtPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(216, 22);
            this.txtPW.TabIndex = 4;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(9, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 16);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User ID:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(385, 5);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(70, 16);
            this.lblPW.TabIndex = 6;
            this.lblPW.Text = "Password:";
            // 
            // pnlInit
            // 
            this.pnlInit.Controls.Add(this.chkWindowsAuth);
            this.pnlInit.Controls.Add(this.txtCatalog);
            this.pnlInit.Controls.Add(this.label2);
            this.pnlInit.Controls.Add(this.txtSource);
            this.pnlInit.Controls.Add(this.label1);
            this.pnlInit.Controls.Add(this.lblUserName);
            this.pnlInit.Controls.Add(this.lblPW);
            this.pnlInit.Controls.Add(this.txtUsername);
            this.pnlInit.Controls.Add(this.btnGetSP);
            this.pnlInit.Controls.Add(this.txtPW);
            this.pnlInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInit.Location = new System.Drawing.Point(3, 3);
            this.pnlInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInit.Name = "pnlInit";
            this.pnlInit.Size = new System.Drawing.Size(1009, 766);
            this.pnlInit.TabIndex = 3;
            // 
            // chkWindowsAuth
            // 
            this.chkWindowsAuth.AutoSize = true;
            this.chkWindowsAuth.Location = new System.Drawing.Point(687, 4);
            this.chkWindowsAuth.Name = "chkWindowsAuth";
            this.chkWindowsAuth.Size = new System.Drawing.Size(141, 20);
            this.chkWindowsAuth.TabIndex = 11;
            this.chkWindowsAuth.Text = "Use Windows Auth";
            this.chkWindowsAuth.UseVisualStyleBackColor = true;
            this.chkWindowsAuth.CheckedChanged += new System.EventHandler(this.chkWindowsAuth_CheckedChanged);
            // 
            // txtCatalog
            // 
            this.txtCatalog.Location = new System.Drawing.Point(465, 33);
            this.txtCatalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(223, 22);
            this.txtCatalog.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Initial Catalog:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(100, 31);
            this.txtSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(223, 22);
            this.txtSource.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Source:";
            // 
            // pnlSP
            // 
            this.pnlSP.Controls.Add(this.btnGetSPData);
            this.pnlSP.Controls.Add(this.txtFilter);
            this.pnlSP.Controls.Add(this.label5);
            this.pnlSP.Controls.Add(this.label4);
            this.pnlSP.Controls.Add(this.ddlSchema);
            this.pnlSP.Controls.Add(this.label3);
            this.pnlSP.Controls.Add(this.ddlSP);
            this.pnlSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSP.Location = new System.Drawing.Point(3, 3);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(1009, 68);
            this.pnlSP.TabIndex = 4;
            // 
            // btnGetSPData
            // 
            this.btnGetSPData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetSPData.Location = new System.Drawing.Point(889, 31);
            this.btnGetSPData.Name = "btnGetSPData";
            this.btnGetSPData.Size = new System.Drawing.Size(113, 26);
            this.btnGetSPData.TabIndex = 6;
            this.btnGetSPData.Text = "Get SP Inputs";
            this.btnGetSPData.UseVisualStyleBackColor = true;
            this.btnGetSPData.Click += new System.EventHandler(this.btnGetSPData_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(425, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(577, 22);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filter Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Filter Schema";
            // 
            // ddlSchema
            // 
            this.ddlSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSchema.FormattingEnabled = true;
            this.ddlSchema.Location = new System.Drawing.Point(157, 3);
            this.ddlSchema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlSchema.Name = "ddlSchema";
            this.ddlSchema.Size = new System.Drawing.Size(155, 24);
            this.ddlSchema.TabIndex = 3;
            this.ddlSchema.SelectedIndexChanged += new System.EventHandler(this.ddlSchema_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stored Procedure";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabSetup);
            this.tabControlMain.Controls.Add(this.tabData);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1023, 801);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.pnlInit);
            this.tabSetup.Location = new System.Drawing.Point(4, 25);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(1015, 772);
            this.tabSetup.TabIndex = 0;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.pnlSP);
            this.tabData.Controls.Add(this.tabIO);
            this.tabData.Location = new System.Drawing.Point(4, 25);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(1015, 772);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 9;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 175;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 9;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 175;
            // 
            // colInput
            // 
            this.colInput.HeaderText = "Input";
            this.colInput.MinimumWidth = 9;
            this.colInput.Name = "colInput";
            this.colInput.Width = 175;
            // 
            // colDBNull
            // 
            this.colDBNull.HeaderText = "DB Null";
            this.colDBNull.MinimumWidth = 6;
            this.colDBNull.Name = "colDBNull";
            this.colDBNull.Width = 125;
            // 
            // DBSPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 801);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DBSPE";
            this.ShowIcon = false;
            this.Text = "DB SP Examiner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputs)).EndInit();
            this.tabIO.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.pnlInit.ResumeLayout(false);
            this.pnlInit.PerformLayout();
            this.pnlSP.ResumeLayout(false);
            this.pnlSP.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSP;
        private System.Windows.Forms.ComboBox ddlSP;
        private System.Windows.Forms.DataGridView dgvInputs;
        private System.Windows.Forms.TabControl tabIO;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox ddlDataSets;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Panel pnlInit;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatalog;
        private System.Windows.Forms.CheckBox chkWindowsAuth;
        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlSchema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetSPData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDBNull;
    }
}

