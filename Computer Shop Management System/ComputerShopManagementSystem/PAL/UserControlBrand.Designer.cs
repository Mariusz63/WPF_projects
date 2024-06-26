﻿namespace ComputerShopManagementSystem.PAL
{
    partial class UserControlBrand
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcBrand = new System.Windows.Forms.TabControl();
            this.tpAddBrand = new System.Windows.Forms.TabPage();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageBrand = new System.Windows.Forms.TabPage();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBrandName = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.btnRemoveOption = new System.Windows.Forms.Button();
            this.btnChangeOptions = new System.Windows.Forms.Button();
            this.cmbStatusOptions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrandNameOptions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tcBrand.SuspendLayout();
            this.tpAddBrand.SuspendLayout();
            this.tpManageBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBrand
            // 
            this.tcBrand.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcBrand.Controls.Add(this.tpAddBrand);
            this.tcBrand.Controls.Add(this.tpManageBrand);
            this.tcBrand.Controls.Add(this.tpOptions);
            this.tcBrand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcBrand.Location = new System.Drawing.Point(15, 15);
            this.tcBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcBrand.Name = "tcBrand";
            this.tcBrand.SelectedIndex = 0;
            this.tcBrand.Size = new System.Drawing.Size(751, 450);
            this.tcBrand.TabIndex = 0;
            // 
            // tpAddBrand
            // 
            this.tpAddBrand.Controls.Add(this.btnAddBrand);
            this.tpAddBrand.Controls.Add(this.cmbStatus);
            this.tpAddBrand.Controls.Add(this.label3);
            this.tpAddBrand.Controls.Add(this.txtBrandName);
            this.tpAddBrand.Controls.Add(this.label2);
            this.tpAddBrand.Controls.Add(this.label1);
            this.tpAddBrand.Location = new System.Drawing.Point(4, 4);
            this.tpAddBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAddBrand.Name = "tpAddBrand";
            this.tpAddBrand.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAddBrand.Size = new System.Drawing.Size(743, 409);
            this.tpAddBrand.TabIndex = 0;
            this.tpAddBrand.Text = "Add Brand";
            this.tpAddBrand.UseVisualStyleBackColor = true;
            this.tpAddBrand.Enter += new System.EventHandler(this.tpAddBrand_Enter);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBrand.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.Location = new System.Drawing.Point(154, 260);
            this.btnAddBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(150, 62);
            this.btnAddBrand.TabIndex = 5;
            this.btnAddBrand.Text = "Add";
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "-- SELECT --",
            "Available",
            "Not Available"});
            this.cmbStatus.Location = new System.Drawing.Point(154, 193);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(246, 36);
            this.cmbStatus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(150, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status: ";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrandName.Location = new System.Drawing.Point(154, 109);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(438, 33);
            this.txtBrandName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(150, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Brand";
            // 
            // tpManageBrand
            // 
            this.tpManageBrand.Controls.Add(this.lblTotalNumber);
            this.tpManageBrand.Controls.Add(this.lblTotalText);
            this.tpManageBrand.Controls.Add(this.dgvBrand);
            this.tpManageBrand.Controls.Add(this.txtSearchBrandName);
            this.tpManageBrand.Controls.Add(this.picSearch);
            this.tpManageBrand.Controls.Add(this.label4);
            this.tpManageBrand.Controls.Add(this.label5);
            this.tpManageBrand.Location = new System.Drawing.Point(4, 4);
            this.tpManageBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpManageBrand.Name = "tpManageBrand";
            this.tpManageBrand.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpManageBrand.Size = new System.Drawing.Size(743, 409);
            this.tpManageBrand.TabIndex = 1;
            this.tpManageBrand.Text = "Manage Brand";
            this.tpManageBrand.UseVisualStyleBackColor = true;
            this.tpManageBrand.Enter += new System.EventHandler(this.tpManageBrand_Enter);
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalNumber.Location = new System.Drawing.Point(96, 431);
            this.lblTotalNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(33, 28);
            this.lblTotalNumber.TabIndex = 0;
            this.lblTotalNumber.Text = "{?}";
            // 
            // lblTotalText
            // 
            this.lblTotalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalText.Location = new System.Drawing.Point(21, 431);
            this.lblTotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(65, 28);
            this.lblTotalText.TabIndex = 0;
            this.lblTotalText.Text = "Total: ";
            // 
            // dgvBrand
            // 
            this.dgvBrand.AllowUserToAddRows = false;
            this.dgvBrand.AllowUserToDeleteRows = false;
            this.dgvBrand.AllowUserToResizeColumns = false;
            this.dgvBrand.AllowUserToResizeRows = false;
            this.dgvBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.White;
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrand.ColumnHeadersHeight = 40;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrand.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.Location = new System.Drawing.Point(8, 135);
            this.dgvBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.ReadOnly = true;
            this.dgvBrand.RowHeadersWidth = 62;
            this.dgvBrand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrand.ShowCellErrors = false;
            this.dgvBrand.ShowCellToolTips = false;
            this.dgvBrand.ShowEditingIcon = false;
            this.dgvBrand.ShowRowErrors = false;
            this.dgvBrand.Size = new System.Drawing.Size(727, 264);
            this.dgvBrand.TabIndex = 0;
            this.dgvBrand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrand_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Brand_Id";
            this.Column1.HeaderText = "Brand #";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Brand_Name";
            this.Column2.HeaderText = "Brand Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Brand_Status";
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtSearchBrandName
            // 
            this.txtSearchBrandName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchBrandName.Location = new System.Drawing.Point(91, 81);
            this.txtSearchBrandName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchBrandName.Name = "txtSearchBrandName";
            this.txtSearchBrandName.Size = new System.Drawing.Size(440, 33);
            this.txtSearchBrandName.TabIndex = 1;
            this.txtSearchBrandName.TextChanged += new System.EventHandler(this.txtSearchBrandName_TextChanged);
            // 
            // picSearch
            // 
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = global::ComputerShopManagementSystem.Properties.Resources.searchmagnifierinterfacesymbol1_79893;
            this.picSearch.Location = new System.Drawing.Point(539, 78);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(36, 36);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 6;
            this.picSearch.TabStop = false;
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(95, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Brand Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "../Manage Brand";
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.btnRemoveOption);
            this.tpOptions.Controls.Add(this.btnChangeOptions);
            this.tpOptions.Controls.Add(this.cmbStatusOptions);
            this.tpOptions.Controls.Add(this.label6);
            this.tpOptions.Controls.Add(this.txtBrandNameOptions);
            this.tpOptions.Controls.Add(this.label7);
            this.tpOptions.Controls.Add(this.label8);
            this.tpOptions.Location = new System.Drawing.Point(4, 4);
            this.tpOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpOptions.Size = new System.Drawing.Size(743, 409);
            this.tpOptions.TabIndex = 2;
            this.tpOptions.Text = "Options";
            this.tpOptions.UseVisualStyleBackColor = true;
            this.tpOptions.Enter += new System.EventHandler(this.tpOptions_Enter);
            this.tpOptions.Leave += new System.EventHandler(this.tpOptions_Leave);
            // 
            // btnRemoveOption
            // 
            this.btnRemoveOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnRemoveOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOption.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOption.ForeColor = System.Drawing.Color.White;
            this.btnRemoveOption.Location = new System.Drawing.Point(306, 247);
            this.btnRemoveOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveOption.Name = "btnRemoveOption";
            this.btnRemoveOption.Size = new System.Drawing.Size(150, 62);
            this.btnRemoveOption.TabIndex = 4;
            this.btnRemoveOption.Text = "Remove";
            this.btnRemoveOption.UseVisualStyleBackColor = false;
            this.btnRemoveOption.Click += new System.EventHandler(this.btnRemoveOption_Click);
            // 
            // btnChangeOptions
            // 
            this.btnChangeOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnChangeOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeOptions.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeOptions.ForeColor = System.Drawing.Color.White;
            this.btnChangeOptions.Location = new System.Drawing.Point(114, 247);
            this.btnChangeOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeOptions.Name = "btnChangeOptions";
            this.btnChangeOptions.Size = new System.Drawing.Size(150, 62);
            this.btnChangeOptions.TabIndex = 3;
            this.btnChangeOptions.Text = "Change";
            this.btnChangeOptions.UseVisualStyleBackColor = false;
            this.btnChangeOptions.Click += new System.EventHandler(this.btnChangeOptions_Click);
            // 
            // cmbStatusOptions
            // 
            this.cmbStatusOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatusOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusOptions.FormattingEnabled = true;
            this.cmbStatusOptions.Items.AddRange(new object[] {
            "-- SELECT --",
            "Available",
            "Not Available"});
            this.cmbStatusOptions.Location = new System.Drawing.Point(118, 175);
            this.cmbStatusOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatusOptions.Name = "cmbStatusOptions";
            this.cmbStatusOptions.Size = new System.Drawing.Size(246, 36);
            this.cmbStatusOptions.TabIndex = 2;
            this.cmbStatusOptions.SelectedIndexChanged += new System.EventHandler(this.cmbStatusOptions_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(113, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBrandNameOptions
            // 
            this.txtBrandNameOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrandNameOptions.Location = new System.Drawing.Point(114, 106);
            this.txtBrandNameOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBrandNameOptions.Name = "txtBrandNameOptions";
            this.txtBrandNameOptions.Size = new System.Drawing.Size(438, 33);
            this.txtBrandNameOptions.TabIndex = 1;
            this.txtBrandNameOptions.TextChanged += new System.EventHandler(this.txtBrandNameOptions_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(110, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Brand Name: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
            this.label8.Location = new System.Drawing.Point(9, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "../Options";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.btnAddBrand;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.btnChangeOptions;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.btnRemoveOption;
            // 
            // UserControlBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcBrand);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlBrand";
            this.Size = new System.Drawing.Size(780, 480);
            this.tcBrand.ResumeLayout(false);
            this.tpAddBrand.ResumeLayout(false);
            this.tpAddBrand.PerformLayout();
            this.tpManageBrand.ResumeLayout(false);
            this.tpManageBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBrand;
        private System.Windows.Forms.TabPage tpAddBrand;
        private System.Windows.Forms.TabPage tpManageBrand;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.TextBox txtSearchBrandName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChangeOptions;
        private System.Windows.Forms.ComboBox cmbStatusOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrandNameOptions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemoveOption;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
