using CafeManagementSystem.DAO;
using CafeManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class fTableManagement : Form
    {
        public fTableManagement()
        {
            InitializeComponent();
        }

        #region Method 
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = item.Name + "\n" + item.NumPeople + "\n" + item.Location;
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
                        btn.BackColor = Color.Green;
                        break;
                }

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
        #endregion
        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int idTable =((sender as Button).Tag as Table).Id;
            ShowBill(idTable);
        }

        private void guna2ButtonDashBoard_Click(object sender, EventArgs e)
        {
            labelTableManage.Text = "Table Manager Overview";
            guna2PictureBoxTableIcon.Image = Properties.Resources._4;
            container(new Dashboard());
        }
        #endregion
        //cm code

        private void container(object _form)
        {
            if (guna2PanelContainer.Controls.Count > 0) guna2PanelContainer.Controls.Clear();

            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2PanelContainer.Controls.Add(form);
            guna2PanelContainer.Tag = form;
            form.Show();
        }

        private void guna2ButtonAdmin_Click(object sender, EventArgs e)
        {
            labelTableManage.Text = "Admin Management";
            guna2PictureBoxTableIcon.Image = Properties.Resources._5;
            container(new fAdmin());
        }

        private void guna2ButtonUserProfile_Click(object sender, EventArgs e)
        {
            labelTableManage.Text = "User Profile";
            guna2PictureBoxTableIcon.Image = Properties.Resources._6;
            container(new UserProfile());
        }
    }
}
