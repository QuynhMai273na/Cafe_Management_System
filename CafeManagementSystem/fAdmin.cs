﻿using System;
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
            }

        }
    }
}
