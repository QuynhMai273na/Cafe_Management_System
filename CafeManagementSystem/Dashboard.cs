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
using Guna.UI2.WinForms;
using System.Globalization;
using System.Threading;
namespace CafeManagementSystem
{
    public partial class Dashboard : Form
    {
        int totalmoney = 0;
        int moneyAfterDis = 0;
        public Dashboard()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Methods

        void LoadFoodList(string nearName)
        {
            List<Food> listFoods = FoodDAO.Instance.SearchFoodByName(nearName);
            if (listFoods.Count == 0)
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "This item is not available in the menu !";
                noti.ShowDialog();
            }
            guna2ComboBoxResultSearch.DataSource = listFoods;
            guna2ComboBoxResultSearch.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flowLayoutPanelTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 80, Height = 80, };
                btn.Font = new System.Drawing.Font("Microsoft YaHei", 8, System.Drawing.FontStyle.Regular);
                btn.Text = item.Name + "\n" + item.NumPeople + "people\n";
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Reserved":
                        btn.BackColor = Color.Pink;
                        break;
                    case "Occupied":
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }
                flowLayoutPanelTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {

            int sumPrice = 0;
            listViewBill.Items.Clear();
            List<CafeManagementSystem.DTO.Menu> listbillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (CafeManagementSystem.DTO.Menu item in listbillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                sumPrice = sumPrice + item.TotalPrice;
                // thêm vào list view bill
                listViewBill.Items.Add(lsvItem);
            }
            totalmoney = sumPrice;
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            this.labelTotalBill.Text = "Total: \t" + totalmoney.ToString("c");


        }
        int ApplyDiscountForCustomerMember(string level)
        {
            if (level == "Diamond") return 15;
            else if (level == "Gold") return 10;
            else if (level == "Silver") return 5;
            else if (level == "Member") return 3;
            else return 0;
        }
        void LoadMemberCustomer(string customerPhone)
        {
            List<Customer> customerList = CustomerDAO.Instance.GetCustomerByPhone(customerPhone);
            guna2TextBoxCustomerName.Text = customerList[0].Name;
            guna2TextBoxCustomerLevel.Text = customerList[0].Level;
            guna2NumericUpDownDiscount.Value = ApplyDiscountForCustomerMember(guna2TextBoxCustomerLevel.Text);
        }
        bool CheckMember(string customerPhone)
        {
            List<Customer> customerList = CustomerDAO.Instance.GetCustomerByPhone(customerPhone);
            if (customerList.Count == 0) return false;
            return true;
        }
        #endregion
        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int idTable = ((sender as Button).Tag as Table).Id;
            listViewBill.Tag = (sender as Button).Tag;
            ShowBill(idTable);
        }

        private void guna2NumericUpDownDiscount_ValueChanged(object sender, EventArgs e)
        {
            moneyAfterDis = (int)(totalmoney * (100 - Convert.ToInt16(this.guna2NumericUpDownDiscount.Value.ToString()))) / 100;
            this.labelTotalBill.Text = "Total: \t" + moneyAfterDis.ToString("c");

        }
        private void guna2TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadFoodList(guna2TextBoxSearch.Text);
            }

        }

        private void guna2CircleButtonAddFood_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;

            int count = (int)guna2NumericUpDownNumberAdd.Value;
            if (count != 0)
            {
                int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);

                int idFood = (guna2ComboBoxResultSearch.SelectedItem as Food).Id;
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.Id);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.getMaxIdBill(), idFood, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
                }
            }

            ShowBill(table.Id);
            LoadTable();
        }
        private void guna2ButtonCheckInfo_Click(object sender, EventArgs e)
        {
            if (CheckMember(guna2TextBoxCustomerPhone.Text))
            {
                LoadMemberCustomer(guna2TextBoxCustomerPhone.Text);
            }
            else
            {
                // hiện thông báo chưa phải thành viên
                fNotification noti = new fNotification();
                noti.labelNote.Text = "You have not yet registered to become a member customer !";
                noti.ShowDialog();

            }
        }

        private void guna2TextBoxCustomerPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) guna2ButtonCheckInfo.PerformClick();
        }
        private void guna2TextBoxCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            guna2TextBoxCustomerName.Text = "";
            guna2TextBoxCustomerLevel.Text = "";
            guna2NumericUpDownDiscount.Value = 0;

        }
        private void guna2ButtonPayMent_Click(object sender, EventArgs e)
        {

            Table table = listViewBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);
            if (idBill != -1)
            {
                fNotifyPayment notice = new fNotifyPayment();
                notice.labelNote.Text = String.Format("Do you really want to make payment for table {0} ?", table.Name);
                notice.ShowDialog();
                if (notice.pay == true)
                {

                    if (guna2TextBoxCustomerPhone.Text != "" && CheckMember(guna2TextBoxCustomerPhone.Text) == true)
                    {
                        string query = "UPDATE dbo.Bill SET customer = @customer WHERE id = @id";
                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { guna2TextBoxCustomerPhone.Text, idBill });
                        int bonus = CustomerDAO.Instance.GetPointsOfCus(guna2TextBoxCustomerPhone.Text) + (int)moneyAfterDis % 1000;
                        string query1 = "UPDATE dbo.customer SET points = @points WHERE phoneNumber = @phoneNumber";
                        DataProvider.Instance.ExecuteNonQuery(query1, new object[] { bonus, guna2TextBoxCustomerPhone.Text });
                    }

                    if (guna2NumericUpDownDiscount.Value == 0) moneyAfterDis = totalmoney;
                    DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateBill @idBill , @totalmoney , @discount , @note", new object[] { idBill, moneyAfterDis, guna2NumericUpDownDiscount.Value, textBoxWriteNote.Text });

                    ShowBill(table.Id);
                    guna2TextBoxCustomerName.Text = "";
                    guna2TextBoxCustomerLevel.Text = "";
                    guna2NumericUpDownDiscount.Value = 0;
                    guna2TextBoxCustomerPhone.Text = "";
                }
            }
            LoadTable();
        }
        private void guna2ButtonExportBill_Click(object sender, EventArgs e)
        {
            if (guna2NumericUpDownDiscount.Value == 0) moneyAfterDis = totalmoney;
            Table table = listViewBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);
            fExportBill billPdf = new fExportBill(MenuDAO.Instance.GetListMenuByTable(table.Id), guna2TextBoxCustomerPhone.Text, guna2TextBoxCustomerName.Text ,idBill, totalmoney, moneyAfterDis, guna2NumericUpDownDiscount.Value.ToString() );
            billPdf.ShowDialog();
        }
        #endregion
    }
}
