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

namespace CafeManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 80, Height = 80, };
                btn.Font = new System.Drawing.Font("Microsoft YaHei", 8, System.Drawing.FontStyle.Regular);
                btn.Text = item.Name + "\n" + item.Location;
                // btn.Click += btn_Click;
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
            //lsvBill.Items.Clear();
            List<CafeManagementSystem.DTO.Menu> listbillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (CafeManagementSystem.DTO.Menu item in listbillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                // thêm vào list view bill
                //lsvBill.Items.Add(lsvItem);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            int idTable = ((sender as Button).Tag as Table).Id;
            ShowBill(idTable);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBoxShowBill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
