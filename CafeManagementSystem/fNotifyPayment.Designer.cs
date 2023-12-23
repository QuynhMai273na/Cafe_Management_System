namespace CafeManagementSystem
{
    partial class fNotifyPayment
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNote = new System.Windows.Forms.Label();
            this.guna2ButtonExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonOK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Controls.Add(this.labelNote);
            this.guna2Panel1.Controls.Add(this.guna2ButtonExit);
            this.guna2Panel1.Controls.Add(this.guna2ButtonOK);
            this.guna2Panel1.Location = new System.Drawing.Point(1, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(386, 259);
            this.guna2Panel1.TabIndex = 0;
            // 
            // labelNote
            // 
            this.labelNote.BackColor = System.Drawing.Color.Transparent;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.labelNote.Location = new System.Drawing.Point(3, 33);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(383, 175);
            this.labelNote.TabIndex = 8;
            this.labelNote.Text = "TRY AGAIN";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ButtonExit
            // 
            this.guna2ButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonExit.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ButtonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonExit.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ButtonExit.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonExit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonExit.Image = global::CafeManagementSystem.Properties.Resources.exit;
            this.guna2ButtonExit.Location = new System.Drawing.Point(355, 3);
            this.guna2ButtonExit.Name = "guna2ButtonExit";
            this.guna2ButtonExit.Size = new System.Drawing.Size(28, 27);
            this.guna2ButtonExit.TabIndex = 2;
            this.guna2ButtonExit.Click += new System.EventHandler(this.guna2ButtonExit_Click);
            // 
            // guna2ButtonOK
            // 
            this.guna2ButtonOK.AutoRoundedCorners = true;
            this.guna2ButtonOK.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonOK.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ButtonOK.BorderRadius = 17;
            this.guna2ButtonOK.BorderThickness = 2;
            this.guna2ButtonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ButtonOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonOK.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2ButtonOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonOK.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonOK.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonOK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonOK.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2ButtonOK.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(118)))), ((int)(((byte)(84)))));
            this.guna2ButtonOK.Location = new System.Drawing.Point(128, 211);
            this.guna2ButtonOK.Name = "guna2ButtonOK";
            this.guna2ButtonOK.Size = new System.Drawing.Size(125, 37);
            this.guna2ButtonOK.TabIndex = 4;
            this.guna2ButtonOK.Text = "OK";
            this.guna2ButtonOK.Click += new System.EventHandler(this.guna2ButtonOK_Click);
            // 
            // fNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(386, 255);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            this.TopMost = true;
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonOK;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonExit;
        public System.Windows.Forms.Label labelNote;
    }
}