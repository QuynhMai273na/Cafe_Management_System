using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagementSystem.DAO;
using CafeManagementSystem.DTO;

namespace CafeManagementSystem
{
    public partial class fAdmin : System.Windows.Forms.Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList(guna2TextBoxSearchAccounts.Text);
        }
     /*   void ShowAccount()
        {
            // listViewAccount
            listViewAccount.Items.Clear();
            List<CafeManagementSystem.DTO.Account> listAccount = AccountDAO.Instance.GetListAccount();
            foreach (CafeManagementSystem.DTO.Account item in listAccount)
            {
                ListViewItem lsvItem = new ListViewItem(item.DisplayName.ToString());
                lsvItem.SubItems.Add(item.UserName.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber.ToString());
                lsvItem.SubItems.Add(item.AccountType.ToString());
              //  lsvItem.SubItems.Add(item.PassWord.ToString());
                // thêm vào list view bill
                listViewAccount.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
        }
     */
        void LoadAccountList(string nearName)
        {
            List<Account> listAcc = AccountDAO.Instance.SearchAccountByName(nearName);
            listViewAccount.Items.Clear();
          //  List<CafeManagementSystem.DTO.Account> listAccount = AccountDAO.Instance.GetListAccount();
            foreach (CafeManagementSystem.DTO.Account item in listAcc)
            {
                ListViewItem lsvItem = new ListViewItem(item.DisplayName.ToString());
                lsvItem.SubItems.Add(item.UserName.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber.ToString());
                lsvItem.SubItems.Add(item.AccountType.ToString());
                //  lsvItem.SubItems.Add(item.PassWord.ToString());
                // thêm vào list view bill
                listViewAccount.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
        }
        private void guna2TextBoxSearchAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadAccountList(guna2TextBoxSearchAccounts.Text);
            }
        }

        private void listViewAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAccount.SelectedItems.Count == 0)
            {
                guna2TextBoxName.Text = "";
                guna2TextBoxUserName.Text = "";
                guna2TextBoxPhone.Text = "";
                guna2TextBoxType.Text = "";
            }
            else
            {
                ListViewItem item = listViewAccount.SelectedItems[0];
                guna2TextBoxName.Text = item.SubItems[0].Text;
                guna2TextBoxUserName.Text = item.SubItems[1].Text;
                guna2TextBoxPhone.Text = item.SubItems[2].Text;
                guna2TextBoxType.Text = item.SubItems[3].Text;

                guna2TextBoxName.Enabled = false;
                guna2TextBoxPhone.Enabled = false;
                guna2TextBoxType.Enabled = false;
                guna2TextBoxUserName.Enabled = false;
                guna2TextBoxPass.Enabled = false;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBoxName.Enabled = true;
            guna2TextBoxPhone.Enabled = true;
            guna2TextBoxType.Enabled = true;
        }

        private void guna2ButtonAddAccounts_Click(object sender, EventArgs e)
        {
            guna2TextBoxName.Enabled = true;
            guna2TextBoxPhone.Enabled = true;
            guna2TextBoxType.Enabled = true;
            guna2TextBoxUserName.Enabled = true;
            guna2TextBoxPass.Enabled = true;

            guna2TextBoxName.Text = "";
            guna2TextBoxPhone.Text = "";
            guna2TextBoxType.Text = "";
            guna2TextBoxUserName.Text = "";
            guna2TextBoxPass.Text = "";
        }

        private void guna2PictureBoxRefreshAccounts_Click(object sender, EventArgs e)
        {
            LoadAccountList(guna2TextBoxSearchAccounts.Text);
            guna2TextBoxName.Text = "";
            guna2TextBoxPhone.Text = "";
            guna2TextBoxType.Text = "";
            guna2TextBoxUserName.Text = "";
            guna2TextBoxPass.Text = "";
        }

        private void guna2ButtonDeleteAccounts_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.DeleteAccount(guna2TextBoxUserName.Text);
            guna2TextBoxName.Text = "";
            guna2TextBoxPhone.Text = "";
            guna2TextBoxType.Text = "";
            guna2TextBoxUserName.Text = "";
            guna2TextBoxPass.Text = "";
            LoadAccountList(guna2TextBoxSearchAccounts.Text);
        }

        private void guna2ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxUserName.Enabled==true)
            {
                AccountDAO.Instance.AddAccount(guna2TextBoxUserName.Text, guna2TextBoxName.Text, guna2TextBoxPass.Text, guna2TextBoxType.Text, guna2TextBoxPhone.Text);
                guna2TextBoxName.Text = "";
                guna2TextBoxPhone.Text = "";
                guna2TextBoxType.Text = "";
                guna2TextBoxUserName.Text = "";
                guna2TextBoxPass.Text = "";
            }
            else
            {
                 AccountDAO.Instance.EditAccount(guna2TextBoxUserName.Text, guna2TextBoxName.Text,guna2TextBoxType.Text,guna2TextBoxPhone.Text);
            }
        }
    }
}
