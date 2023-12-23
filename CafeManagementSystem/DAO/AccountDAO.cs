using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
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
            string query = "USP_Login @userName , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username , password});
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
    }
}
