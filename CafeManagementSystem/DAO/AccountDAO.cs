﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CafeManagementSystem.DTO;

namespace CafeManagementSystem.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if(instance == null) instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            //var list = hasData.ToString();
            //list.Reverse();
            

            string query = "USP_Login @userName , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username , /*password*/hasPass});
            /*Them vao sql để fix lỗi log in chữ hoa chữ thường
             ALTER PROCEDURE USP_Login @userName NVARCHAR(100), @passWord NVARCHAR(100)
            AS
            BEGIN
        	SELECT * FROM dbo.Account 
        	WHERE Account.userName COLLATE SQL_Latin1_General_CP1_CS_AS = @userName 
        	AND Account.passWord COLLATE SQL_Latin1_General_CP1_CS_AS = @passWord
            END
            GO
            chú ý: nhớ reload lại connection trước khi chạy
             */
            //kiểm tra xem biến "result" có chứa dữ liệu không.
            //Nếu số hàng (rows) trong "result" > 0, tức là có ít nhất một hàng dữ liệu, thì trả về true. Ngược lại thì trả về false.
            
            return result.Rows.Count > 0;
        }
        public string hasPassWord(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        public bool CheckExist(string str)
        {
            string query = "SELECT* FROM Account WHERE phoneNumber = '"+ str +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public string GetTypeAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select accountType from Account where userName='" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                string type = item[0].ToString();
                //Account account = new Account(item);
                return type;
            }
            return "";
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where userName='" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
               
                Account account = new Account(item);
                return account;
            }
            return null;
        }
        public List<Account> GetListAccount()
        {
            List<Account> listAcc = new List<Account>();
            string query = "SELECT * FROM dbo.Account ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                listAcc.Add(acc);
            }
            return listAcc;
        }
        static string RemoveDiacritics(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        public List<Account> SearchAccountByName(string nearName)
        {
            List<Account> list = new List<Account>();
            nearName = RemoveDiacritics(nearName);
            string query = string.Format("SELECT * FROM Account WHERE displayName COLLATE SQL_Latin1_General_CP1253_CI_AI LIKE N'%{0}%' ", nearName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }
            return list;
        }
        public void DeleteAccount(string user)
        {
            string queryDelCus = string.Format("Delete from customer where phoneNumber= N'{0}'", GetAccountByUserName(user).PhoneNumber.ToString());
            string query = string.Format("Delete FROM Account WHERE userName =  N'{0}' ", user);
            DataProvider.Instance.ExecuteQuery(queryDelCus);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
        public void AddAccount (string username, string displayname, string password, string accounttype, string phonenumber)
        {
            password = hasPassWord(password);
            string query = string.Format("Insert into account (userName,displayName,passWord,accountType,phoneNumber) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", username, displayname, password, accounttype, phonenumber);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            string queryCreateCustomer = string.Format("insert into Customer (phoneNumber,name, dateOfBirth, level) values(N'{0}',N'{1}',GETDATE(),'Bronze')", phonenumber, displayname);
            DataProvider.Instance.ExecuteQuery(queryCreateCustomer);
        }
        public void EditAccount(string username, string displayname,string accounttype, string phonenumber)
        {
            string query = string.Format("update account set displayName = N'{0}', accountType = N'{1}', phoneNumber = N'{2}' where userName = N'{3}'",displayname,accounttype,phonenumber,username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
        public void EditAccountInUserProfile(string username, string displayname, string phonenumber, string password)
        {
            password=hasPassWord(password);
            string query = string.Format("update account set displayName = N'{0}', phoneNumber = N'{1}', passWord = N'{2}' where userName = N'{3}'", displayname, phonenumber,password, username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
