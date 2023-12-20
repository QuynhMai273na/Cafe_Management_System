using Guna.UI2.WinForms;
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
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
        }
        private void fSignup_Load(object sender, EventArgs e)
        {
            guna2ShadowForm2.SetShadowForm(this);
        }

        private void guna2ButtonReturn_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();    
            login.ShowDialog();
            this.Close();
        }

        private void forgotPW_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
