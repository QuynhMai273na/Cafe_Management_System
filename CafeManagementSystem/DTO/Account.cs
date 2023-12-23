using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    public class Account
    {

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private string passWord;
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string accountType;
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            set { phoneNumber = value; }
            get { return phoneNumber; }
        }
        public Account(string userName, string displayName, string accountType, string phoneNumber, string passWord = null)
        {
            this.userName = userName;
            this.displayName = displayName;
            this.accountType = accountType;
            this.passWord = passWord;
            this.phoneNumber = phoneNumber;
        }
        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.AccountType = row["accountType"].ToString();
            this.PhoneNumber = row["phoneNumber"].ToString();
        }
    }
}