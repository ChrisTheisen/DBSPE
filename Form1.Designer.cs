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
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputs)).BeginInit();
            this.tabIO.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.pnlInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetSP
            // 
            this.btnGetSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetSP.Location = new System.Drawing.Point(747, 2);
            this.btnGetSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetSP.Name = "btnGetSP";
            this.btnGetSP.Size = new System.Drawing.Size(63, 22);
            this.btnGetSP.TabIndex = 0;
            this.btnGetSP.Text = "Get SPs";
            this.btnGetSP.UseVisualStyleBackColor = true;
            this.btnGetSP.Click += new System.EventHandler(this.btnGetSP_Click);
            // 
            // ddlSP
            // 
            this.ddlSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.ddlSP.FormattingEnabled = true;
            this.ddlSP.Location = new System.Drawing.Point(0, 0);
            this.ddlSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlSP.Name = "ddlSP";
            this.ddlSP.Size = new System.Drawing.Size(812, 21);
            this.ddlSP.TabIndex = 1;
            this.ddlSP.Visible = false;
            this.ddlSP.SelectedIndexChanged += new System.EventHandler(this.ddlSP_SelectedIndexChanged);
            // 
            // dgvInputs
            // 
            this.dgvInputs.AllowUserToAddRows = false;
            this.dgvInputs.AllowUserToDeleteRows = false;
            this.dgvInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colInput});
            this.dgvInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInputs.Location = new System.Drawing.Point(2, 2);
            this.dgvInputs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInputs.Name = "dgvInputs";
            this.dgvInputs.RowHeadersVisible = false;
            this.dgvInputs.RowHeadersWidth = 72;
            this.dgvInputs.RowTemplate.Height = 31;
            this.dgvInputs.Size = new System.Drawing.Size(800, 356);
            this.dgvInputs.TabIndex = 2;
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
            // tabIO
            // 
            this.tabIO.Controls.Add(this.tabInput);
            this.tabIO.Controls.Add(this.tabOutput);
            this.tabIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabIO.Location = new System.Drawing.Point(0, 70);
            this.tabIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabIO.Name = "tabIO";
            this.tabIO.SelectedIndex = 0;
            this.tabIO.Size = new System.Drawing.Size(812, 386);
            this.tabIO.TabIndex = 3;
            this.tabIO.Visible = false;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.btnExecute);
            this.tabInput.Controls.Add(this.dgvInputs);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInput.Size = new System.Drawing.Size(804, 360);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(693, 3);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(111, 359);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.dgvOutput);
            this.tabOutput.Controls.Add(this.ddlDataSets);
            this.tabOutput.Location = new System.Drawing.Point(4, 22);
            this.tabOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabOutput.Size = new System.Drawing.Size(804, 363);
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
            this.dgvOutput.Location = new System.Drawing.Point(2, 23);
            this.dgvOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.RowHeadersWidth = 72;
            this.dgvOutput.RowTemplate.Height = 31;
            this.dgvOutput.Size = new System.Drawing.Size(800, 338);
            this.dgvOutput.TabIndex = 0;
            // 
            // ddlDataSets
            // 
            this.ddlDataSets.Dock = System.Windows.Forms.DockStyle.Top;
            this.ddlDataSets.FormattingEnabled = true;
            this.ddlDataSets.Location = new System.Drawing.Point(2, 2);
            this.ddlDataSets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlDataSets.Name = "ddlDataSets";
            this.ddlDataSets.Size = new System.Drawing.Size(800, 21);
            this.ddlDataSets.TabIndex = 2;
            this.ddlDataSets.SelectedIndexChanged += new System.EventHandler(this.ddlDataSets_SelectedIndexChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(56, 2);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(349, 3);
            this.txtPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(163, 20);
            this.txtPW.TabIndex = 4;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(7, 4);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User ID:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(289, 4);
            this.lblPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(56, 13);
            this.lblPW.TabIndex = 6;
            this.lblPW.Text = "Password:";
            // 
            // pnlInit
            // 
            this.pnlInit.Controls.Add(this.txtCatalog);
            this.pnlInit.Controls.Add(this.label2);
            this.pnlInit.Controls.Add(this.txtSource);
            this.pnlInit.Controls.Add(this.label1);
            this.pnlInit.Controls.Add(this.lblUserName);
            this.pnlInit.Controls.Add(this.lblPW);
            this.pnlInit.Controls.Add(this.txtUsername);
            this.pnlInit.Controls.Add(this.btnGetSP);
            this.pnlInit.Controls.Add(this.txtPW);
            this.pnlInit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInit.Location = new System.Drawing.Point(0, 21);
            this.pnlInit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInit.Name = "pnlInit";
            this.pnlInit.Size = new System.Drawing.Size(812, 49);
            this.pnlInit.TabIndex = 3;
            // 
            // txtCatalog
            // 
            this.txtCatalog.Location = new System.Drawing.Point(349, 27);
            this.txtCatalog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(168, 20);
            this.txtCatalog.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Initial Catalog:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(75, 25);
            this.txtSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(168, 20);
            this.txtSource.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Source:";
            // 
            // DBSPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 456);
            this.Controls.Add(this.tabIO);
            this.Controls.Add(this.pnlInit);
            this.Controls.Add(this.ddlSP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInput;
        private System.Windows.Forms.Panel pnlInit;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatalog;
    }
}

