using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace CafeManagementSystem
{
    partial class fExportBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fExportBill));
            this.guna2PictureBoxlogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelInvoiceNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxDatePayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.guna2TextBoxIdBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelAmountDue = new System.Windows.Forms.Label();
            this.guna2TextBoxTotalMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxFinalmoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.dataGridViewExport = new System.Windows.Forms.DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBoxlogo
            // 
            this.guna2PictureBoxlogo.Image = global::CafeManagementSystem.Properties.Resources.logo;
            this.guna2PictureBoxlogo.ImageRotate = 0F;
            this.guna2PictureBoxlogo.Location = new System.Drawing.Point(173, -1);
            this.guna2PictureBoxlogo.Name = "guna2PictureBoxlogo";
            this.guna2PictureBoxlogo.Size = new System.Drawing.Size(136, 89);
            this.guna2PictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBoxlogo.TabIndex = 0;
            this.guna2PictureBoxlogo.TabStop = false;
            // 
            // labelInvoiceNo
            // 
            this.labelInvoiceNo.AutoSize = true;
            this.labelInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceNo.ForeColor = System.Drawing.Color.Peru;
            this.labelInvoiceNo.Location = new System.Drawing.Point(361, 92);
            this.labelInvoiceNo.Name = "labelInvoiceNo";
            this.labelInvoiceNo.Size = new System.Drawing.Size(104, 18);
            this.labelInvoiceNo.TabIndex = 1;
            this.labelInvoiceNo.Text = "INVOICE NO";
            this.labelInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 1);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "STAY IN TOUCH WITH US!\r\nContact: +84 6666 8888\r\nSaigoneseCoffee.com";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(9, 522);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(232, 83);
            this.guna2TextBox1.TabIndex = 3;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBoxDatePayment
            // 
            this.guna2TextBoxDatePayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxDatePayment.DefaultText = "";
            this.guna2TextBoxDatePayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxDatePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxDatePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDatePayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDatePayment.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxDatePayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDatePayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxDatePayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDatePayment.Location = new System.Drawing.Point(311, 140);
            this.guna2TextBoxDatePayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxDatePayment.Name = "guna2TextBoxDatePayment";
            this.guna2TextBoxDatePayment.PasswordChar = '\0';
            this.guna2TextBoxDatePayment.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxDatePayment.PlaceholderText = "";
            this.guna2TextBoxDatePayment.SelectedText = "";
            this.guna2TextBoxDatePayment.Size = new System.Drawing.Size(155, 28);
            this.guna2TextBoxDatePayment.TabIndex = 5;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.Color.Peru;
            this.labelCustomer.Location = new System.Drawing.Point(12, 94);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(103, 18);
            this.labelCustomer.TabIndex = 6;
            this.labelCustomer.Text = "CUSTOMER";
            this.labelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2TextBoxIdBill
            // 
            this.guna2TextBoxIdBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxIdBill.DefaultText = "";
            this.guna2TextBoxIdBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxIdBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxIdBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxIdBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxIdBill.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxIdBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxIdBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxIdBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxIdBill.Location = new System.Drawing.Point(311, 114);
            this.guna2TextBoxIdBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxIdBill.Name = "guna2TextBoxIdBill";
            this.guna2TextBoxIdBill.PasswordChar = '\0';
            this.guna2TextBoxIdBill.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxIdBill.PlaceholderText = "";
            this.guna2TextBoxIdBill.SelectedText = "";
            this.guna2TextBoxIdBill.Size = new System.Drawing.Size(155, 28);
            this.guna2TextBoxIdBill.TabIndex = 7;
            // 
            // guna2TextBoxCusName
            // 
            this.guna2TextBoxCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxCusName.DefaultText = "";
            this.guna2TextBoxCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCusName.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCusName.Location = new System.Drawing.Point(12, 114);
            this.guna2TextBoxCusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxCusName.Name = "guna2TextBoxCusName";
            this.guna2TextBoxCusName.PasswordChar = '\0';
            this.guna2TextBoxCusName.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxCusName.PlaceholderText = "";
            this.guna2TextBoxCusName.SelectedText = "";
            this.guna2TextBoxCusName.Size = new System.Drawing.Size(155, 28);
            this.guna2TextBoxCusName.TabIndex = 8;
            // 
            // guna2TextBoxPhoneNumber
            // 
            this.guna2TextBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPhoneNumber.DefaultText = "";
            this.guna2TextBoxPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPhoneNumber.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPhoneNumber.Location = new System.Drawing.Point(12, 140);
            this.guna2TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxPhoneNumber.Name = "guna2TextBoxPhoneNumber";
            this.guna2TextBoxPhoneNumber.PasswordChar = '\0';
            this.guna2TextBoxPhoneNumber.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxPhoneNumber.PlaceholderText = "";
            this.guna2TextBoxPhoneNumber.SelectedText = "";
            this.guna2TextBoxPhoneNumber.Size = new System.Drawing.Size(155, 28);
            this.guna2TextBoxPhoneNumber.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(10, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 1);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(10, 433);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(455, 1);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox6.BorderThickness = 0;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "Thank you !";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(428, 699);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(214, 99);
            this.guna2TextBox6.TabIndex = 12;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(10, 401);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(455, 1);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.BorderColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox7.BorderThickness = 0;
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox7.DefaultText = "Thank you !";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2TextBox7.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Location = new System.Drawing.Point(255, 545);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox7.Multiline = true;
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBox7.PlaceholderText = "";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(212, 47);
            this.guna2TextBox7.TabIndex = 14;
            this.guna2TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(18, 409);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 18);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.Color.Black;
            this.labelDiscount.Location = new System.Drawing.Point(286, 443);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(67, 18);
            this.labelDiscount.TabIndex = 16;
            this.labelDiscount.Text = "Discount";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAmountDue
            // 
            this.labelAmountDue.AutoSize = true;
            this.labelAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountDue.ForeColor = System.Drawing.Color.Black;
            this.labelAmountDue.Location = new System.Drawing.Point(266, 472);
            this.labelAmountDue.Name = "labelAmountDue";
            this.labelAmountDue.Size = new System.Drawing.Size(87, 18);
            this.labelAmountDue.TabIndex = 17;
            this.labelAmountDue.Text = "Amount due";
            this.labelAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2TextBoxTotalMoney
            // 
            this.guna2TextBoxTotalMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxTotalMoney.DefaultText = "";
            this.guna2TextBoxTotalMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxTotalMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxTotalMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTotalMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTotalMoney.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxTotalMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTotalMoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxTotalMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTotalMoney.Location = new System.Drawing.Point(364, 403);
            this.guna2TextBoxTotalMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxTotalMoney.Name = "guna2TextBoxTotalMoney";
            this.guna2TextBoxTotalMoney.PasswordChar = '\0';
            this.guna2TextBoxTotalMoney.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxTotalMoney.PlaceholderText = "";
            this.guna2TextBoxTotalMoney.SelectedText = "";
            this.guna2TextBoxTotalMoney.Size = new System.Drawing.Size(100, 28);
            this.guna2TextBoxTotalMoney.TabIndex = 18;
            // 
            // guna2TextBoxFinalmoney
            // 
            this.guna2TextBoxFinalmoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxFinalmoney.DefaultText = "";
            this.guna2TextBoxFinalmoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxFinalmoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxFinalmoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFinalmoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxFinalmoney.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxFinalmoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxFinalmoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxFinalmoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxFinalmoney.Location = new System.Drawing.Point(365, 469);
            this.guna2TextBoxFinalmoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxFinalmoney.Name = "guna2TextBoxFinalmoney";
            this.guna2TextBoxFinalmoney.PasswordChar = '\0';
            this.guna2TextBoxFinalmoney.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxFinalmoney.PlaceholderText = "";
            this.guna2TextBoxFinalmoney.SelectedText = "";
            this.guna2TextBoxFinalmoney.Size = new System.Drawing.Size(100, 28);
            this.guna2TextBoxFinalmoney.TabIndex = 19;
            // 
            // guna2TextBoxDiscount
            // 
            this.guna2TextBoxDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxDiscount.DefaultText = "";
            this.guna2TextBoxDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDiscount.FillColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDiscount.Location = new System.Drawing.Point(364, 439);
            this.guna2TextBoxDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBoxDiscount.Name = "guna2TextBoxDiscount";
            this.guna2TextBoxDiscount.PasswordChar = '\0';
            this.guna2TextBoxDiscount.PlaceholderForeColor = System.Drawing.Color.SeaShell;
            this.guna2TextBoxDiscount.PlaceholderText = "";
            this.guna2TextBoxDiscount.SelectedText = "";
            this.guna2TextBoxDiscount.Size = new System.Drawing.Size(100, 28);
            this.guna2TextBoxDiscount.TabIndex = 20;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrint.BackgroundImage")));
            this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.Location = new System.Drawing.Point(15, 19);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(31, 29);
            this.buttonPrint.TabIndex = 21;
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dataGridViewExport
            // 
            this.dataGridViewExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExport.Location = new System.Drawing.Point(10, 175);
            this.dataGridViewExport.Name = "dataGridViewExport";
            this.dataGridViewExport.RowHeadersWidth = 5;
            this.dataGridViewExport.RowTemplate.Height = 24;
            this.dataGridViewExport.Size = new System.Drawing.Size(457, 231);
            this.dataGridViewExport.TabIndex = 18;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CafeManagementSystem.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(436, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 23;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fExportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(478, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewExport);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.guna2TextBoxDiscount);
            this.Controls.Add(this.guna2TextBoxFinalmoney);
            this.Controls.Add(this.guna2TextBoxTotalMoney);
            this.Controls.Add(this.labelAmountDue);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.guna2TextBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2TextBoxPhoneNumber);
            this.Controls.Add(this.guna2TextBoxCusName);
            this.Controls.Add(this.guna2TextBoxIdBill);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.guna2TextBoxDatePayment);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInvoiceNo);
            this.Controls.Add(this.guna2PictureBoxlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fExportBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print invoice";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBoxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //GeneratePDF(sender, e);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxlogo;
        private Label labelInvoiceNo;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxDatePayment;
        private Label labelCustomer;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxIdBill;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCusName;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPhoneNumber;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private Label labelTotal;
        private Label labelDiscount;
        private Label labelAmountDue;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxTotalMoney;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxFinalmoney;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxDiscount;
        private Button buttonPrint;
        private PrintDialog printDialog1;
        private DataGridView dataGridViewExport;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Button button1;
    }
}