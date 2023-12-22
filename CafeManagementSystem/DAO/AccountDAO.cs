using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DataTable data= DataProvider.Instance.ExecuteQuery("Select accountType from Account where userName='" + userName+"'");
            foreach (DataRow item in data.Rows)
            {
                string type = item[0].ToString();
                //Account account = new Account(item);
                return type;
            }
            return "";
        }
    }
}
