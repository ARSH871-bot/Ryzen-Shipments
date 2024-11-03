namespace Ryzen_Shipments
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.fowLayoutPanel1 = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblLogo = new System.Windows.Forms.Label();
            this.PnlHome = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PnlCustomers = new System.Windows.Forms.Panel();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnCompanies = new System.Windows.Forms.Button();
            this.BtnPersons = new System.Windows.Forms.Button();
            this.PnlOrders = new System.Windows.Forms.Panel();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.PnlAccounting = new System.Windows.Forms.Panel();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.BtnReceived = new System.Windows.Forms.Button();
            this.BtnAccounting = new System.Windows.Forms.Button();
            this.BtnRights = new System.Windows.Forms.Button();
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.BtnApplicationSettings = new System.Windows.Forms.Button();
            this.BtnUsersSettings = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlLeft.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.fowLayoutPanel1.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlHome.SuspendLayout();
            this.PnlCustomers.SuspendLayout();
            this.PnlOrders.SuspendLayout();
            this.PnlAccounting.SuspendLayout();
            this.PnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.Controls.Add(this.fowLayoutPanel1);
            this.PnlLeft.Controls.Add(this.PnlTitle);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 10);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(250, 640);
            this.PnlLeft.TabIndex = 0;
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.label1);
            this.PnlTitle.Controls.Add(this.LblLogo);
            this.PnlTitle.Controls.Add(this.PicLogo);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(250, 126);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitle_Paint);
            // 
            // fowLayoutPanel1
            // 
            this.fowLayoutPanel1.Controls.Add(this.PnlMenu);
            this.fowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fowLayoutPanel1.Location = new System.Drawing.Point(0, 126);
            this.fowLayoutPanel1.Name = "fowLayoutPanel1";
            this.fowLayoutPanel1.Size = new System.Drawing.Size(250, 514);
            this.fowLayoutPanel1.TabIndex = 0;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.BtnExit);
            this.PnlMenu.Controls.Add(this.PnlSettings);
            this.PnlMenu.Controls.Add(this.PnlAccounting);
            this.PnlMenu.Controls.Add(this.PnlOrders);
            this.PnlMenu.Controls.Add(this.PnlCustomers);
            this.PnlMenu.Controls.Add(this.PnlHome);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(250, 514);
            this.PnlMenu.TabIndex = 1;
            this.PnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.White;
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(250, 10);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(740, 640);
            this.PnlMain.TabIndex = 1;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(0, 29);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(60, 60);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            this.PicLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblLogo.Location = new System.Drawing.Point(60, 29);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(174, 28);
            this.LblLogo.TabIndex = 1;
            this.LblLogo.Text = "Ryzen Shipments";
            this.LblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // PnlHome
            // 
            this.PnlHome.Controls.Add(this.BtnHome);
            this.PnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHome.Location = new System.Drawing.Point(0, 0);
            this.PnlHome.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(250, 45);
            this.PnlHome.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.Location = new System.Drawing.Point(0, 2);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(50, 0, 20, 0);
            this.BtnHome.Size = new System.Drawing.Size(230, 40);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PnlCustomers
            // 
            this.PnlCustomers.Controls.Add(this.BtnPersons);
            this.PnlCustomers.Controls.Add(this.BtnCompanies);
            this.PnlCustomers.Controls.Add(this.BtnCustomers);
            this.PnlCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCustomers.Location = new System.Drawing.Point(0, 45);
            this.PnlCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.PnlCustomers.Name = "PnlCustomers";
            this.PnlCustomers.Size = new System.Drawing.Size(250, 110);
            this.PnlCustomers.TabIndex = 1;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnCustomers.FlatAppearance.BorderSize = 0;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCustomers.Location = new System.Drawing.Point(-30, 2);
            this.BtnCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnCustomers.Size = new System.Drawing.Size(230, 40);
            this.BtnCustomers.TabIndex = 0;
            this.BtnCustomers.Text = "Customers";
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnCompanies
            // 
            this.BtnCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BtnCompanies.FlatAppearance.BorderSize = 0;
            this.BtnCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompanies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnCompanies.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCompanies.Location = new System.Drawing.Point(-30, 44);
            this.BtnCompanies.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCompanies.Name = "BtnCompanies";
            this.BtnCompanies.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnCompanies.Size = new System.Drawing.Size(230, 30);
            this.BtnCompanies.TabIndex = 1;
            this.BtnCompanies.Text = "Companies";
            this.BtnCompanies.UseVisualStyleBackColor = false;
            this.BtnCompanies.Click += new System.EventHandler(this.BtnCompanies);
            // 
            // BtnPersons
            // 
            this.BtnPersons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BtnPersons.FlatAppearance.BorderSize = 0;
            this.BtnPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersons.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnPersons.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPersons.Location = new System.Drawing.Point(-30, 76);
            this.BtnPersons.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPersons.Name = "BtnPersons";
            this.BtnPersons.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnPersons.Size = new System.Drawing.Size(230, 30);
            this.BtnPersons.TabIndex = 2;
            this.BtnPersons.Text = "Persons";
            this.BtnPersons.UseVisualStyleBackColor = false;
            this.BtnPersons.Click += new System.EventHandler(this.button2_Click);
            // 
            // PnlOrders
            // 
            this.PnlOrders.Controls.Add(this.BtnOrders);
            this.PnlOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlOrders.Location = new System.Drawing.Point(0, 155);
            this.PnlOrders.Margin = new System.Windows.Forms.Padding(0);
            this.PnlOrders.Name = "PnlOrders";
            this.PnlOrders.Size = new System.Drawing.Size(250, 45);
            this.PnlOrders.TabIndex = 2;
            // 
            // BtnOrders
            // 
            this.BtnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnOrders.FlatAppearance.BorderSize = 0;
            this.BtnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOrders.Location = new System.Drawing.Point(-30, 2);
            this.BtnOrders.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnOrders.Size = new System.Drawing.Size(230, 40);
            this.BtnOrders.TabIndex = 0;
            this.BtnOrders.Text = "Orders";
            this.BtnOrders.UseVisualStyleBackColor = false;
            // 
            // PnlAccounting
            // 
            this.PnlAccounting.Controls.Add(this.BtnRights);
            this.PnlAccounting.Controls.Add(this.BtnPayment);
            this.PnlAccounting.Controls.Add(this.BtnReceived);
            this.PnlAccounting.Controls.Add(this.BtnAccounting);
            this.PnlAccounting.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlAccounting.Location = new System.Drawing.Point(0, 200);
            this.PnlAccounting.Margin = new System.Windows.Forms.Padding(0);
            this.PnlAccounting.Name = "PnlAccounting";
            this.PnlAccounting.Size = new System.Drawing.Size(250, 142);
            this.PnlAccounting.TabIndex = 3;
            // 
            // BtnPayment
            // 
            this.BtnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BtnPayment.FlatAppearance.BorderSize = 0;
            this.BtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPayment.Location = new System.Drawing.Point(-30, 76);
            this.BtnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnPayment.Size = new System.Drawing.Size(230, 30);
            this.BtnPayment.TabIndex = 2;
            this.BtnPayment.Text = "Payment";
            this.BtnPayment.UseVisualStyleBackColor = false;
            // 
            // BtnReceived
            // 
            this.BtnReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BtnReceived.FlatAppearance.BorderSize = 0;
            this.BtnReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceived.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnReceived.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReceived.Location = new System.Drawing.Point(-30, 44);
            this.BtnReceived.Margin = new System.Windows.Forms.Padding(0);
            this.BtnReceived.Name = "BtnReceived";
            this.BtnReceived.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnReceived.Size = new System.Drawing.Size(230, 30);
            this.BtnReceived.TabIndex = 1;
            this.BtnReceived.Text = "Received";
            this.BtnReceived.UseVisualStyleBackColor = false;
            // 
            // BtnAccounting
            // 
            this.BtnAccounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnAccounting.FlatAppearance.BorderSize = 0;
            this.BtnAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccounting.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccounting.Location = new System.Drawing.Point(-30, 2);
            this.BtnAccounting.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAccounting.Name = "BtnAccounting";
            this.BtnAccounting.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnAccounting.Size = new System.Drawing.Size(230, 40);
            this.BtnAccounting.TabIndex = 0;
            this.BtnAccounting.Text = "Accounting";
            this.BtnAccounting.UseVisualStyleBackColor = false;
            // 
            // BtnRights
            // 
            this.BtnRights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BtnRights.FlatAppearance.BorderSize = 0;
            this.BtnRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRights.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnRights.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRights.Location = new System.Drawing.Point(-30, 108);
            this.BtnRights.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRights.Name = "BtnRights";
            this.BtnRights.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnRights.Size = new System.Drawing.Size(230, 30);
            this.BtnRights.TabIndex = 3;
            this.BtnRights.Text = "Rights";
            this.BtnRights.UseVisualStyleBackColor = false;
            // 
            // PnlSettings
            // 
            this.PnlSettings.Controls.Add(this.BtnApplicationSettings);
            this.PnlSettings.Controls.Add(this.BtnUsersSettings);
            this.PnlSettings.Controls.Add(this.BtnSettings);
            this.PnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSettings.Location = new System.Drawing.Point(0, 342);
            this.PnlSettings.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSettings.Name = "PnlSettings";
            this.PnlSettings.Size = new System.Drawing.Size(250, 110);
            this.PnlSettings.TabIndex = 4;
            // 
            // BtnApplicationSettings
            // 
            this.BtnApplicationSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BtnApplicationSettings.FlatAppearance.BorderSize = 0;
            this.BtnApplicationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApplicationSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnApplicationSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnApplicationSettings.Location = new System.Drawing.Point(-60, 76);
            this.BtnApplicationSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnApplicationSettings.Name = "BtnApplicationSettings";
            this.BtnApplicationSettings.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnApplicationSettings.Size = new System.Drawing.Size(260, 30);
            this.BtnApplicationSettings.TabIndex = 2;
            this.BtnApplicationSettings.Text = "Application Settings";
            this.BtnApplicationSettings.UseVisualStyleBackColor = false;
            // 
            // BtnUsersSettings
            // 
            this.BtnUsersSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.BtnUsersSettings.FlatAppearance.BorderSize = 0;
            this.BtnUsersSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsersSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnUsersSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsersSettings.Location = new System.Drawing.Point(-30, 44);
            this.BtnUsersSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUsersSettings.Name = "BtnUsersSettings";
            this.BtnUsersSettings.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnUsersSettings.Size = new System.Drawing.Size(230, 30);
            this.BtnUsersSettings.TabIndex = 1;
            this.BtnUsersSettings.Text = "Users Settings";
            this.BtnUsersSettings.UseVisualStyleBackColor = false;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSettings.Location = new System.Drawing.Point(-30, 2);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnSettings.Size = new System.Drawing.Size(230, 40);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.Location = new System.Drawing.Point(0, 474);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.BtnExit.Size = new System.Drawing.Size(250, 40);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ryzenshipments@gmail.com";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlLeft.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.fowLayoutPanel1.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlHome.ResumeLayout(false);
            this.PnlCustomers.ResumeLayout(false);
            this.PnlOrders.ResumeLayout(false);
            this.PnlAccounting.ResumeLayout(false);
            this.PnlSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel fowLayoutPanel1;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.Panel PnlHome;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel PnlCustomers;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnCompanies;
        private System.Windows.Forms.Button BtnPersons;
        private System.Windows.Forms.Panel PnlOrders;
        private System.Windows.Forms.Button BtnOrders;
        private System.Windows.Forms.Panel PnlAccounting;
        private System.Windows.Forms.Button BtnRights;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Button BtnReceived;
        private System.Windows.Forms.Button BtnAccounting;
        private System.Windows.Forms.Panel PnlSettings;
        private System.Windows.Forms.Button BtnApplicationSettings;
        private System.Windows.Forms.Button BtnUsersSettings;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
    }
}

