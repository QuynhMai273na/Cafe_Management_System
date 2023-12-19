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
        public bool login(string username, string password)
        {
            string query = "USP_Login @userName , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username , password});
            //kiểm tra xem biến "result" có chứa dữ liệu không.
            //Nếu số hàng (rows) trong "result" > 0, tức là có ít nhất một hàng dữ liệu, thì trả về true. Ngược lại thì trả về false.
            return result.Rows.Count > 0;
        }
    }
}
