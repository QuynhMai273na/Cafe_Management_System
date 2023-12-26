using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using System.Drawing.Printing;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using CafeManagementSystem.DAO;
using CafeManagementSystem.DTO;

namespace CafeManagementSystem
{
    public partial class fExportBill : Form
    {
        private List<DTO.Menu> listMenu;
        public List<DTO.Menu> ListMenu
        {
            get { return listMenu; }
            private set { listMenu = value; }
        }

        public fExportBill(List<DTO.Menu> menus, string phoneNumber, string nameCus, int idBill, int totalmoney, int moneyAfterDis, string discount)
        {
            InitializeComponent();
            this.listMenu = menus;
            this.guna2TextBoxPhoneNumber.Text = phoneNumber;
            this.guna2TextBoxCusName.Text = nameCus;
            this.guna2TextBoxDiscount.Text = discount.ToString();
            this.guna2TextBoxIdBill.Text= idBill.ToString();
            this. guna2TextBoxTotalMoney.Text = totalmoney.ToString();
            this.guna2TextBoxFinalmoney.Text = moneyAfterDis.ToString();
            this.guna2TextBoxDatePayment.Text = DateTime.Now.Date.ToShortDateString();
            dataGridViewExport.DataSource = listMenu;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
            pd.Print();

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
