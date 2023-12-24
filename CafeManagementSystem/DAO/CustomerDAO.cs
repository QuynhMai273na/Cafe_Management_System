using CafeManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CafeManagementSystem.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null) instance = new CustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private CustomerDAO() { }
        public List<Customer> GetCustomerByPhone(string phoneNumber)
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM Customer WHERE phoneNumber = " + phoneNumber;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer Customer = new Customer(item);
                list.Add(Customer);
            }
            return list;
        }
        public Customer GetOneCustomerByPhone (string phone)
        {
            string query = string.Format("Select * from Customer where phoneNumber = N'{0}'", phone);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer cus = new Customer(item);
                return cus;
            }
            return null;
        }
        
    }
}
