using CafeManagementSystem.DAO;
using CafeManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class fTableManagement : Form
    {
        public fTableManagement(Account acc)
        {
            InitializeComponent();
            loginAccount = acc;
            changeProfile();
            ChangeAccount(acc.AccountType);
        }

        #region Method 
        private void guna2ButtonDashBoard_Click(object sender, EventArgs e)
        {
            labelTableManage.Text = "Table Manager Overview";
            guna2PictureBoxTableIcon.Image = Properties.Resources._4;
            container(new Dashboard());
        }
        #endregion
        //cm code
        void ChangeAccount(string type)
        {
            if (type == "staff") guna2ButtonAdmin.Enabled = false;
        }
        private void container(object _form)
        {
            if (guna2PanelContainer.Controls.Count > 0) guna2PanelContainer.Controls.Clear();

            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2PanelContainer.Controls.Add(form);
            guna2PanelContainer.Tag = form;
            form.Show();
        }

        private void guna2ButtonAdmin_Click(object sender, EventArgs e)
        {
            labelTableManage.Text = "Admin Management";
            guna2PictureBoxTableIcon.Image = Properties.Resources._5;
            container(new fAdmin());
        }

        public void changeProfile()
        {
            labelAccountName.Text = loginAccount.DisplayName.ToString();
            labelKindAccount.Text=loginAccount.AccountType.ToString();
        }
        private void guna2ButtonUserProfile_Click(object sender, EventArgs e)
        {
            labelTableManage.Text = "User Profile";
            guna2PictureBoxTableIcon.Image = Properties.Resources._6;
            container(new UserProfile());
        }
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
    }
}
