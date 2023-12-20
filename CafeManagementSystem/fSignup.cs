using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CafeManagementSystem.DAO;

namespace CafeManagementSystem
{
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
        }
        private void fSignup_Load(object sender, EventArgs e)
        {
            guna2ShadowForm2.SetShadowForm(this);
        }

        private void guna2ButtonReturn_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }




        public bool CheckAccount(string ac)// check username
        {
            return Regex.IsMatch(ac, "^{6,24}$");
        }
        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            string userame = guna2TextBoxUsername.Text;
            string password = guna2TextBoxPassword.Text;
            string displayName = guna2TextBoxDisplayName.Text;
            string phoneNumber = guna2TextBoxPhoneNumber.Text;
            string rePassword = guna2TextBoxRePass.Text;
            if(CheckAccount(userame))
            {
                MessageBox.Show("The length of username must in the range [6,20]");
                return;
            }
            if (userame.Trim() == "")
            {
                MessageBox.Show("Username can't be empty !");
                return;
            }
            if (displayName.Trim() == "")
            {
                MessageBox.Show("Display name can't be empty !");
                return;
            }
            if (password.Trim() == "")
            {
                MessageBox.Show("Password can't be empty !");
                return;
            }
            if(phoneNumber.Trim() == "")
            {
                MessageBox.Show("Phone number can't be empty !");
                return ;
            }
            if (password != rePassword)
            {
                MessageBox.Show("Re-entered password is wrong !");
                return;
            }
            if (AccountDAO.Instance.CheckExist(phoneNumber))
            {
                MessageBox.Show("This phone number has been used.\n Please use another phone number !");
                return;
            }
            try
            {
                string query = "INSERT INTO Account (userName, displayName, passWord, phoneNumber) VALUES ( '" + userame + "' ,'" + displayName + "' ,'" + password + "' ,'" + phoneNumber + "' )";
                DataProvider.Instance.Modify(query);
                MessageBox.Show("Welcome to SAIDONESE coffee !!!");
                fLogin flogin = new fLogin();
                this.Hide();
                flogin.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("This username has been used.\n Please try with another one !");
            }
        }
        private void MemberExist_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
