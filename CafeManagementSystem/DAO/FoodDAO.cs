using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CafeManagementSystem.DTO;

namespace CafeManagementSystem.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return instance;
            }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }
        public List<Food> GetFoodById(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM Food WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
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
        public List<Food> SearchFoodByName(string nearName)
        {
            List<Food> list = new List<Food>();
            nearName = RemoveDiacritics(nearName);
            string query =string.Format("SELECT * FROM Food WHERE name COLLATE SQL_Latin1_General_CP1253_CI_AI LIKE N'%{0}%' ", nearName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> listFood = new List<Food>();
            string query = "select * from food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }
        public void AddFood(string id, string name, string cateID, string price)
        {
            string query = string.Format("Insert into food (id,name,idCategory,price) values ({0},N'{1}',{2},{3})", id, name,cateID,price);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
        public void EditFood(string id,string name, string price)
        {
            string query = string.Format("update food set name = N'{0}',price={1} where id = {2}", name, price,id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
        public void DeleteFood(string id)
        {
            string query = string.Format("Delete FROM food WHERE id =  {0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
