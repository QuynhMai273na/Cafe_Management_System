using CafeManagementSystem.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { 
              if (instance == null) instance = new BillDAO();
                return BillDAO.instance; 
            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        //thành công bill id, thất bại -1
        public int GetUncheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
        public void InsertBill (int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public int getMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch { return 1; }
        }
        public void CheckOut(int id, Guna2TextBox textBox)
        {
            string query1 = "UPDATE dbo.Bill SET status = 1, datePayment = GETDATE() WHERE id = " + id; ;
            DataProvider.Instance.ExecuteNonQuery(query1);
            
        }
    }
}
