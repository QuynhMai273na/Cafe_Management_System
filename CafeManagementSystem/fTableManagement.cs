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
    }
}
