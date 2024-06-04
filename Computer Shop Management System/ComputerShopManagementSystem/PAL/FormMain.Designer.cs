namespace ComputerShopManagementSystem.PAL
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeAndDate = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.userControlReport1 = new ComputerShopManagementSystem.PAL.UserControlReport();
            this.userControlUser1 = new ComputerShopManagementSystem.PAL.UserControlUser();
            this.userControlOrder1 = new ComputerShopManagementSystem.PAL.UserControlOrder();
            this.userControlProduct1 = new ComputerShopManagementSystem.PAL.UserControlProduct();
            this.userControlCategory1 = new ComputerShopManagementSystem.PAL.UserControlCategory();
            this.userControlBrand1 = new ComputerShopManagementSystem.PAL.UserControlBrand();
            this.userControlDashboard1 = new ComputerShopManagementSystem.PAL.UserControlDashboard();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pnlMove);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnBrand);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 600);
            this.panel1.TabIndex = 0;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            this.pnlMove.Location = new System.Drawing.Point(3, 228);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(10, 38);
            this.pnlMove.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::ComputerShopManagementSystem.Properties.Resources.log_out_icon_icons_com_50106;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(12, 548);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 40);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::ComputerShopManagementSystem.Properties.Resources.group_profile_users_icon_icons_com_73540;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(10, 502);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 40);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::ComputerShopManagementSystem.Properties.Resources.report_document_finance_business_analysis_analytics_chart_icon_188615;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(10, 456);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 40);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = global::ComputerShopManagementSystem.Properties.Resources.product_delivery_icon_152013;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(12, 410);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 40);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::ComputerShopManagementSystem.Properties.Resources.product_searching_icon_181876;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(12, 364);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 40);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::ComputerShopManagementSystem.Properties.Resources.category_icon_176162;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(12, 318);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 40);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Image = global::ComputerShopManagementSystem.Properties.Resources.branding_envelope_paper_icon_193864;
            this.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.Location = new System.Drawing.Point(12, 272);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(200, 40);
            this.btnBrand.TabIndex = 0;
            this.btnBrand.Text = "Brand";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::ComputerShopManagementSystem.Properties.Resources.dashboard_3624__1_;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 226);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComputerShopManagementSystem.Properties.Resources._1458264592_laptop_computer_pc_device_notebook_netbook_internet_icon_icons_com_55334;
            this.pictureBox1.Location = new System.Drawing.Point(57, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 3;
            this.gunaElipse1.TargetControl = this.pnlMove;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.lblTimeAndDate);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 80);
            this.panel2.TabIndex = 0;
            // 
            // lblTimeAndDate
            // 
            this.lblTimeAndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeAndDate.AutoSize = true;
            this.lblTimeAndDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeAndDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeAndDate.Location = new System.Drawing.Point(721, 23);
            this.lblTimeAndDate.Name = "lblTimeAndDate";
            this.lblTimeAndDate.Size = new System.Drawing.Size(33, 25);
            this.lblTimeAndDate.TabIndex = 5;
            this.lblTimeAndDate.Text = "{?}";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(181, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(33, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "{?}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(220, 560);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 40);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Copyright © 2024. All rights Reserved.";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.userControlReport1);
            this.pnlCenter.Controls.Add(this.userControlUser1);
            this.pnlCenter.Controls.Add(this.userControlOrder1);
            this.pnlCenter.Controls.Add(this.userControlProduct1);
            this.pnlCenter.Controls.Add(this.userControlCategory1);
            this.pnlCenter.Controls.Add(this.userControlBrand1);
            this.pnlCenter.Controls.Add(this.userControlDashboard1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(220, 80);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(780, 480);
            this.pnlCenter.TabIndex = 0;
            // 
            // userControlReport1
            // 
            this.userControlReport1.BackColor = System.Drawing.Color.White;
            this.userControlReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReport1.Location = new System.Drawing.Point(0, 0);
            this.userControlReport1.Name = "userControlReport1";
            this.userControlReport1.Size = new System.Drawing.Size(780, 480);
            this.userControlReport1.TabIndex = 0;
            // 
            // userControlUser1
            // 
            this.userControlUser1.BackColor = System.Drawing.Color.White;
            this.userControlUser1.Location = new System.Drawing.Point(9, 24);
            this.userControlUser1.Name = "userControlUser1";
            this.userControlUser1.Size = new System.Drawing.Size(747, 464);
            this.userControlUser1.TabIndex = 2;
            // 
            // userControlOrder1
            // 
            this.userControlOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlOrder1.Location = new System.Drawing.Point(0, 0);
            this.userControlOrder1.Name = "userControlOrder1";
            this.userControlOrder1.Size = new System.Drawing.Size(780, 480);
            this.userControlOrder1.TabIndex = 0;
            this.userControlOrder1.Visible = false;
            // 
            // userControlProduct1
            // 
            this.userControlProduct1.BackColor = System.Drawing.Color.White;
            this.userControlProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlProduct1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlProduct1.Location = new System.Drawing.Point(0, 0);
            this.userControlProduct1.Name = "userControlProduct1";
            this.userControlProduct1.Size = new System.Drawing.Size(780, 480);
            this.userControlProduct1.TabIndex = 0;
            // 
            // userControlCategory1
            // 
            this.userControlCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCategory1.Location = new System.Drawing.Point(0, 0);
            this.userControlCategory1.Name = "userControlCategory1";
            this.userControlCategory1.Size = new System.Drawing.Size(780, 480);
            this.userControlCategory1.TabIndex = 0;
            this.userControlCategory1.Visible = false;
            // 
            // userControlBrand1
            // 
            this.userControlBrand1.BackColor = System.Drawing.Color.White;
            this.userControlBrand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBrand1.Location = new System.Drawing.Point(0, 0);
            this.userControlBrand1.Name = "userControlBrand1";
            this.userControlBrand1.Size = new System.Drawing.Size(780, 480);
            this.userControlBrand1.TabIndex = 0;
            this.userControlBrand1.Visible = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(780, 480);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlMove;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimeAndDate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Timer timerDateAndTime;
        private UserControlDashboard userControlDashboard1;
        private UserControlBrand userControlBrand1;
        private UserControlCategory userControlCategory1;
        private UserControlProduct userControlProduct1;
        private UserControlOrder userControlOrder1;
        private UserControlUser userControlUser1;
        private UserControlReport userControlReport1;
    }
}