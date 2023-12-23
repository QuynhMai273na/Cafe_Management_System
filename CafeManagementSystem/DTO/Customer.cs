using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    public class Customer
    {
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {  
            get { return dateOfBirth; } 
            set {  dateOfBirth = value; }
        }
        private string level;
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public Customer(string phoneNumber, string name, DateTime dateOfBirth, string level) 
        { 
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.level = level;
        }
        public Customer(DataRow row)
        {
            this.phoneNumber = row["phoneNumber"].ToString();
            this.name = row["name"].ToString();
            this.dateOfBirth = (DateTime)row["dateOfBirth"];
            this.level = row["level"].ToString();
        }
    }
}

