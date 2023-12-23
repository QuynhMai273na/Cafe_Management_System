
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
            this.guna2PictureBoxUserProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ButtonDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBoxUserProfile = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserProfile = new System.Windows.Forms.TabPage();
            this.Receipts = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonCheckBill = new Guna.UI2.WinForms.Guna2Button();
            this.labelTo = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.guna2DateTimePickeTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2PanelTopTabReceipts = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBoxRefresh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ButtonDeleteReceipts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAddReceipts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBoxSearchReceipts = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TabControlAdmin = new Guna.UI2.WinForms.Guna2TabControl();
            this.guna2PanelTopUser = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBoxAccountLevel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxDOB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelusernameprofile = new System.Windows.Forms.Label();
            this.guna2TextBoxUserNameProfile = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Accounts.SuspendLayout();
            this.guna2PanelUserProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxUserProfile)).BeginInit();
            this.UserProfile.SuspendLayout();
            this.Receipts.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2PanelTopTabReceipts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefresh)).BeginInit();
            this.guna2TabControlAdmin.SuspendLayout();
            this.guna2PanelTopUser.SuspendLayout();
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
            // UserProfile
            // 
            this.UserProfile.Controls.Add(this.guna2Panel2);
            this.UserProfile.Controls.Add(this.guna2PanelTopUser);
            this.UserProfile.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfile.Location = new System.Drawing.Point(184, 4);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Padding = new System.Windows.Forms.Padding(3);
            this.UserProfile.Size = new System.Drawing.Size(787, 693);
            this.UserProfile.TabIndex = 1;
            this.UserProfile.Text = "User\'s Profile";
            this.UserProfile.UseVisualStyleBackColor = true;
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
            // guna2TabControlAdmin
            // 
            this.guna2TabControlAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControlAdmin.Controls.Add(this.Receipts);
            this.guna2TabControlAdmin.Controls.Add(this.Accounts);
            this.guna2TabControlAdmin.Controls.Add(this.UserProfile);
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
            this.guna2TabControlAdmin.TabButtonSelectedState.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControlAdmin.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControlAdmin.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControlAdmin.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControlAdmin.TabIndex = 0;
            this.guna2TabControlAdmin.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            // 
            // guna2PanelTopUser
            // 
            this.guna2PanelTopUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelTopUser.BorderThickness = 2;
            this.guna2PanelTopUser.Controls.Add(this.guna2TextBoxAccountLevel);
            this.guna2PanelTopUser.Controls.Add(this.label2);
            this.guna2PanelTopUser.Controls.Add(this.guna2TextBoxPhone);
            this.guna2PanelTopUser.Controls.Add(this.guna2TextBoxDOB);
            this.guna2PanelTopUser.Controls.Add(this.label1);
            this.guna2PanelTopUser.Controls.Add(this.labelBirthDay);
            this.guna2PanelTopUser.Controls.Add(this.labelusernameprofile);
            this.guna2PanelTopUser.Controls.Add(this.guna2TextBoxUserNameProfile);
            this.guna2PanelTopUser.Controls.Add(this.guna2PictureBox1);
            this.guna2PanelTopUser.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTopUser.Name = "guna2PanelTopUser";
            this.guna2PanelTopUser.Size = new System.Drawing.Size(787, 148);
            this.guna2PanelTopUser.TabIndex = 3;
            // 
            // guna2TextBoxAccountLevel
            // 
            this.guna2TextBoxAccountLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAccountLevel.DefaultText = "";
            this.guna2TextBoxAccountLevel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAccountLevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAccountLevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAccountLevel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAccountLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAccountLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxAccountLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAccountLevel.Location = new System.Drawing.Point(544, 108);
            this.guna2TextBoxAccountLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxAccountLevel.Name = "guna2TextBoxAccountLevel";
            this.guna2TextBoxAccountLevel.PasswordChar = '\0';
            this.guna2TextBoxAccountLevel.PlaceholderText = "";
            this.guna2TextBoxAccountLevel.SelectedText = "";
            this.guna2TextBoxAccountLevel.Size = new System.Drawing.Size(229, 31);
            this.guna2TextBoxAccountLevel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(407, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Level:";
            // 
            // guna2TextBoxPhone
            // 
            this.guna2TextBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPhone.DefaultText = "";
            this.guna2TextBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPhone.Location = new System.Drawing.Point(544, 63);
            this.guna2TextBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxPhone.Name = "guna2TextBoxPhone";
            this.guna2TextBoxPhone.PasswordChar = '\0';
            this.guna2TextBoxPhone.PlaceholderText = "";
            this.guna2TextBoxPhone.SelectedText = "";
            this.guna2TextBoxPhone.Size = new System.Drawing.Size(229, 31);
            this.guna2TextBoxPhone.TabIndex = 6;
            // 
            // guna2TextBoxDOB
            // 
            this.guna2TextBoxDOB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxDOB.DefaultText = "";
            this.guna2TextBoxDOB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxDOB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxDOB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDOB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDOB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxDOB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDOB.Location = new System.Drawing.Point(544, 15);
            this.guna2TextBoxDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxDOB.Name = "guna2TextBoxDOB";
            this.guna2TextBoxDOB.PasswordChar = '\0';
            this.guna2TextBoxDOB.PlaceholderText = "";
            this.guna2TextBoxDOB.SelectedText = "";
            this.guna2TextBoxDOB.Size = new System.Drawing.Size(229, 31);
            this.guna2TextBoxDOB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(407, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone Number:";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelBirthDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.labelBirthDay.Location = new System.Drawing.Point(407, 22);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(102, 18);
            this.labelBirthDay.TabIndex = 3;
            this.labelBirthDay.Text = "Day Of Birth: ";
            // 
            // labelusernameprofile
            // 
            this.labelusernameprofile.AutoSize = true;
            this.labelusernameprofile.Location = new System.Drawing.Point(113, 70);
            this.labelusernameprofile.Name = "labelusernameprofile";
            this.labelusernameprofile.Size = new System.Drawing.Size(89, 16);
            this.labelusernameprofile.TabIndex = 2;
            this.labelusernameprofile.Text = "@peterpaker";
            // 
            // guna2TextBoxUserNameProfile
            // 
            this.guna2TextBoxUserNameProfile.AutoRoundedCorners = true;
            this.guna2TextBoxUserNameProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2TextBoxUserNameProfile.BorderRadius = 23;
            this.guna2TextBoxUserNameProfile.BorderThickness = 2;
            this.guna2TextBoxUserNameProfile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxUserNameProfile.DefaultText = "Mr. Peter Paker";
            this.guna2TextBoxUserNameProfile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxUserNameProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxUserNameProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUserNameProfile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUserNameProfile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUserNameProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxUserNameProfile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUserNameProfile.Location = new System.Drawing.Point(103, 15);
            this.guna2TextBoxUserNameProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxUserNameProfile.Name = "guna2TextBoxUserNameProfile";
            this.guna2TextBoxUserNameProfile.PasswordChar = '\0';
            this.guna2TextBoxUserNameProfile.PlaceholderText = "";
            this.guna2TextBoxUserNameProfile.SelectedText = "";
            this.guna2TextBoxUserNameProfile.Size = new System.Drawing.Size(262, 48);
            this.guna2TextBoxUserNameProfile.TabIndex = 1;
            this.guna2TextBoxUserNameProfile.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 146);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(787, 547);
            this.guna2Panel2.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxUserProfile)).EndInit();
            this.UserProfile.ResumeLayout(false);
            this.Receipts.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2PanelTopTabReceipts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefresh)).EndInit();
            this.guna2TabControlAdmin.ResumeLayout(false);
            this.guna2PanelTopUser.ResumeLayout(false);
            this.guna2PanelTopUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Accounts;
        private System.Windows.Forms.TabPage UserProfile;
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
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTopUser;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAccountLevel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPhone;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelusernameprofile;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUserNameProfile;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}