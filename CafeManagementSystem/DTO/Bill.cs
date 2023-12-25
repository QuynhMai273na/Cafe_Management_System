using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private float totalMoney;
        public float TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }
        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        private DateTime dateCheckin;
        public DateTime DateCheckin
        {
            get { return dateCheckin; }
            set { dateCheckin = value; }
        }

        public Bill(int id, int idTable, string customer, DateTime? datePayment, int status, float totalMoney, int discount, string note, DateTime dateCheckin)
        {
            this.Id = id;
            this.IdTable = idTable;
            this.Customer = customer;
            this.DatePayment = datePayment;
            this.Status = status;
            this.TotalMoney = totalMoney;
            this.Discount = discount;
            this.note = note;
            this.dateCheckin = dateCheckin;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdTable = (int)row["idTable"];

            if (customer != null)
            {
                this.Customer = (string)row["customer"];
            }
            var datePaymentTemp = row["datePayment"];
            if (datePaymentTemp.ToString() != "")
            {
                this.DatePayment = (DateTime?)datePayment;
            }
            this.Status = (int)row["status"];
            this.TotalMoney = (float)Convert.ToDouble(row["totalMoney"]);
            this.Discount = (int)row["discount"];
            if (note != null)
            {
                this.Note = row["note"].ToString();
            }
            this.DateCheckin = (DateTime)row["dateCheckin"];
        }
    }
}
