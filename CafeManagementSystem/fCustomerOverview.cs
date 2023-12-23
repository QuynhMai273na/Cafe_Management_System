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
        //public fCustomerOverview()
        //{
        //    InitializeComponent();
        //    LoadTable();
        //}
        #region Methods

        //void LoadTable()
        //{
        //    flowLayoutPanelTableCustomer.Controls.Clear();
        //    List<Table> tableList = TableDAO.Instance.LoadTableList();
        //    foreach (Table item in tableList)
        //    {
        //        Button btn = new Button() { Width = 80, Height = 80, };
        //        btn.Font = new System.Drawing.Font("Microsoft YaHei", 8, System.Drawing.FontStyle.Regular);
        //        btn.Text = item.Name + "\n" + item.Location;
        //        btn.Click += btn_Click;
        //        btn.Tag = item;
        //        switch (item.Status)
        //        {
        //            case "Reserved":
        //                btn.BackColor = Color.Pink;
        //                break;
        //            case "Occupied":
        //                btn.BackColor = Color.Red;
        //                break;
        //            default:
        //                btn.BackColor = Color.LightGreen;
        //                break;
        //        }
        //        flowLayoutPanelTableCustomer.Controls.Add(btn);
        //    }
        //}
        //void ShowBill(int id)
        //{
        //    int sumPrice = 0;
        //    listViewBillCustomer.Items.Clear();
        //    List<CafeManagementSystem.DTO.Menu> listbillInfo = MenuDAO.Instance.GetListMenuByTable(id);
        //    foreach (CafeManagementSystem.DTO.Menu item in listbillInfo)
        //    {
        //        ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
        //        lsvItem.SubItems.Add(item.Price.ToString());
        //        lsvItem.SubItems.Add(item.Count.ToString());
        //        lsvItem.SubItems.Add(item.TotalPrice.ToString());
        //        sumPrice = sumPrice + item.TotalPrice;
        //        // thêm vào list view bill
        //        listViewBillCustomer.Items.Add(lsvItem);
        //    }
        //    totalmoney = sumPrice;
        //    CultureInfo culture = new CultureInfo("vi-VN");
        //    Thread.CurrentThread.CurrentCulture = culture;
        //    this.labelTotalBill.Text = "Total: \t" + totalmoney.ToString("c");

        //}
        #endregion
        #region events
        //void btn_Click(object sender, EventArgs e)
        //{
        //    int idTable = ((sender as Button).Tag as Table).Id;
        //    listViewBillCustomer.Tag = (sender as Button).Tag;
        //    ShowBill(idTable);
        //}

        #endregion
    }
}
