
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
            this.Categories = new System.Windows.Forms.TabPage();
            this.guna2TabControlAdmin = new Guna.UI2.WinForms.Guna2TabControl();
            this.guna2PanelCategoriesEdit = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelCategories = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBoxRefreshCategories = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ButtonDeleteCategories = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAddCategories = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBoxSearchCategories = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelAccounts = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBoxRefreshAccounts = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ButtonDeleteAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAddAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBoxSearchAccounts = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelDateFromTo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DateTimePickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePickeTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.From = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.guna2ButtonCheckBill = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelReceipts = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBoxSearchReceipts = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonAddReceipts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDeleteReceipts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBoxRefreshReceipts = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Receipts = new System.Windows.Forms.TabPage();
            this.guna2PanelReceiptsEdit = new Guna.UI2.WinForms.Guna2Panel();
            this.Accounts.SuspendLayout();
            this.Categories.SuspendLayout();
            this.guna2TabControlAdmin.SuspendLayout();
            this.guna2PanelCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefreshCategories)).BeginInit();
            this.guna2PanelAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefreshAccounts)).BeginInit();
            this.guna2PanelDateFromTo.SuspendLayout();
            this.guna2PanelReceipts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefreshReceipts)).BeginInit();
            this.Receipts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Accounts
            // 
            this.Accounts.Controls.Add(this.guna2PanelAccounts);
            this.Accounts.Controls.Add(this.guna2PanelSmallAccounts);
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
            this.guna2PanelSmallAccounts.Size = new System.Drawing.Size(725, 652);
            this.guna2PanelSmallAccounts.TabIndex = 3;
            // 
            // Categories
            // 
            this.Categories.Controls.Add(this.guna2PanelCategoriesEdit);
            this.Categories.Controls.Add(this.guna2PanelCategories);
            this.Categories.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(184, 4);
            this.Categories.Name = "Categories";
            this.Categories.Padding = new System.Windows.Forms.Padding(3);
            this.Categories.Size = new System.Drawing.Size(787, 693);
            this.Categories.TabIndex = 1;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = true;
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
            // guna2PanelCategoriesEdit
            // 
            this.guna2PanelCategoriesEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelCategoriesEdit.BorderThickness = 2;
            this.guna2PanelCategoriesEdit.Location = new System.Drawing.Point(0, 41);
            this.guna2PanelCategoriesEdit.Name = "guna2PanelCategoriesEdit";
            this.guna2PanelCategoriesEdit.Size = new System.Drawing.Size(725, 652);
            this.guna2PanelCategoriesEdit.TabIndex = 5;
            // 
            // guna2PanelCategories
            // 
            this.guna2PanelCategories.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelCategories.BorderThickness = 2;
            this.guna2PanelCategories.Controls.Add(this.guna2PictureBoxRefreshCategories);
            this.guna2PanelCategories.Controls.Add(this.guna2ButtonDeleteCategories);
            this.guna2PanelCategories.Controls.Add(this.guna2ButtonAddCategories);
            this.guna2PanelCategories.Controls.Add(this.guna2TextBoxSearchCategories);
            this.guna2PanelCategories.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelCategories.Name = "guna2PanelCategories";
            this.guna2PanelCategories.Size = new System.Drawing.Size(725, 43);
            this.guna2PanelCategories.TabIndex = 4;
            // 
            // guna2PictureBoxRefreshCategories
            // 
            this.guna2PictureBoxRefreshCategories.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBoxRefreshCategories.Image")));
            this.guna2PictureBoxRefreshCategories.ImageRotate = 0F;
            this.guna2PictureBoxRefreshCategories.Location = new System.Drawing.Point(681, 4);
            this.guna2PictureBoxRefreshCategories.Name = "guna2PictureBoxRefreshCategories";
            this.guna2PictureBoxRefreshCategories.Size = new System.Drawing.Size(35, 34);
            this.guna2PictureBoxRefreshCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxRefreshCategories.TabIndex = 3;
            this.guna2PictureBoxRefreshCategories.TabStop = false;
            this.guna2PictureBoxRefreshCategories.UseTransparentBackground = true;
            // 
            // guna2ButtonDeleteCategories
            // 
            this.guna2ButtonDeleteCategories.AutoRoundedCorners = true;
            this.guna2ButtonDeleteCategories.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonDeleteCategories.BorderRadius = 17;
            this.guna2ButtonDeleteCategories.BorderThickness = 2;
            this.guna2ButtonDeleteCategories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteCategories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDeleteCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDeleteCategories.FillColor = System.Drawing.Color.Red;
            this.guna2ButtonDeleteCategories.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDeleteCategories.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDeleteCategories.Location = new System.Drawing.Point(565, 3);
            this.guna2ButtonDeleteCategories.Name = "guna2ButtonDeleteCategories";
            this.guna2ButtonDeleteCategories.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonDeleteCategories.TabIndex = 2;
            this.guna2ButtonDeleteCategories.Text = "Delete";
            // 
            // guna2ButtonAddCategories
            // 
            this.guna2ButtonAddCategories.AutoRoundedCorners = true;
            this.guna2ButtonAddCategories.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonAddCategories.BorderRadius = 17;
            this.guna2ButtonAddCategories.BorderThickness = 2;
            this.guna2ButtonAddCategories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddCategories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAddCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAddCategories.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonAddCategories.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonAddCategories.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAddCategories.Location = new System.Drawing.Point(451, 3);
            this.guna2ButtonAddCategories.Name = "guna2ButtonAddCategories";
            this.guna2ButtonAddCategories.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonAddCategories.TabIndex = 1;
            this.guna2ButtonAddCategories.Text = "Add";
            // 
            // guna2TextBoxSearchCategories
            // 
            this.guna2TextBoxSearchCategories.AutoRoundedCorners = true;
            this.guna2TextBoxSearchCategories.BorderRadius = 15;
            this.guna2TextBoxSearchCategories.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxSearchCategories.DefaultText = "";
            this.guna2TextBoxSearchCategories.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxSearchCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxSearchCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchCategories.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxSearchCategories.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchCategories.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxSearchCategories.IconLeft")));
            this.guna2TextBoxSearchCategories.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBoxSearchCategories.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBoxSearchCategories.Location = new System.Drawing.Point(8, 6);
            this.guna2TextBoxSearchCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxSearchCategories.Name = "guna2TextBoxSearchCategories";
            this.guna2TextBoxSearchCategories.PasswordChar = '\0';
            this.guna2TextBoxSearchCategories.PlaceholderText = "Searching";
            this.guna2TextBoxSearchCategories.SelectedText = "";
            this.guna2TextBoxSearchCategories.Size = new System.Drawing.Size(229, 33);
            this.guna2TextBoxSearchCategories.TabIndex = 0;
            // 
            // guna2PanelAccounts
            // 
            this.guna2PanelAccounts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelAccounts.BorderThickness = 2;
            this.guna2PanelAccounts.Controls.Add(this.guna2PictureBoxRefreshAccounts);
            this.guna2PanelAccounts.Controls.Add(this.guna2ButtonDeleteAccounts);
            this.guna2PanelAccounts.Controls.Add(this.guna2ButtonAddAccounts);
            this.guna2PanelAccounts.Controls.Add(this.guna2TextBoxSearchAccounts);
            this.guna2PanelAccounts.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelAccounts.Name = "guna2PanelAccounts";
            this.guna2PanelAccounts.Size = new System.Drawing.Size(725, 43);
            this.guna2PanelAccounts.TabIndex = 5;
            // 
            // guna2PictureBoxRefreshAccounts
            // 
            this.guna2PictureBoxRefreshAccounts.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBoxRefreshAccounts.Image")));
            this.guna2PictureBoxRefreshAccounts.ImageRotate = 0F;
            this.guna2PictureBoxRefreshAccounts.Location = new System.Drawing.Point(681, 4);
            this.guna2PictureBoxRefreshAccounts.Name = "guna2PictureBoxRefreshAccounts";
            this.guna2PictureBoxRefreshAccounts.Size = new System.Drawing.Size(35, 34);
            this.guna2PictureBoxRefreshAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxRefreshAccounts.TabIndex = 3;
            this.guna2PictureBoxRefreshAccounts.TabStop = false;
            this.guna2PictureBoxRefreshAccounts.UseTransparentBackground = true;
            // 
            // guna2ButtonDeleteAccounts
            // 
            this.guna2ButtonDeleteAccounts.AutoRoundedCorners = true;
            this.guna2ButtonDeleteAccounts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonDeleteAccounts.BorderRadius = 17;
            this.guna2ButtonDeleteAccounts.BorderThickness = 2;
            this.guna2ButtonDeleteAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDeleteAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDeleteAccounts.FillColor = System.Drawing.Color.Red;
            this.guna2ButtonDeleteAccounts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDeleteAccounts.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDeleteAccounts.Location = new System.Drawing.Point(565, 3);
            this.guna2ButtonDeleteAccounts.Name = "guna2ButtonDeleteAccounts";
            this.guna2ButtonDeleteAccounts.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonDeleteAccounts.TabIndex = 2;
            this.guna2ButtonDeleteAccounts.Text = "Delete";
            // 
            // guna2ButtonAddAccounts
            // 
            this.guna2ButtonAddAccounts.AutoRoundedCorners = true;
            this.guna2ButtonAddAccounts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2ButtonAddAccounts.BorderRadius = 17;
            this.guna2ButtonAddAccounts.BorderThickness = 2;
            this.guna2ButtonAddAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAddAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAddAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAddAccounts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonAddAccounts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonAddAccounts.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAddAccounts.Location = new System.Drawing.Point(451, 3);
            this.guna2ButtonAddAccounts.Name = "guna2ButtonAddAccounts";
            this.guna2ButtonAddAccounts.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonAddAccounts.TabIndex = 1;
            this.guna2ButtonAddAccounts.Text = "Add";
            // 
            // guna2TextBoxSearchAccounts
            // 
            this.guna2TextBoxSearchAccounts.AutoRoundedCorners = true;
            this.guna2TextBoxSearchAccounts.BorderRadius = 15;
            this.guna2TextBoxSearchAccounts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxSearchAccounts.DefaultText = "";
            this.guna2TextBoxSearchAccounts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxSearchAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxSearchAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchAccounts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchAccounts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchAccounts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxSearchAccounts.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchAccounts.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxSearchAccounts.IconLeft")));
            this.guna2TextBoxSearchAccounts.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBoxSearchAccounts.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBoxSearchAccounts.Location = new System.Drawing.Point(8, 6);
            this.guna2TextBoxSearchAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxSearchAccounts.Name = "guna2TextBoxSearchAccounts";
            this.guna2TextBoxSearchAccounts.PasswordChar = '\0';
            this.guna2TextBoxSearchAccounts.PlaceholderText = "Searching";
            this.guna2TextBoxSearchAccounts.SelectedText = "";
            this.guna2TextBoxSearchAccounts.Size = new System.Drawing.Size(229, 33);
            this.guna2TextBoxSearchAccounts.TabIndex = 0;
            // 
            // guna2PanelDateFromTo
            // 
            this.guna2PanelDateFromTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelDateFromTo.BorderThickness = 2;
            this.guna2PanelDateFromTo.Controls.Add(this.guna2ButtonCheckBill);
            this.guna2PanelDateFromTo.Controls.Add(this.labelTo);
            this.guna2PanelDateFromTo.Controls.Add(this.From);
            this.guna2PanelDateFromTo.Controls.Add(this.guna2DateTimePickeTo);
            this.guna2PanelDateFromTo.Controls.Add(this.guna2DateTimePickerFrom);
            this.guna2PanelDateFromTo.Location = new System.Drawing.Point(-1, 40);
            this.guna2PanelDateFromTo.Name = "guna2PanelDateFromTo";
            this.guna2PanelDateFromTo.Size = new System.Drawing.Size(726, 45);
            this.guna2PanelDateFromTo.TabIndex = 2;
            // 
            // guna2DateTimePickerFrom
            // 
            this.guna2DateTimePickerFrom.AutoRoundedCorners = true;
            this.guna2DateTimePickerFrom.BorderRadius = 14;
            this.guna2DateTimePickerFrom.Checked = true;
            this.guna2DateTimePickerFrom.FillColor = System.Drawing.Color.Silver;
            this.guna2DateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePickerFrom.Location = new System.Drawing.Point(61, 8);
            this.guna2DateTimePickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePickerFrom.Name = "guna2DateTimePickerFrom";
            this.guna2DateTimePickerFrom.Size = new System.Drawing.Size(250, 30);
            this.guna2DateTimePickerFrom.TabIndex = 1;
            this.guna2DateTimePickerFrom.Value = new System.DateTime(2023, 12, 23, 3, 5, 23, 896);
            // 
            // guna2DateTimePickeTo
            // 
            this.guna2DateTimePickeTo.AutoRoundedCorners = true;
            this.guna2DateTimePickeTo.BorderRadius = 14;
            this.guna2DateTimePickeTo.Checked = true;
            this.guna2DateTimePickeTo.FillColor = System.Drawing.Color.Silver;
            this.guna2DateTimePickeTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePickeTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePickeTo.Location = new System.Drawing.Point(354, 8);
            this.guna2DateTimePickeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePickeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePickeTo.Name = "guna2DateTimePickeTo";
            this.guna2DateTimePickeTo.Size = new System.Drawing.Size(250, 30);
            this.guna2DateTimePickeTo.TabIndex = 2;
            this.guna2DateTimePickeTo.Value = new System.DateTime(2023, 12, 23, 3, 5, 23, 896);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.From.Location = new System.Drawing.Point(7, 13);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(50, 19);
            this.From.TabIndex = 3;
            this.From.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.labelTo.Location = new System.Drawing.Point(317, 13);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(28, 19);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To";
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
            this.guna2ButtonCheckBill.Location = new System.Drawing.Point(620, 5);
            this.guna2ButtonCheckBill.Name = "guna2ButtonCheckBill";
            this.guna2ButtonCheckBill.Size = new System.Drawing.Size(96, 35);
            this.guna2ButtonCheckBill.TabIndex = 3;
            this.guna2ButtonCheckBill.Text = "Check";
            // 
            // guna2PanelReceipts
            // 
            this.guna2PanelReceipts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelReceipts.BorderThickness = 2;
            this.guna2PanelReceipts.Controls.Add(this.guna2PictureBoxRefreshReceipts);
            this.guna2PanelReceipts.Controls.Add(this.guna2ButtonDeleteReceipts);
            this.guna2PanelReceipts.Controls.Add(this.guna2ButtonAddReceipts);
            this.guna2PanelReceipts.Controls.Add(this.guna2TextBoxSearchReceipts);
            this.guna2PanelReceipts.Location = new System.Drawing.Point(-1, -1);
            this.guna2PanelReceipts.Name = "guna2PanelReceipts";
            this.guna2PanelReceipts.Size = new System.Drawing.Size(726, 43);
            this.guna2PanelReceipts.TabIndex = 5;
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
            this.guna2ButtonAddReceipts.Location = new System.Drawing.Point(451, 3);
            this.guna2ButtonAddReceipts.Name = "guna2ButtonAddReceipts";
            this.guna2ButtonAddReceipts.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonAddReceipts.TabIndex = 1;
            this.guna2ButtonAddReceipts.Text = "Add";
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
            this.guna2ButtonDeleteReceipts.Location = new System.Drawing.Point(565, 3);
            this.guna2ButtonDeleteReceipts.Name = "guna2ButtonDeleteReceipts";
            this.guna2ButtonDeleteReceipts.Size = new System.Drawing.Size(106, 37);
            this.guna2ButtonDeleteReceipts.TabIndex = 2;
            this.guna2ButtonDeleteReceipts.Text = "Delete";
            // 
            // guna2PictureBoxRefreshReceipts
            // 
            this.guna2PictureBoxRefreshReceipts.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBoxRefreshReceipts.Image")));
            this.guna2PictureBoxRefreshReceipts.ImageRotate = 0F;
            this.guna2PictureBoxRefreshReceipts.Location = new System.Drawing.Point(681, 4);
            this.guna2PictureBoxRefreshReceipts.Name = "guna2PictureBoxRefreshReceipts";
            this.guna2PictureBoxRefreshReceipts.Size = new System.Drawing.Size(35, 34);
            this.guna2PictureBoxRefreshReceipts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBoxRefreshReceipts.TabIndex = 3;
            this.guna2PictureBoxRefreshReceipts.TabStop = false;
            this.guna2PictureBoxRefreshReceipts.UseTransparentBackground = true;
            // 
            // Receipts
            // 
            this.Receipts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Receipts.Controls.Add(this.guna2PanelReceiptsEdit);
            this.Receipts.Controls.Add(this.guna2PanelReceipts);
            this.Receipts.Controls.Add(this.guna2PanelDateFromTo);
            this.Receipts.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipts.Location = new System.Drawing.Point(184, 4);
            this.Receipts.Name = "Receipts";
            this.Receipts.Padding = new System.Windows.Forms.Padding(3);
            this.Receipts.Size = new System.Drawing.Size(787, 693);
            this.Receipts.TabIndex = 0;
            this.Receipts.Text = "Receipts";
            this.Receipts.UseVisualStyleBackColor = true;
            // 
            // guna2PanelReceiptsEdit
            // 
            this.guna2PanelReceiptsEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelReceiptsEdit.BorderThickness = 2;
            this.guna2PanelReceiptsEdit.Location = new System.Drawing.Point(-1, 83);
            this.guna2PanelReceiptsEdit.Name = "guna2PanelReceiptsEdit";
            this.guna2PanelReceiptsEdit.Size = new System.Drawing.Size(726, 609);
            this.guna2PanelReceiptsEdit.TabIndex = 6;
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
            this.Categories.ResumeLayout(false);
            this.guna2TabControlAdmin.ResumeLayout(false);
            this.guna2PanelCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefreshCategories)).EndInit();
            this.guna2PanelAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefreshAccounts)).EndInit();
            this.guna2PanelDateFromTo.ResumeLayout(false);
            this.guna2PanelDateFromTo.PerformLayout();
            this.guna2PanelReceipts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxRefreshReceipts)).EndInit();
            this.Receipts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Accounts;
        private System.Windows.Forms.TabPage Categories;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControlAdmin;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSmallAccounts;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelCategoriesEdit;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelCategories;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxRefreshCategories;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeleteCategories;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAddCategories;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearchCategories;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelAccounts;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxRefreshAccounts;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeleteAccounts;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAddAccounts;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearchAccounts;
        private System.Windows.Forms.TabPage Receipts;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelReceiptsEdit;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelReceipts;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxRefreshReceipts;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeleteReceipts;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAddReceipts;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearchReceipts;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelDateFromTo;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCheckBill;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label From;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePickeTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePickerFrom;
    }
}