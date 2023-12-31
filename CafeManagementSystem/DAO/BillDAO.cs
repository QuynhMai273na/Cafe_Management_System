﻿ using CafeManagementSystem.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CafeManagementSystem.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return BillDAO.instance;
            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        //thành công bill id, thất bại -1
        public int GetUncheckBillIdByTableId(int id)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE CONVERT(DATE, dateCheckin) = CONVERT(DATE, getdate()) and idTable = " + id + " AND status = 0");
           if (data.Rows.Count > 0)

            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
            string query = "UPDATE dbo.Bill SET dateCheckin = getdate() WHERE id = " + id; ;
            DataProvider.Instance.ExecuteNonQuery(query);
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
       

        public List<Bill> GetListBill()
        {
            List<Bill> listBill = new List<Bill>();
            string query = "select * from bill where status =1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                listBill.Add(bill);
            }
            return listBill;
        }
        public DataTable GetBillListByDate(DateTime dayFrom, DateTime dayTo)
        {
            string df = "'" + dayFrom.Date.ToString("MM/dd/yyyy") + "'";
            string dt = "'" + dayTo.Date.ToString("MM/dd/yyyy") + "'";
            //return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @dayFrom,@dayTo",new object[] { df, dt });
            string query = string.Format("exec USP_GetListBillByDate N{0},N{1}", df, dt);
            return DataProvider.Instance.ExecuteQuery(query);

        }

        public DataTable GetBillListByDateOfCustomer(DateTime dayFrom, DateTime dayTo, string phone)
        {
            string df = "'" + dayFrom.Date.ToString("MM/dd/yyyy") + "'";
            string dt = "'" + dayTo.Date.ToString("MM/dd/yyyy") + "'";
            //return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @dayFrom,@dayTo",new object[] { df, dt });
            string query = string.Format("exec USP_GetListBillByDateOfCustomer N{0},N{1}, N'{2}'", df, dt,phone);
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
