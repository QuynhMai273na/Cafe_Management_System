using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagementSystem.DTO;

namespace CafeManagementSystem
{
    public partial class fCustomerLogin : Form
    {
        public fCustomerLogin(Account acc)
        {
            InitializeComponent();
            
            loginAccount = acc;
            changeProfile();
        }

        private void guna2ButtonDashBoardCustomer_Click(object sender, EventArgs e)
        {
            labelTableManageCustomer.Text = "Overview";
            guna2PictureBoxTableIconCustomer.Image = Properties.Resources._4;
            container(new fCustomerOverview(loginAccount));
        }

        private void container(object _formcustomer)
        {
            if (guna2PanelContainerCustomer.Controls.Count > 0) guna2PanelContainerCustomer.Controls.Clear();

            Form form = _formcustomer as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2PanelContainerCustomer.Controls.Add(form);
            guna2PanelContainerCustomer.Tag = form;
            form.Show();
        }
        public void changeProfile()
        {
            labelAccountNameCustomer.Text = loginAccount.DisplayName.ToString();
            labelKindCustomer.Text = loginAccount.AccountType.ToString();
        }
        private void guna2ButtonCustomerProfile_Click(object sender, EventArgs e)
        {
            labelTableManageCustomer.Text = "User's Profile";
            guna2PictureBoxTableIconCustomer.Image = Properties.Resources._6;
            container(new CustomerProfile());
        }
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
    }
}
