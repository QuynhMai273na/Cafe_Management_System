using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagementSystem.DAO;
using CafeManagementSystem.DTO;
using Guna.UI2.WinForms.Suite;

namespace CafeManagementSystem
{
    public partial class CustomerProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public CustomerProfile(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            LoadInfo(loginAccount);
        }

        void LoadInfo(Account acc)
        {
            string phone = acc.PhoneNumber.ToString();
            Customer cus=CustomerDAO.Instance.GetOneCustomerByPhone(phone);
            guna2TextBoxUserNameProfileCustomer.Text = acc.DisplayName.ToString();
            labelusernameprofileCustomer.Text="@"+acc.UserName.ToString();
            guna2TextBoxDOBCustomer.Text=cus.DateOfBirth.ToString("MM/dd/yyyy");
            guna2TextBoxPhoneCustomer.Text=acc.PhoneNumber.ToString();
            guna2TextBoxAccountLevelCustomer.Text=cus.Level.ToString();
            guna2TextBoxDisplayNameCustomer.Text=acc.DisplayName.ToString();
            guna2TextBoxUpdateDOBCustomer.Text = cus.DateOfBirth.ToString("MM/dd/yyyy");

        }

        private void guna2ButtonChangeInfoCustomer_Click(object sender, EventArgs e)
        {
        
            if (guna2TextBoxPWSettingCustomer.Text!=loginAccount.PassWord)
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "The Password is not correct.";
                noti.ShowDialog();
            }
            else if (guna2TextBoxNewPWCustomer.Text != guna2TextBoxReEnterNewPWCustomer.Text)
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "The Re-Enter New Password is not correct.";
                noti.ShowDialog();
            }
            else
            {
                string query = string.Format("update Customer set dateOfBirth='{0}',name=N'{1}' where phoneNumber=N'{2}'", guna2TextBoxUpdateDOBCustomer.Text, guna2TextBoxDisplayNameCustomer.Text, guna2TextBoxPhoneCustomer.Text);
                string query2 = string.Format("update account set displayName=N'{0}', passWord=N'{1}' where userName=N'{2}'", guna2TextBoxDisplayNameCustomer.Text, guna2TextBoxNewPWCustomer.Text, loginAccount.UserName.ToString());
                DataProvider.Instance.ExecuteQuery(query2);
                DataProvider.Instance.ExecuteQuery(query);
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Successfully update information.";
                noti.ShowDialog();

                guna2TextBoxPWSettingCustomer.Text = "";
                guna2TextBoxNewPWCustomer.Text = "";
                guna2TextBoxReEnterNewPWCustomer.Text = "";
                Account newAcc = AccountDAO.Instance.GetAccountByUserName(loginAccount.UserName);
                LoadInfo(newAcc);
            }
            
        }
    }
}
