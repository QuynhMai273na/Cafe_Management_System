using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagementSystem.Enums;

namespace CafeManagementSystem.DTO
{
    public class Table
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int numPeople;
        public int NumPeople
        {
            get { return numPeople; }
            set { numPeople = value; }
        }
        private string status;
        public string Status { get => status; set => status = value; }
        
        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }


        public Table(int id, string name, int numPeople, string status, string location)
        {
            this.id = id;
            this.name = name;
            this.numPeople = numPeople;
            this.status = status;
            this.location = location;
        }
        public Table(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = row["status"].ToString();
            this.location = row["location"].ToString();
        }
        //cmment
    }
}
