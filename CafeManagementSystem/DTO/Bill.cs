using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagementSystem.DAO;

namespace CafeManagementSystem.DTO
{
    public class Bill
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idTable;
        public int IdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }
        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        private DateTime? datePayment;
        public DateTime? DatePayment
        {
            get { return datePayment; }
            set { datePayment = value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private int totalMoney;
        public int TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }

        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public Bill(int id, int idTable, string customer, DateTime? datePayment, int status,int totalmoney, string note, int discount)
        {
            this.Id = id;
            this.IdTable = idTable;
            this.Customer = customer;
            this.DatePayment = datePayment;
            this.Status = status;
            this.TotalMoney = totalmoney;
            this.Note= note;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdTable = (int)row["idTable"];

           if (Customer != null)
            {
                this.Customer = (string)row["customer"];
            }
            else this.customer = "";
            var datePaymentTemp = row["datePayment"];
            if (datePaymentTemp.ToString() != "")
            {
                this.DatePayment = (DateTime?)row["datePayment"];
            }
            this.Status = (int)row["status"];
            this.Note = row["note"].ToString();
            this.discount = (int)row["discount"];
            this.totalMoney = (int)row["totalMoney"];
        }
    }
}
