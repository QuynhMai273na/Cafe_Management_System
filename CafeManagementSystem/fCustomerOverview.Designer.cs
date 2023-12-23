namespace CafeManagementSystem
{
    partial class fCustomerOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomerOverview));
            this.flowLayoutPanelTableCustomer = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewBillCustomer = new System.Windows.Forms.ListView();
            this.columnNameFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAddFoodCustomer = new System.Windows.Forms.Panel();
            this.guna2ComboBoxResultSearchCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBoxShowBillCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2NumericUpDownNumberAddCustomer = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2TextBoxSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButtonAddFoodCustomer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2PanelNoteBillCustomer = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxWriteNoteCustomer = new System.Windows.Forms.TextBox();
            this.labelNoteBillCustomer = new System.Windows.Forms.Label();
            this.guna2ButtonOrderCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.labelTotalBillCustomer = new System.Windows.Forms.Label();
            this.guna2DateTimePickerOrderTableCustomer = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelAddFoodCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDownNumberAddCustomer)).BeginInit();
            this.guna2PanelNoteBillCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTableCustomer
            // 
            this.flowLayoutPanelTableCustomer.AutoScroll = true;
            this.flowLayoutPanelTableCustomer.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanelTableCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelTableCustomer.Name = "flowLayoutPanelTableCustomer";
            this.flowLayoutPanelTableCustomer.Size = new System.Drawing.Size(500, 658);
            this.flowLayoutPanelTableCustomer.TabIndex = 34;
            // 
            // listViewBillCustomer
            // 
            this.listViewBillCustomer.BackColor = System.Drawing.Color.PapayaWhip;
            this.listViewBillCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameFood,
            this.columnPrice,
            this.columnCount,
            this.columnTotalPrice});
            this.listViewBillCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBillCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.listViewBillCustomer.GridLines = true;
            this.listViewBillCustomer.HideSelection = false;
            this.listViewBillCustomer.Location = new System.Drawing.Point(505, 128);
            this.listViewBillCustomer.Name = "listViewBillCustomer";
            this.listViewBillCustomer.Size = new System.Drawing.Size(466, 401);
            this.listViewBillCustomer.TabIndex = 36;
            this.listViewBillCustomer.UseCompatibleStateImageBehavior = false;
            this.listViewBillCustomer.View = System.Windows.Forms.View.Details;
            // 
            // columnNameFood
            // 
            this.columnNameFood.Text = "Name";
            this.columnNameFood.Width = 170;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrice.Width = 75;
            // 
            // columnCount
            // 
            this.columnCount.Text = "Count";
            this.columnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnTotalPrice
            // 
            this.columnTotalPrice.Text = "Total Price";
            this.columnTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTotalPrice.Width = 98;
            // 
            // panelAddFoodCustomer
            // 
            this.panelAddFoodCustomer.Controls.Add(this.guna2ComboBoxResultSearchCustomer);
            this.panelAddFoodCustomer.Controls.Add(this.guna2TextBoxShowBillCustomer);
            this.panelAddFoodCustomer.Controls.Add(this.guna2NumericUpDownNumberAddCustomer);
            this.panelAddFoodCustomer.Controls.Add(this.guna2TextBoxSearchCustomer);
            this.panelAddFoodCustomer.Controls.Add(this.guna2CircleButtonAddFoodCustomer);
            this.panelAddFoodCustomer.Location = new System.Drawing.Point(505, 0);
            this.panelAddFoodCustomer.Name = "panelAddFoodCustomer";
            this.panelAddFoodCustomer.Size = new System.Drawing.Size(468, 125);
            this.panelAddFoodCustomer.TabIndex = 37;
            // 
            // guna2ComboBoxResultSearchCustomer
            // 
            this.guna2ComboBoxResultSearchCustomer.AutoRoundedCorners = true;
            this.guna2ComboBoxResultSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxResultSearchCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ComboBoxResultSearchCustomer.BorderRadius = 17;
            this.guna2ComboBoxResultSearchCustomer.BorderThickness = 2;
            this.guna2ComboBoxResultSearchCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxResultSearchCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxResultSearchCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxResultSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxResultSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBoxResultSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ComboBoxResultSearchCustomer.ItemHeight = 30;
            this.guna2ComboBoxResultSearchCustomer.Location = new System.Drawing.Point(0, 46);
            this.guna2ComboBoxResultSearchCustomer.Name = "guna2ComboBoxResultSearchCustomer";
            this.guna2ComboBoxResultSearchCustomer.Size = new System.Drawing.Size(329, 36);
            this.guna2ComboBoxResultSearchCustomer.TabIndex = 27;
            // 
            // guna2TextBoxShowBillCustomer
            // 
            this.guna2TextBoxShowBillCustomer.AutoRoundedCorners = true;
            this.guna2TextBoxShowBillCustomer.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxShowBillCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2TextBoxShowBillCustomer.BorderRadius = 12;
            this.guna2TextBoxShowBillCustomer.BorderThickness = 2;
            this.guna2TextBoxShowBillCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxShowBillCustomer.DefaultText = "Bill";
            this.guna2TextBoxShowBillCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxShowBillCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxShowBillCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxShowBillCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxShowBillCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2TextBoxShowBillCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxShowBillCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TextBoxShowBillCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2TextBoxShowBillCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxShowBillCustomer.Location = new System.Drawing.Point(0, 95);
            this.guna2TextBoxShowBillCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBoxShowBillCustomer.Name = "guna2TextBoxShowBillCustomer";
            this.guna2TextBoxShowBillCustomer.PasswordChar = '\0';
            this.guna2TextBoxShowBillCustomer.PlaceholderText = "";
            this.guna2TextBoxShowBillCustomer.SelectedText = "";
            this.guna2TextBoxShowBillCustomer.Size = new System.Drawing.Size(468, 26);
            this.guna2TextBoxShowBillCustomer.TabIndex = 21;
            this.guna2TextBoxShowBillCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2NumericUpDownNumberAddCustomer
            // 
            this.guna2NumericUpDownNumberAddCustomer.AutoRoundedCorners = true;
            this.guna2NumericUpDownNumberAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDownNumberAddCustomer.BorderRadius = 17;
            this.guna2NumericUpDownNumberAddCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDownNumberAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDownNumberAddCustomer.Location = new System.Drawing.Point(335, 48);
            this.guna2NumericUpDownNumberAddCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2NumericUpDownNumberAddCustomer.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.guna2NumericUpDownNumberAddCustomer.Name = "guna2NumericUpDownNumberAddCustomer";
            this.guna2NumericUpDownNumberAddCustomer.Size = new System.Drawing.Size(90, 36);
            this.guna2NumericUpDownNumberAddCustomer.TabIndex = 26;
            this.guna2NumericUpDownNumberAddCustomer.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            // 
            // guna2TextBoxSearchCustomer
            // 
            this.guna2TextBoxSearchCustomer.AutoRoundedCorners = true;
            this.guna2TextBoxSearchCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2TextBoxSearchCustomer.BorderRadius = 17;
            this.guna2TextBoxSearchCustomer.BorderThickness = 2;
            this.guna2TextBoxSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxSearchCustomer.DefaultText = "";
            this.guna2TextBoxSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearchCustomer.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBoxSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearchCustomer.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBoxSearchCustomer.IconLeft")));
            this.guna2TextBoxSearchCustomer.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBoxSearchCustomer.IconLeftSize = new System.Drawing.Size(18, 18);
            this.guna2TextBoxSearchCustomer.Location = new System.Drawing.Point(0, 3);
            this.guna2TextBoxSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxSearchCustomer.Name = "guna2TextBoxSearchCustomer";
            this.guna2TextBoxSearchCustomer.PasswordChar = '\0';
            this.guna2TextBoxSearchCustomer.PlaceholderText = "Searching ";
            this.guna2TextBoxSearchCustomer.SelectedText = "";
            this.guna2TextBoxSearchCustomer.Size = new System.Drawing.Size(468, 36);
            this.guna2TextBoxSearchCustomer.TabIndex = 23;
            this.guna2TextBoxSearchCustomer.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2CircleButtonAddFoodCustomer
            // 
            this.guna2CircleButtonAddFoodCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButtonAddFoodCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButtonAddFoodCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButtonAddFoodCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButtonAddFoodCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2CircleButtonAddFoodCustomer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2CircleButtonAddFoodCustomer.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButtonAddFoodCustomer.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButtonAddFoodCustomer.Image")));
            this.guna2CircleButtonAddFoodCustomer.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2CircleButtonAddFoodCustomer.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2CircleButtonAddFoodCustomer.Location = new System.Drawing.Point(432, 48);
            this.guna2CircleButtonAddFoodCustomer.Name = "guna2CircleButtonAddFoodCustomer";
            this.guna2CircleButtonAddFoodCustomer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButtonAddFoodCustomer.Size = new System.Drawing.Size(36, 36);
            this.guna2CircleButtonAddFoodCustomer.TabIndex = 22;
            // 
            // guna2PanelNoteBillCustomer
            // 
            this.guna2PanelNoteBillCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2PanelNoteBillCustomer.BorderThickness = 2;
            this.guna2PanelNoteBillCustomer.Controls.Add(this.textBoxWriteNoteCustomer);
            this.guna2PanelNoteBillCustomer.Controls.Add(this.labelNoteBillCustomer);
            this.guna2PanelNoteBillCustomer.Location = new System.Drawing.Point(505, 532);
            this.guna2PanelNoteBillCustomer.Name = "guna2PanelNoteBillCustomer";
            this.guna2PanelNoteBillCustomer.Size = new System.Drawing.Size(468, 99);
            this.guna2PanelNoteBillCustomer.TabIndex = 40;
            // 
            // textBoxWriteNoteCustomer
            // 
            this.textBoxWriteNoteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.textBoxWriteNoteCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWriteNoteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWriteNoteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.textBoxWriteNoteCustomer.Location = new System.Drawing.Point(59, 6);
            this.textBoxWriteNoteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWriteNoteCustomer.Multiline = true;
            this.textBoxWriteNoteCustomer.Name = "textBoxWriteNoteCustomer";
            this.textBoxWriteNoteCustomer.Size = new System.Drawing.Size(402, 79);
            this.textBoxWriteNoteCustomer.TabIndex = 29;
            // 
            // labelNoteBillCustomer
            // 
            this.labelNoteBillCustomer.AutoSize = true;
            this.labelNoteBillCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteBillCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.labelNoteBillCustomer.Location = new System.Drawing.Point(5, 6);
            this.labelNoteBillCustomer.Name = "labelNoteBillCustomer";
            this.labelNoteBillCustomer.Size = new System.Drawing.Size(54, 18);
            this.labelNoteBillCustomer.TabIndex = 28;
            this.labelNoteBillCustomer.Text = "Note: ";
            // 
            // guna2ButtonOrderCustomer
            // 
            this.guna2ButtonOrderCustomer.AutoRoundedCorners = true;
            this.guna2ButtonOrderCustomer.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonOrderCustomer.BorderRadius = 21;
            this.guna2ButtonOrderCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonOrderCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonOrderCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonOrderCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonOrderCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonOrderCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonOrderCustomer.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonOrderCustomer.Location = new System.Drawing.Point(868, 653);
            this.guna2ButtonOrderCustomer.Name = "guna2ButtonOrderCustomer";
            this.guna2ButtonOrderCustomer.Size = new System.Drawing.Size(105, 45);
            this.guna2ButtonOrderCustomer.TabIndex = 39;
            this.guna2ButtonOrderCustomer.Text = "Order";
            // 
            // labelTotalBillCustomer
            // 
            this.labelTotalBillCustomer.AutoSize = true;
            this.labelTotalBillCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBillCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.labelTotalBillCustomer.Location = new System.Drawing.Point(506, 643);
            this.labelTotalBillCustomer.Name = "labelTotalBillCustomer";
            this.labelTotalBillCustomer.Size = new System.Drawing.Size(51, 18);
            this.labelTotalBillCustomer.TabIndex = 38;
            this.labelTotalBillCustomer.Text = "Total:";
            // 
            // guna2DateTimePickerOrderTableCustomer
            // 
            this.guna2DateTimePickerOrderTableCustomer.Checked = true;
            this.guna2DateTimePickerOrderTableCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2DateTimePickerOrderTableCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePickerOrderTableCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.guna2DateTimePickerOrderTableCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePickerOrderTableCustomer.Location = new System.Drawing.Point(0, 0);
            this.guna2DateTimePickerOrderTableCustomer.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePickerOrderTableCustomer.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePickerOrderTableCustomer.Name = "guna2DateTimePickerOrderTableCustomer";
            this.guna2DateTimePickerOrderTableCustomer.Size = new System.Drawing.Size(500, 36);
            this.guna2DateTimePickerOrderTableCustomer.TabIndex = 41;
            this.guna2DateTimePickerOrderTableCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePickerOrderTableCustomer.Value = new System.DateTime(2023, 12, 23, 12, 55, 45, 93);
            // 
            // fCustomerOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(975, 701);
            this.Controls.Add(this.guna2DateTimePickerOrderTableCustomer);
            this.Controls.Add(this.guna2PanelNoteBillCustomer);
            this.Controls.Add(this.guna2ButtonOrderCustomer);
            this.Controls.Add(this.labelTotalBillCustomer);
            this.Controls.Add(this.panelAddFoodCustomer);
            this.Controls.Add(this.listViewBillCustomer);
            this.Controls.Add(this.flowLayoutPanelTableCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCustomerOverview";
            this.Text = "fCustomerOverview";
            this.panelAddFoodCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDownNumberAddCustomer)).EndInit();
            this.guna2PanelNoteBillCustomer.ResumeLayout(false);
            this.guna2PanelNoteBillCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTableCustomer;
        private System.Windows.Forms.ListView listViewBillCustomer;
        private System.Windows.Forms.ColumnHeader columnNameFood;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.ColumnHeader columnTotalPrice;
        private System.Windows.Forms.Panel panelAddFoodCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxResultSearchCustomer;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxShowBillCustomer;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDownNumberAddCustomer;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearchCustomer;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButtonAddFoodCustomer;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelNoteBillCustomer;
        private System.Windows.Forms.TextBox textBoxWriteNoteCustomer;
        private System.Windows.Forms.Label labelNoteBillCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonOrderCustomer;
        private System.Windows.Forms.Label labelTotalBillCustomer;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePickerOrderTableCustomer;
    }
}