using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagementSystem.DAO;
using CafeManagementSystem.DTO;
using Guna.UI2.WinForms;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System;

namespace CafeManagementSystem
{
    public partial class fCustomerOverview : Form
    {
        int sumPrice = 0;
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fCustomerOverview(Account account)
        {

            InitializeComponent();
            loginAccount = account;
            LoadTable();
        }
        #region Methods

        void LoadTable()
        {
            flowLayoutPanelTableCustomer.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 80, Height = 80, };
                btn.Font = new System.Drawing.Font("Microsoft YaHei", 8, System.Drawing.FontStyle.Regular);
                btn.Text = item.Name + "\n" + item.NumPeople + "people";
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Reserved":
                        btn.BackColor = Color.Pink;
                        break;
                    case "Occupied":
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }

                flowLayoutPanelTableCustomer.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            sumPrice = 0;
            listViewBillCustomer.Items.Clear();
            List<CafeManagementSystem.DTO.Menu> listbillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (CafeManagementSystem.DTO.Menu item in listbillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                sumPrice = sumPrice + item.TotalPrice;
                // thêm vào list view bill
                listViewBillCustomer.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            this.labelTotalBillCustomer.Text = "Total: \t" + sumPrice.ToString("c");

        }
        void LoadFoodList(string nearName)
        {
            List<Food> listFoods = FoodDAO.Instance.SearchFoodByName(nearName);
            if (listFoods.Count == 0)
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "This item is not available in the menu !";
                noti.ShowDialog();
            }
            guna2ComboBoxResultSearchCustomer.DataSource = listFoods;
            guna2ComboBoxResultSearchCustomer.DisplayMember = "Name";
        }
        #endregion
        #region events
        void btn_Click(object sender, EventArgs e)
        {
            int idTable = ((sender as Button).Tag as Table).Id;
            listViewBillCustomer.Tag = (sender as Button).Tag;
            ShowBill(idTable);
        }
        private void guna2CircleButtonAddFood_Click(object sender, EventArgs e)
        {
            Table table = listViewBillCustomer.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);

            int idFood = (guna2ComboBoxResultSearchCustomer.SelectedItem as Food).Id;
            int count = (int)guna2NumericUpDownNumberAddCustomer.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.getMaxIdBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }
            ShowBill(table.Id);
            LoadTable();
        }
        private void guna2TextBoxSearchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadFoodList(guna2TextBoxSearchCustomer.Text);
            }
        }

        private void guna2ButtonOrderCustomer_Click(object sender, EventArgs e)
        {
            Table table = listViewBillCustomer.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);
            if (idBill != -1)
            {
                string query = "UPDATE dbo.Bill SET customer = @customer WHERE id = @id";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { loginAccount.PhoneNumber, idBill });
                DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateBillOrder @idBill , @totalmoney , @note ", new object[] { idBill, sumPrice, textBoxWriteNoteCustomer.Text });
                ShowBill(table.Id);
            }
            LoadTable();
            fNotification noti = new fNotification();
            noti.labelNote.Text = "You have placed your order successfully!\n Your food will be served in a few minutes.\n Thank you !!!";
            noti.ShowDialog();

        }
        private void guna2ButtonCancelCustomer_Click(object sender, EventArgs e)
        {
            fNotifyPayment noti = new fNotifyPayment();
            noti.labelNote.Text = "Are you sure to cancel your order ?";
            noti.ShowDialog();
            if (noti.pay == true)
            {
                Table table = listViewBillCustomer.Tag as Table;
                int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id); if (idBill != -1)
                {
                    // delete bill
                    DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.BillInfo WHERE idBill = " + idBill);
                    DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.Bill WHERE id = " + idBill);
                    DataProvider.Instance.ExecuteNonQuery("update Tablefood set status = 'Free' where id = " + table.Id);
                    ShowBill(table.Id);
                    LoadTable();
                }
            }
        }

        #endregion


    }
}
