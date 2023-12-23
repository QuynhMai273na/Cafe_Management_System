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
        void LoadFoodListById(int id)
        {
            List<Food> list = FoodDAO.Instance.GetFoodById(id);
            guna2ComboBoxResultSearch.DataSource = list;
            guna2ComboBoxResultSearch.DisplayMember = "Name";
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 80, Height = 80, };
                btn.Font = new System.Drawing.Font("Microsoft YaHei", 8, System.Drawing.FontStyle.Regular);
                btn.Text = item.Name + "\n" + item.Location;
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
            // listViewBill
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
            float moneyAfterDis = (float)(totalmoney * (100 - Convert.ToInt16(this.guna2NumericUpDownDiscount.Value.ToString()))) / 100;
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
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.Id);

            int idFood = (guna2ComboBoxResultSearch.SelectedItem as Food).Id;
            int count = (int)guna2NumericUpDownNumberAdd.Value;
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
        }


        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
