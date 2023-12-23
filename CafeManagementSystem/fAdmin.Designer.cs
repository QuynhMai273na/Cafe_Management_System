
namespace CafeManagementSystem
{
    public partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.Accounts = new System.Windows.Forms.TabPage();
            this.guna2PanelSmallAccounts = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelUserProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.Categories = new System.Windows.Forms.TabPage();
            this.Receipts = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonCheckBill = new Guna.UI2.WinForms.Guna2Button();
            this.labelTo = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.guna2DateTimePickeTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2PanelTopTabReceipts = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonDeleteReceipts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAddReceipts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControlAdmin = new Guna.UI2.WinForms.Guna2TabControl();
            this.guna2PictureBoxRefresh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBoxSearchReceipts = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBoxUserProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBoxUserProfile = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Accounts.SuspendLayout();
            this.guna2PanelUserProfile.SuspendLayout();
            this.Categories.SuspendLayout();
            this.Receipts.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2PanelTopTabReceipts.SuspendLayout();
            this.guna2TabControlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxUserProfile)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Accounts
            // 
            this.Accounts.Controls.Add(this.guna2PanelSmallAccounts);
            this.Accounts.Controls.Add(this.guna2PanelUserProfile);
            this.Accounts.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounts.Location = new System.Drawing.Point(184, 4);
            this.Accounts.Name = "Accounts";
            this.Accounts.Padding = new System.Windows.Forms.Padding(3);
            this.Accounts.Size = new System.Drawing.Size(787, 693);
            this.Accounts.TabIndex = 2;
            this.Accounts.Text = "Accounts";
            this.Accounts.UseVisualStyleBackColor = true;
            // 
            // guna2PanelSmallAccounts
            // 
            this.guna2PanelSmallAccounts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelSmallAccounts.BorderThickness = 2;
            this.guna2PanelSmallAccounts.Location = new System.Drawing.Point(0, 41);
            this.guna2PanelSmallAccounts.Name = "guna2PanelSmallAccounts";
            this.guna2PanelSmallAccounts.Size = new System.Drawing.Size(787, 652);
            this.guna2PanelSmallAccounts.TabIndex = 3;
            // 
            // guna2PanelUserProfile
            // 
            this.guna2PanelUserProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelUserProfile.BorderThickness = 2;
            this.guna2PanelUserProfile.Controls.Add(this.guna2PictureBoxUserProfile);
            this.guna2PanelUserProfile.Controls.Add(this.guna2ButtonDeleteUser);
            this.guna2PanelUserProfile.Controls.Add(this.guna2ButtonAddUser);
            this.guna2PanelUserProfile.Controls.Add(this.guna2TextBoxUserProfile);
            this.guna2PanelUserProfile.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelUserProfile.Name = "guna2PanelUserProfile";
            this.guna2PanelUserProfile.Size = new System.Drawing.Size(787, 43);
            this.guna2PanelUserProfile.TabIndex = 2;
            // 
            // guna2ButtonDeleteUser
            // 
            this.guna2ButtonDeleteUser.AutoRoundedCorners = true;
            this.guna2ButtonDeleteUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonDeleteUser.BorderRadius = 17;
            this.guna2ButtonDeleteUser.BorderThickness = 2;
            this.guna2ButtonDeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDeleteUser.FillColor = System.Drawing.Color.Red;
            this.guna2ButtonDeleteUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDeleteUser.Location = new System.Drawing.Point(614, 4);
            this.guna2ButtonDeleteUser.Name = "guna2ButtonDeleteUser";
            this.guna2ButtonDeleteUser.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonDeleteUser.TabIndex = 2;
            this.guna2ButtonDeleteUser.Text = "Delete";
            // 
            // guna2ButtonAddUser
            // 
            this.guna2ButtonAddUser.AutoRoundedCorners = true;
            this.guna2ButtonAddUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonAddUser.BorderRadius = 17;
            this.guna2ButtonAddUser.BorderThickness = 2;
            this.guna2ButtonAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonAddUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonAddUser.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAddUser.Location = new System.Drawing.Point(487, 4);
            this.guna2ButtonAddUser.Name = "guna2ButtonAddUser";
            this.guna2ButtonAddUser.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonAddUser.TabIndex = 1;
            this.guna2ButtonAddUser.Text = "Add";
            // 
            // Categories
            // 
            this.Categories.Controls.Add(this.guna2Panel2);
            this.Categories.Controls.Add(this.guna2Panel3);
            this.Categories.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(184, 4);
            this.Categories.Name = "Categories";
            this.Categories.Padding = new System.Windows.Forms.Padding(3);
            this.Categories.Size = new System.Drawing.Size(787, 693);
            this.Categories.TabIndex = 1;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = true;
            // 
            // Receipts
            // 
            this.Receipts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Receipts.Controls.Add(this.guna2Panel1);
            this.Receipts.Controls.Add(this.guna2PanelTopTabReceipts);
            this.Receipts.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipts.Location = new System.Drawing.Point(184, 4);
            this.Receipts.Name = "Receipts";
            this.Receipts.Padding = new System.Windows.Forms.Padding(3);
            this.Receipts.Size = new System.Drawing.Size(787, 693);
            this.Receipts.TabIndex = 0;
            this.Receipts.Text = "Receipts";
            this.Receipts.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2ButtonCheckBill);
            this.guna2Panel1.Controls.Add(this.labelTo);
            this.guna2Panel1.Controls.Add(this.From);
            this.guna2Panel1.Controls.Add(this.guna2DateTimePickeTo);
            this.guna2Panel1.Controls.Add(this.guna2DateTimePickerFrom);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 42);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(787, 45);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2ButtonCheckBill
            // 
            this.guna2ButtonCheckBill.AutoRoundedCorners = true;
            this.guna2ButtonCheckBill.BorderRadius = 16;
            this.guna2ButtonCheckBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCheckBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCheckBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCheckBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCheckBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonCheckBill.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonCheckBill.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCheckBill.Location = new System.Drawing.Point(661, 4);
            this.guna2ButtonCheckBill.Name = "guna2ButtonCheckBill";
            this.guna2ButtonCheckBill.Size = new System.Drawing.Size(106, 35);
            this.guna2ButtonCheckBill.TabIndex = 3;
            this.guna2ButtonCheckBill.Text = "Check";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.labelTo.Location = new System.Drawing.Point(350, 13);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(28, 19);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.From.Location = new System.Drawing.Point(21, 13);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(50, 19);
            this.From.TabIndex = 3;
            this.From.Text = "From";
            // 
            // guna2DateTimePickeTo
            // 
            this.guna2DateTimePickeTo.AutoRoundedCorners = true;
            this.guna2DateTimePickeTo.BorderRadius = 14;
            this.guna2DateTimePickeTo.Checked = true;
            this.guna2DateTimePickeTo.FillColor = System.Drawing.Color.Silver;
            this.guna2DateTimePickeTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePickeTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePickeTo.Location = new System.Drawing.Point(394, 7);
            this.guna2DateTimePickeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePickeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePickeTo.Name = "guna2DateTimePickeTo";
            this.guna2DateTimePickeTo.Size = new System.Drawing.Size(250, 30);
            this.guna2DateTimePickeTo.TabIndex = 2;
            this.guna2DateTimePickeTo.Value = new System.DateTime(2023, 12, 23, 3, 5, 23, 896);
            // 
            // guna2DateTimePickerFrom
            // 
            this.guna2DateTimePickerFrom.AutoRoundedCorners = true;
            this.guna2DateTimePickerFrom.BorderRadius = 14;
            this.guna2DateTimePickerFrom.Checked = true;
            this.guna2DateTimePickerFrom.FillColor = System.Drawing.Color.Silver;
            this.guna2DateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePickerFrom.Location = new System.Drawing.Point(84, 7);
            this.guna2DateTimePickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePickerFrom.Name = "guna2DateTimePickerFrom";
            this.guna2DateTimePickerFrom.Size = new System.Drawing.Size(250, 30);
            this.guna2DateTimePickerFrom.TabIndex = 1;
            this.guna2DateTimePickerFrom.Value = new System.DateTime(2023, 12, 23, 3, 5, 23, 896);
            // 
            // guna2PanelTopTabReceipts
            // 
            this.guna2PanelTopTabReceipts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelTopTabReceipts.BorderThickness = 2;
            this.guna2PanelTopTabReceipts.Controls.Add(this.guna2PictureBoxRefresh);
            this.guna2PanelTopTabReceipts.Controls.Add(this.guna2ButtonDeleteReceipts);
            this.guna2PanelTopTabReceipts.Controls.Add(this.guna2ButtonAddReceipts);
            this.guna2PanelTopTabReceipts.Controls.Add(this.guna2TextBoxSearchReceipts);
            this.guna2PanelTopTabReceipts.Location = new System.Drawing.Point(-1, -1);
            this.guna2PanelTopTabReceipts.Name = "guna2PanelTopTabReceipts";
            this.guna2PanelTopTabReceipts.Size = new System.Drawing.Size(787, 45);
            this.guna2PanelTopTabReceipts.TabIndex = 0;
            // 
            // guna2ButtonDeleteReceipts
            // 
            this.guna2ButtonDeleteReceipts.AutoRoundedCorners = true;
            this.guna2ButtonDeleteReceipts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonDeleteReceipts.BorderRadius = 17;
            this.guna2ButtonDeleteReceipts.BorderThickness = 2;
            this.guna2ButtonDeleteReceipts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteReceipts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteReceipts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDeleteReceipts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDeleteReceipts.FillColor = System.Drawing.Color.Red;
            this.guna2ButtonDeleteReceipts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDeleteReceipts.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDeleteReceipts.Location = new System.Drawing.Point(614, 4);
            this.guna2ButtonDeleteReceipts.Name = "guna2ButtonDeleteReceipts";
            this.guna2ButtonDeleteReceipts.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonDeleteReceipts.TabIndex = 2;
            this.guna2ButtonDeleteReceipts.Text = "Delete";
            // 
            // guna2ButtonAddReceipts
            // 
            this.guna2ButtonAddReceipts.AutoRoundedCorners = true;
            this.guna2ButtonAddReceipts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonAddReceipts.BorderRadius = 17;
            this.guna2ButtonAddReceipts.BorderThickness = 2;
            this.guna2ButtonAddReceipts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddReceipts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddReceipts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAddReceipts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAddReceipts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonAddReceipts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonAddReceipts.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAddReceipts.Location = new System.Drawing.Point(487, 4);
            this.guna2ButtonAddReceipts.Name = "guna2ButtonAddReceipts";
            this.guna2ButtonAddReceipts.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonAddReceipts.TabIndex = 1;
            this.guna2ButtonAddReceipts.Text = "Add";
            // 
            // guna2TabControlAdmin
            // 
            this.guna2TabControlAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControlAdmin.Controls.Add(this.Receipts);
            this.guna2TabControlAdmin.Controls.Add(this.Accounts);
            this.guna2TabControlAdmin.Controls.Add(this.Categories);
            this.guna2TabControlAdmin.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControlAdmin.Location = new System.Drawing.Point(-2, 1);
            this.guna2TabControlAdmin.Name = "guna2TabControlAdmin";
            this.guna2TabControlAdmin.SelectedIndex = 0;
            this.guna2TabControlAdmin.Size = new System.Drawing.Size(975, 701);
            this.guna2TabControlAdmin.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControlAdmin.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControlAdmin.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.guna2TabControlAdmin.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControlAdmin.TabButtonHoverState.InnerColor = System.Drawing.Color.Red;
            this.guna2TabControlAdmin.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControlAdmin.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2TabControlAdmin.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.guna2TabControlAdmin.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2TabControlAdmin.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2TabControlAdmin.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2TabControlAdmin.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2TabControlAdmin.TabButtonSelectedState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TabControlAdmin.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControlAdmin.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControlAdmin.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControlAdmin.TabIndex = 0;
            this.guna2TabControlAdmin.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            // 
            // guna2PictureBoxRefresh
            // 
            this.guna2PictureBoxRefresh.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBoxRefresh.Image")));
            this.guna2PictureBoxRefresh.ImageRotate = 0F;
            this.guna2PictureBoxRefresh.Location = new System.Drawing.Point(738, 5);
            this.guna2PictureBoxRefresh.Name = "guna2PictureBoxRefresh";
            this.guna2PictureBoxRefresh.Size = new System.Drawing.Size(35, 34);
            this.guna2PictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxRefresh.TabIndex = 3;
            this.guna2PictureBoxRefresh.TabStop = false;
            this.guna2PictureBoxRefresh.UseTransparentBackground = true;
            // 
            // guna2TextBoxSearchReceipts
            // 
            this.guna2TextBoxSearchReceipts.AutoRoundedCorners = true;
            this.guna2TextBoxSearchReceipts.BorderRadius = 15;
            this.guna2TextBoxSearchReceipts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxSearchReceipts.DefaultText = "";
            this.guna2TextBoxSearchReceipts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxSearchReceipts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxSearchReceipts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchReceipts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchReceipts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchReceipts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxSearchReceipts.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchReceipts.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxSearchReceipts.IconLeft")));
            this.guna2TextBoxSearchReceipts.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBoxSearchReceipts.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBoxSearchReceipts.Location = new System.Drawing.Point(8, 6);
            this.guna2TextBoxSearchReceipts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxSearchReceipts.Name = "guna2TextBoxSearchReceipts";
            this.guna2TextBoxSearchReceipts.PasswordChar = '\0';
            this.guna2TextBoxSearchReceipts.PlaceholderText = "Searching";
            this.guna2TextBoxSearchReceipts.SelectedText = "";
            this.guna2TextBoxSearchReceipts.Size = new System.Drawing.Size(229, 33);
            this.guna2TextBoxSearchReceipts.TabIndex = 0;
            // 
            // guna2PictureBoxUserProfile
            // 
            this.guna2PictureBoxUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBoxUserProfile.Image")));
            this.guna2PictureBoxUserProfile.ImageRotate = 0F;
            this.guna2PictureBoxUserProfile.Location = new System.Drawing.Point(738, 5);
            this.guna2PictureBoxUserProfile.Name = "guna2PictureBoxUserProfile";
            this.guna2PictureBoxUserProfile.Size = new System.Drawing.Size(35, 34);
            this.guna2PictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxUserProfile.TabIndex = 3;
            this.guna2PictureBoxUserProfile.TabStop = false;
            this.guna2PictureBoxUserProfile.UseTransparentBackground = true;
            // 
            // guna2TextBoxUserProfile
            // 
            this.guna2TextBoxUserProfile.AutoRoundedCorners = true;
            this.guna2TextBoxUserProfile.BorderRadius = 15;
            this.guna2TextBoxUserProfile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxUserProfile.DefaultText = "";
            this.guna2TextBoxUserProfile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxUserProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxUserProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUserProfile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUserProfile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUserProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxUserProfile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUserProfile.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxUserProfile.IconLeft")));
            this.guna2TextBoxUserProfile.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBoxUserProfile.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBoxUserProfile.Location = new System.Drawing.Point(8, 6);
            this.guna2TextBoxUserProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxUserProfile.Name = "guna2TextBoxUserProfile";
            this.guna2TextBoxUserProfile.PasswordChar = '\0';
            this.guna2TextBoxUserProfile.PlaceholderText = "Searching";
            this.guna2TextBoxUserProfile.SelectedText = "";
            this.guna2TextBoxUserProfile.Size = new System.Drawing.Size(229, 33);
            this.guna2TextBoxUserProfile.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 41);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(787, 652);
            this.guna2Panel2.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Controls.Add(this.guna2Button2);
            this.guna2Panel3.Controls.Add(this.guna2TextBox1);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(787, 43);
            this.guna2Panel3.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(738, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(35, 34);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(614, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(106, 37);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Delete";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2Button2.BorderRadius = 17;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(487, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(106, 37);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Add";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBox1.Location = new System.Drawing.Point(8, 6);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Searching";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(229, 33);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(975, 701);
            this.Controls.Add(this.guna2TabControlAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdmin";
            this.Text = "Form2";
            this.Accounts.ResumeLayout(false);
            this.guna2PanelUserProfile.ResumeLayout(false);
            this.Categories.ResumeLayout(false);
            this.Receipts.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2PanelTopTabReceipts.ResumeLayout(false);
            this.guna2TabControlAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxUserProfile)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Accounts;
        private System.Windows.Forms.TabPage Categories;
        private System.Windows.Forms.TabPage Receipts;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControlAdmin;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTopTabReceipts;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAddReceipts;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearchReceipts;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxRefresh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePickerFrom;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeleteReceipts;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePickeTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label From;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCheckBill;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSmallAccounts;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelUserProfile;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxUserProfile;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeleteUser;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAddUser;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUserProfile;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}