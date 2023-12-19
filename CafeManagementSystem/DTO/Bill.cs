using System;
using System.Collections.Generic;
using System.Data;
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
        public Bill(int id, int idTable, string customer, DateTime? datePayment, int status)
        {
            this.Id = id;
            this.IdTable = idTable;
            this.Customer = customer;
            this.DatePayment = datePayment;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdTable = (int)row["idTable"];
            this.Customer = (string)row["customer"];
            var datePaymentTemp = row["datePayment"];
            if (datePaymentTemp.ToString() != "")
            {
                this.DatePayment = (DateTime?)datePayment;
            }
            this.Status = (int)row["status"];
        }
    }
}
