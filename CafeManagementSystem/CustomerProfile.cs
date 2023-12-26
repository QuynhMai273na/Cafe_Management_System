using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagementSystem.DAO;
using CafeManagementSystem.DTO;
using Guna.UI2.WinForms;
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
            
            LoadDateTimePickerBill();
            LoadListBillByDateOfCustomer(guna2DateTimePickerHistoryBillsCustomer1.Value, guna2DateTimePickerHistoryBillsCustomer2.Value);
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
        private void guna2ButtonChangeInfoCustomer_Click(object sender, EventArgs e)
        {
        
            if (hasPassWord( guna2TextBoxPWSettingCustomer.Text)!=loginAccount.PassWord)
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
                string pass = guna2TextBoxNewPWCustomer.Text;
                pass = hasPassWord(pass);
                string query = string.Format("update Customer set dateOfBirth='{0}',name=N'{1}' where phoneNumber=N'{2}'", guna2TextBoxUpdateDOBCustomer.Text, guna2TextBoxDisplayNameCustomer.Text, guna2TextBoxPhoneCustomer.Text);
                string query2 = string.Format("update account set displayName=N'{0}', passWord=N'{1}' where userName=N'{2}'", guna2TextBoxDisplayNameCustomer.Text, pass, loginAccount.UserName.ToString());
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
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            guna2DateTimePickerHistoryBillsCustomer1.Value = new DateTime(today.Year, today.Month, 1);
            guna2DateTimePickerHistoryBillsCustomer2.Value = guna2DateTimePickerHistoryBillsCustomer1.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDateOfCustomer(DateTime dayFrom, DateTime dayTo)
        {
            dataGridViewBillOfCus.DataSource = BillDAO.Instance.GetBillListByDateOfCustomer(dayFrom, dayTo,loginAccount.PhoneNumber.ToString());

        }

     

        private void guna2ButtonHistoryBillsCustomer_Click(object sender, EventArgs e)
        {
            LoadListBillByDateOfCustomer(guna2DateTimePickerHistoryBillsCustomer1.Value, guna2DateTimePickerHistoryBillsCustomer2.Value);
        }
    }
}
