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
                btn.Text= item.Name +"\n"+item.NumPeople+"\n"+item.Location;
                switch (item.Status)
                {
                    case Enums.TableStatus.Reserved:
                        btn.BackColor = Color.Pink;
                        break;
                    case Enums.TableStatus.Occupied:
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.Green;
                        break;
                }

            }
        }
        #endregion
    }
}
