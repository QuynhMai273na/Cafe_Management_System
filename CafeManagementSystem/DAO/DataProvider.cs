using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CafeManagementSystem.DAO
{
    public class DataProvider // design pattern singleton: chi ton tai duy nhat 1 the hien trong chuong trinh
    {
        private static DataProvider instance;
        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=CafeManagement;Integrated Security=True";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');// vi tach theo khoang trang nen khi viet query phai them khoang trang truoc dau phay
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        // fix lỗi 
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                        
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);// trung gian thuc hien cau truy van
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null) // tra ve so dong thanh cong (chi sd cho insert,update, delete)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');// vi tach theo khoang trang nen khi viet query phai them khoang trang truoc dau phay
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);// trung gian thuc hien cau truy van
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null) // tra ve so dong thanh cong
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');// vi tach theo khoang trang nen khi viet query phai them khoang trang truoc dau phay
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);// trung gian thuc hien cau truy van
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public void Modify(string query) //dung de dang ky tai khoan
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
