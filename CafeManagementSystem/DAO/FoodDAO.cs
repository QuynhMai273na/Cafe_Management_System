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

    }
}
