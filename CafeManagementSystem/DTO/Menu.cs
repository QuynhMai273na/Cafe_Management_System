﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DTO
{
    public class Menu
    {
        private string foodName;
        public string FoodName
        {
            get { return foodName; }    
            set { foodName = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private int totalPrice;
        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        public Menu(string foodName,int count, int price, int totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)  
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (int)row["price"];
            this.TotalPrice = (int)row["totalPrice"];
        }
    }
}
