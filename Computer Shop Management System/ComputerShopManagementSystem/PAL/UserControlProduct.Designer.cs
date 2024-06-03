namespace ComputerShopManagementSystem.PAL
{
    partial class UserControlProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcProduct = new System.Windows.Forms.TabControl();
            this.tpAddProduct = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numdQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numdRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManageProduct = new System.Windows.Forms.TabPage();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.btnRemoveOption = new System.Windows.Forms.Button();
            this.btnBrowseOptions = new System.Windows.Forms.Button();
            this.picbPhotoOptions = new System.Windows.Forms.PictureBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.cmbStatusOptions = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCategoryOptions = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBrandOptions = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numdQuantityOptions = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numdRateOptions = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProductNameOptions = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tcProduct.SuspendLayout();
            this.tpAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdRate)).BeginInit();
            this.tpManageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPhotoOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdQuantityOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdRateOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // tcProduct
            // 
            this.tcProduct.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcProduct.Controls.Add(this.tpAddProduct);
            this.tcProduct.Controls.Add(this.tpManageProduct);
            this.tcProduct.Controls.Add(this.tpOptions);
            this.tcProduct.Location = new System.Drawing.Point(10, 10);
            this.tcProduct.Name = "tcProduct";
            this.tcProduct.SelectedIndex = 0;
            this.tcProduct.Size = new System.Drawing.Size(760, 460);
            this.tcProduct.TabIndex = 0;
            this.tcProduct.Enter += new System.EventHandler(this.tcProduct_Enter);
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.Controls.Add(this.btnBrowse);
            this.tpAddProduct.Controls.Add(this.picPhoto);
            this.tpAddProduct.Controls.Add(this.btnAddProduct);
            this.tpAddProduct.Controls.Add(this.cmbStatus);
            this.tpAddProduct.Controls.Add(this.label7);
            this.tpAddProduct.Controls.Add(this.cmbCategory);
            this.tpAddProduct.Controls.Add(this.label6);
            this.tpAddProduct.Controls.Add(this.cmbBrand);
            this.tpAddProduct.Controls.Add(this.label5);
            this.tpAddProduct.Controls.Add(this.numdQuantity);
            this.tpAddProduct.Controls.Add(this.label4);
            this.tpAddProduct.Controls.Add(this.numdRate);
            this.tpAddProduct.Controls.Add(this.label3);
            this.tpAddProduct.Controls.Add(this.txtProductName);
            this.tpAddProduct.Controls.Add(this.label2);
            this.tpAddProduct.Controls.Add(this.label1);
            this.tpAddProduct.Location = new System.Drawing.Point(4, 4);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddProduct.Size = new System.Drawing.Size(752, 434);
            this.tpAddProduct.TabIndex = 0;
            this.tpAddProduct.Text = "Add Product";
            this.tpAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = global::ComputerShopManagementSystem.Properties.Resources.browse_icon_149519;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(529, 271);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(138, 51);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "    Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(505, 95);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(203, 161);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 27;
            this.picPhoto.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(35, 369);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 40);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.btnAddProduct.Enter += new System.EventHandler(this.btnAddProduct_Enter);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "-- SELECT --",
            "Available",
            "Not Available"});
            this.cmbStatus.Location = new System.Drawing.Point(35, 325);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(206, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(32, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "-- SELECT --"});
            this.cmbCategory.Location = new System.Drawing.Point(35, 271);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(206, 21);
            this.cmbCategory.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(32, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category:";
            // 
            // cmbBrand
            // 
            this.cmbBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBrand.BackColor = System.Drawing.Color.White;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "-- SELECT --"});
            this.cmbBrand.Location = new System.Drawing.Point(35, 216);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(206, 21);
            this.cmbBrand.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(32, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Brand:";
            // 
            // numdQuantity
            // 
            this.numdQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numdQuantity.Location = new System.Drawing.Point(262, 161);
            this.numdQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numdQuantity.Name = "numdQuantity";
            this.numdQuantity.Size = new System.Drawing.Size(206, 22);
            this.numdQuantity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(259, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // numdRate
            // 
            this.numdRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numdRate.Location = new System.Drawing.Point(35, 161);
            this.numdRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numdRate.Name = "numdRate";
            this.numdRate.Size = new System.Drawing.Size(206, 22);
            this.numdRate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rate:";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Location = new System.Drawing.Point(35, 95);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(433, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "../Add Product";
            // 
            // tpManageProduct
            // 
            this.tpManageProduct.Controls.Add(this.txtSearchProductName);
            this.tpManageProduct.Controls.Add(this.lblTotalNumber);
            this.tpManageProduct.Controls.Add(this.lblTotal);
            this.tpManageProduct.Controls.Add(this.dgvProduct);
            this.tpManageProduct.Controls.Add(this.label8);
            this.tpManageProduct.Controls.Add(this.label9);
            this.tpManageProduct.Controls.Add(this.picSearch);
            this.tpManageProduct.Location = new System.Drawing.Point(4, 4);
            this.tpManageProduct.Name = "tpManageProduct";
            this.tpManageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageProduct.Size = new System.Drawing.Size(752, 434);
            this.tpManageProduct.TabIndex = 1;
            this.tpManageProduct.Text = "Manage Product";
            this.tpManageProduct.UseVisualStyleBackColor = true;
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchProductName.Location = new System.Drawing.Point(194, 83);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(295, 22);
            this.txtSearchProductName.TabIndex = 1;
            this.txtSearchProductName.TextChanged += new System.EventHandler(this.txtSearchProductName_TextChanged);
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalNumber.Location = new System.Drawing.Point(64, 364);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(22, 17);
            this.lblTotalNumber.TabIndex = 2;
            this.lblTotalNumber.Text = "{?}";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(14, 364);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: ";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProduct.ColumnHeadersHeight = 25;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(18, 141);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.ShowCellErrors = false;
            this.dgvProduct.ShowCellToolTips = false;
            this.dgvProduct.ShowEditingIcon = false;
            this.dgvProduct.ShowRowErrors = false;
            this.dgvProduct.Size = new System.Drawing.Size(718, 220);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Product_Id";
            this.Column1.HeaderText = "Product #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Product_Image";
            this.Column4.HeaderText = "Photo";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Product_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Product_Rate";
            this.Column8.HeaderText = "Rate";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Product_Quantity";
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Product_Brand";
            this.Column5.HeaderText = "Brand";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Product_Category";
            this.Column6.HeaderText = "Category";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Product_Status";
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(190, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "../Manage Product";
            // 
            // picSearch
            // 
            this.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = global::ComputerShopManagementSystem.Properties.Resources.searchmagnifierinterfacesymbol1_79893;
            this.picSearch.Location = new System.Drawing.Point(486, 83);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(25, 25);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 20;
            this.picSearch.TabStop = false;
            this.picSearch.MouseHover += new System.EventHandler(this.picSearch_MouseHover);
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.btnRemoveOption);
            this.tpOptions.Controls.Add(this.btnBrowseOptions);
            this.tpOptions.Controls.Add(this.picbPhotoOptions);
            this.tpOptions.Controls.Add(this.btnChange);
            this.tpOptions.Controls.Add(this.cmbStatusOptions);
            this.tpOptions.Controls.Add(this.label10);
            this.tpOptions.Controls.Add(this.cmbCategoryOptions);
            this.tpOptions.Controls.Add(this.label11);
            this.tpOptions.Controls.Add(this.cmbBrandOptions);
            this.tpOptions.Controls.Add(this.label12);
            this.tpOptions.Controls.Add(this.numdQuantityOptions);
            this.tpOptions.Controls.Add(this.label13);
            this.tpOptions.Controls.Add(this.numdRateOptions);
            this.tpOptions.Controls.Add(this.label14);
            this.tpOptions.Controls.Add(this.txtProductNameOptions);
            this.tpOptions.Controls.Add(this.label15);
            this.tpOptions.Controls.Add(this.label16);
            this.tpOptions.Location = new System.Drawing.Point(4, 4);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(752, 434);
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
            this.btnRemoveOption.Location = new System.Drawing.Point(173, 369);
            this.btnRemoveOption.Name = "btnRemoveOption";
            this.btnRemoveOption.Size = new System.Drawing.Size(100, 40);
            this.btnRemoveOption.TabIndex = 8;
            this.btnRemoveOption.Text = "Remove";
            this.btnRemoveOption.UseVisualStyleBackColor = false;
            this.btnRemoveOption.Click += new System.EventHandler(this.btnRemoveOption_Click);
            // 
            // btnBrowseOptions
            // 
            this.btnBrowseOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnBrowseOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOptions.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOptions.ForeColor = System.Drawing.Color.White;
            this.btnBrowseOptions.Image = global::ComputerShopManagementSystem.Properties.Resources.browse_icon_149519;
            this.btnBrowseOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseOptions.Location = new System.Drawing.Point(526, 271);
            this.btnBrowseOptions.Name = "btnBrowseOptions";
            this.btnBrowseOptions.Size = new System.Drawing.Size(138, 51);
            this.btnBrowseOptions.TabIndex = 9;
            this.btnBrowseOptions.Text = "    Browse";
            this.btnBrowseOptions.UseVisualStyleBackColor = false;
            this.btnBrowseOptions.Click += new System.EventHandler(this.btnBrowseOptions_Click);
            // 
            // picbPhotoOptions
            // 
            this.picbPhotoOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbPhotoOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbPhotoOptions.Location = new System.Drawing.Point(502, 95);
            this.picbPhotoOptions.Name = "picbPhotoOptions";
            this.picbPhotoOptions.Size = new System.Drawing.Size(203, 161);
            this.picbPhotoOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPhotoOptions.TabIndex = 43;
            this.picbPhotoOptions.TabStop = false;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(32, 369);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 40);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cmbStatusOptions
            // 
            this.cmbStatusOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatusOptions.BackColor = System.Drawing.Color.White;
            this.cmbStatusOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusOptions.FormattingEnabled = true;
            this.cmbStatusOptions.Items.AddRange(new object[] {
            "-- SELECT --",
            "Available",
            "Not Available"});
            this.cmbStatusOptions.Location = new System.Drawing.Point(32, 325);
            this.cmbStatusOptions.Name = "cmbStatusOptions";
            this.cmbStatusOptions.Size = new System.Drawing.Size(206, 21);
            this.cmbStatusOptions.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(29, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Status:";
            // 
            // cmbCategoryOptions
            // 
            this.cmbCategoryOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategoryOptions.BackColor = System.Drawing.Color.White;
            this.cmbCategoryOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoryOptions.FormattingEnabled = true;
            this.cmbCategoryOptions.Items.AddRange(new object[] {
            "-- SELECT --"});
            this.cmbCategoryOptions.Location = new System.Drawing.Point(32, 271);
            this.cmbCategoryOptions.Name = "cmbCategoryOptions";
            this.cmbCategoryOptions.Size = new System.Drawing.Size(206, 21);
            this.cmbCategoryOptions.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(29, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Category:";
            // 
            // cmbBrandOptions
            // 
            this.cmbBrandOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBrandOptions.BackColor = System.Drawing.Color.White;
            this.cmbBrandOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrandOptions.FormattingEnabled = true;
            this.cmbBrandOptions.Items.AddRange(new object[] {
            "-- SELECT --"});
            this.cmbBrandOptions.Location = new System.Drawing.Point(32, 216);
            this.cmbBrandOptions.Name = "cmbBrandOptions";
            this.cmbBrandOptions.Size = new System.Drawing.Size(206, 21);
            this.cmbBrandOptions.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(29, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Brand:";
            // 
            // numdQuantityOptions
            // 
            this.numdQuantityOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numdQuantityOptions.Location = new System.Drawing.Point(259, 161);
            this.numdQuantityOptions.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numdQuantityOptions.Name = "numdQuantityOptions";
            this.numdQuantityOptions.Size = new System.Drawing.Size(206, 22);
            this.numdQuantityOptions.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(256, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Quantity:";
            // 
            // numdRateOptions
            // 
            this.numdRateOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numdRateOptions.Location = new System.Drawing.Point(32, 161);
            this.numdRateOptions.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numdRateOptions.Name = "numdRateOptions";
            this.numdRateOptions.Size = new System.Drawing.Size(206, 22);
            this.numdRateOptions.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(29, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Rate:";
            // 
            // txtProductNameOptions
            // 
            this.txtProductNameOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductNameOptions.Location = new System.Drawing.Point(32, 95);
            this.txtProductNameOptions.Name = "txtProductNameOptions";
            this.txtProductNameOptions.Size = new System.Drawing.Size(433, 22);
            this.txtProductNameOptions.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(29, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Product Name: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(110)))));
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "../Options Product";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.btnAddProduct;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.btnBrowse;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.btnChange;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.btnRemoveOption;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.TargetControl = this.btnBrowseOptions;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(780, 480);
            this.tcProduct.ResumeLayout(false);
            this.tpAddProduct.ResumeLayout(false);
            this.tpAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdRate)).EndInit();
            this.tpManageProduct.ResumeLayout(false);
            this.tpManageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPhotoOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdQuantityOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdRateOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProduct;
        private System.Windows.Forms.TabPage tpAddProduct;
        private System.Windows.Forms.TabPage tpManageProduct;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numdQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numdRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnAddProduct;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.TextBox txtSearchProductName;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnBrowseOptions;
        private System.Windows.Forms.PictureBox picbPhotoOptions;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbStatusOptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCategoryOptions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBrandOptions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numdQuantityOptions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numdRateOptions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProductNameOptions;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnRemoveOption;
    }
}
