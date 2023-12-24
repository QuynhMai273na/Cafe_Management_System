 using CafeManagementSystem.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
/*
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
        public List<Bill> SearchBillByID(string id)
        {
            List<Bill> list = new List<Bill>();
            id = RemoveDiacritics(id);
            string query = string.Format("SELECT * FROM Bill WHERE id COLLATE SQL_Latin1_General_CP1253_CI_AI LIKE N'%{0}%' ", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item); 
                list.Add(bill);
            }
            return list;
        }
        */
        public List<Bill> GetListBill()
        {
            List<Bill> listBill = new List<Bill>();
            string query = "select * from bill where status=1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill bill  = new Bill(item);
                listBill.Add(bill);
            }
            return listBill;
        }
    }
}
