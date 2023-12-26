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
using CafeManagementSystem.DAO;
using System.Security.Cryptography;

namespace CafeManagementSystem
{
    public partial class UserProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public UserProfile(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            LoadInfo(loginAccount);
        }
        void LoadInfo(Account acc)
        {
            guna2TextBoxUserNameProfile.Text = acc.DisplayName.ToString();
            labelusernameprofile.Text="@"+acc.UserName.ToString();
            labelTypeAccount.Text="Type Account: "+acc.AccountType.ToString();
            guna2TextBoxDisplayName.Text=acc.DisplayName.ToString();
            guna2TextBoxUpdatePhoneNumber.Text = acc.PhoneNumber.ToString();
        }

        public string hasPassWord(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        private void guna2ButtonChangeInfo_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxNewPW.Text != guna2TextBoxReEnterNewPW.Text)
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "The Re-Enter New Password is not correct.";
                noti.ShowDialog();
            }
            else if (loginAccount.PassWord != hasPassWord(guna2TextBoxPWSetting.Text))
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "The Password is not correct.";
                noti.ShowDialog();
            }
            else
            {
                AccountDAO.Instance.EditAccountInUserProfile(loginAccount.UserName, guna2TextBoxDisplayName.Text, guna2TextBoxUpdatePhoneNumber.Text, guna2TextBoxNewPW.Text);
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Successfully update information.";
                noti.ShowDialog();
              
                guna2TextBoxNewPW.Text = "";
                guna2TextBoxReEnterNewPW.Text = "";
                guna2TextBoxPWSetting.Text = "";
                Account newAcc=AccountDAO.Instance.GetAccountByUserName(loginAccount.UserName);
                LoadInfo(newAcc);
            }
        }
    }
}
