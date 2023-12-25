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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(447, 205);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 26);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create pdf";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(290, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(426, 35);
            this.label.TabIndex = 0;
            this.label.Text = "Click the button to generate pdf file";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fExportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 378);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnCreate);
            this.Name = "fExportBill";
            this.Text = "Create pdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GeneratePDF(sender, e);
        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label;
    }
}