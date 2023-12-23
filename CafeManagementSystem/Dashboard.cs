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
        float totalmoney = 0;
        public Dashboard()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Methods
        List<Food> SearchFoodByName(string nearName)
        { 
            List<Food> listFoods = FoodDAO.Instance.SearchFoodByName(nearName);
            return listFoods;
        }
        void LoadFoodList() { }
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
            float sumPrice = 0;
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
            ShowBill(idTable);
        }

        private void guna2NumericUpDownDiscount_ValueChanged(object sender, EventArgs e)
        {
            float moneyAfterDis = totalmoney * (100 - ((float)Convert.ToDouble(this.guna2NumericUpDownDiscount.Value.ToString()))) / 100;
            this.labelTotalBill.Text = "Total: \t" + moneyAfterDis.ToString("c");
        }
        private void guna2TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchFoodByName(guna2TextBoxSearch.Text);
        }
        private void guna2ComboBoxResultSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFoodList();
        }



        #endregion


    }
}
