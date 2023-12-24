using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagementSystem.DTO;

namespace CafeManagementSystem
{
    public partial class CustomerProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public CustomerProfile(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
        }

        
    }
}
