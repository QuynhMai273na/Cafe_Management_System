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
        private void guna2ButtonSignUp_Click(object sender, EventArgs e)
        {
            string userame = guna2TextBoxUsername.Text;
            string password = guna2TextBoxPassword.Text;
            string displayName = guna2TextBoxDisplayName.Text;
            string phoneNumber = guna2TextBoxPhoneNumber.Text;
            string rePassword = guna2TextBoxRePass.Text;
            if(!CheckAccount(userame))
            {
                //MessageBox.Show("The length of username must in the range [6,24]");
                fNotification noti=new fNotification();
                noti.labelNote.Text = "The length of username must in the range [6,24]";
                noti.ShowDialog();
                return;
            }
            if (userame.Trim() == "")
            {
                //MessageBox.Show("Username can't be empty !");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Username can't be empty !";
                noti.ShowDialog();
                return;
            }
            if (displayName.Trim() == "")
            {
                //MessageBox.Show("Display name can't be empty !");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Display name can't be empty !";
                noti.ShowDialog();
                return;
            }
            if (password.Trim() == "")
            {
                //MessageBox.Show("Password can't be empty !");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Password can't be empty !";
                noti.ShowDialog();
                return;
            }
            if(phoneNumber.Trim() == "")
            {
                //MessageBox.Show("Phone number can't be empty !");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Phone number can't be empty !";
                noti.ShowDialog();
                return ;
            }
            if (password != rePassword)
            {
                // MessageBox.Show("Re-entered password is wrong !");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Re-entered password is wrong !";
                noti.ShowDialog();
                return;
            }
            if (AccountDAO.Instance.CheckExist(phoneNumber))
            {
                //MessageBox.Show("This phone number has been used.\n Please use another phone number !");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "This phone number has been used.\n Please use another phone number !";
                noti.ShowDialog();
                return;
            }
            try
            {
                string query = "INSERT INTO Account (userName, displayName, passWord, phoneNumber) VALUES ( '" + userame + "' ,'" + displayName + "' ,'" + password + "' ,'" + phoneNumber + "' )";
                DataProvider.Instance.Modify(query);
                //MessageBox.Show("Welcome to SAIDONESE coffee !!!");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Welcome to SAIGONESE coffee !!!";
                noti.ShowDialog();
                fLogin flogin = new fLogin();
                this.Hide();
                flogin.ShowDialog();
                this.Close();
            }
            catch
            {
                // MessageBox.Show("This username has been used.\n Please try with another one !");
                fNotification noti = new fNotification();
                noti.labelNote.Text = "This username has been used.\n Please try with another one !";
                noti.ShowDialog();
            }
        }
        private void MemberExist_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void guna2TextBoxRePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) guna2ButtonSignUp.PerformClick();

        }
    }
}
