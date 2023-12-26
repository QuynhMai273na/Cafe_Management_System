using System;
using System.Drawing;
using System.Windows.Forms;
using CafeManagementSystem.DAO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace CafeManagementSystem
{
    public partial class fLogin : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public fLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
            this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
            this.MouseUp += new MouseEventHandler(MainForm_MouseUp);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void guna2ButtonShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = "cfmanager"; // guna2TextBoxUsername.Text;
            string password = "@welcomecafe"; // guna2TextBoxPassWord.Text;
         
           if (username.Trim()=="")
            {
                fNotification noti=new fNotification();
                noti.labelNote.Text = "Please enter username !";
                noti.ShowDialog();
            }
           else if (password.Trim() == "")
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Please enter password !";
                noti.ShowDialog();
            }
           else if (Login(username,password))
            {
                string typeAccount = AccountDAO.Instance.GetTypeAccountByUserName(username);


                if (typeAccount=="Member")
                {
                    fCustomerLogin customerForm = new fCustomerLogin(AccountDAO.Instance.GetAccountByUserName(username));
                    this.Hide();
                    customerForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    fTableManagement tableManagement = new fTableManagement(AccountDAO.Instance.GetAccountByUserName(username));
                    this.Hide();
                    tableManagement.ShowDialog();
                    this.Close();
                }    
                
            }
           else
            {
                fNotification noti = new fNotification();
                noti.labelNote.Text = "Wrong user name or password !";
                noti.ShowDialog();
            }
        }
        private void guna2TextBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) guna2TextBoxPassWord.Focus();
        }

        private void guna2TextBoxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) guna2ButtonLogin.PerformClick();

        }

        private void labelCreateNewAccount_Click(object sender, EventArgs e)
        {
            fSignup signup = new fSignup();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }
    }
}
    