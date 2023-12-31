﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CafeManagementSystem;

namespace CoffeeManagerApplication
{
    public partial class fLogin : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public fLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
            this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
            this.MouseUp += new MouseEventHandler(MainForm_MouseUp);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void guna2ButtonShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool Login(string username, string password)
        {
            return false;
        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = guna2TextBoxUsername.Text;
            string password = guna2TextBoxPassWord.Text;
            if (Login(username, password))
            {

                //fTableManger f = new fTableManger()-- đăng nhập thành công nên mở tap mới
                this.Hide();
                //hiển thị f
                //f.ShowDiaLog();
                //this.Show();
            }
            else MessageBox.Show("Wrong username or password!");
        }
    }

}

