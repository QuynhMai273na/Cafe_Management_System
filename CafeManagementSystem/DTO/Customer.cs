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
        private int points;
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public Customer(string phoneNumber, string name, DateTime dateOfBirth, string level, int points) 
        { 
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.level = level;
            this.points = points;
        }
        public Customer(DataRow row)
        {
            this.PhoneNumber = row["phoneNumber"].ToString();
            this.Name = row["name"].ToString();
            this.DateOfBirth = (DateTime)row["dateOfBirth"];
            this.Level = row["level"].ToString();
            this.Points = (int)row["points"];
            
        }
    }
}

