using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CafeManagementSystem.DTO;
using System.Data;

namespace CafeManagementSystem.DAO
{
    public class CategoriesDAO
    {
        private static CategoriesDAO instance;
        public static CategoriesDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoriesDAO();
                return CategoriesDAO.instance;
            }
            private set { instance = value; }
        }
        private CategoriesDAO()
        {
        }
        public List<Categories> GetListCategories()
        {
            List<Categories> listCate = new List<Categories>();
            string query = "select * from Category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Categories cate = new Categories(item);
                listCate.Add(cate);
            }
            return listCate;
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
        public List<Categories> SearchCateByName(string nearName)
        {
            List<Categories> list = new List<Categories>();
            nearName = RemoveDiacritics(nearName);
            string query = string.Format("SELECT * FROM Category WHERE name COLLATE SQL_Latin1_General_CP1253_CI_AI LIKE N'%{0}%' ", nearName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Categories cate = new Categories(item);
                list.Add(cate);
            }
            return list;
        }
        public void AddCategories(string id, string name)
        {
            string query = string.Format("Insert into category (id,name) values ({0},N'{1}')",id,name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
        public void EditCategories(string id, string name)
        {
            string query = string.Format("update category set name = N'{0}' where id = {1}",name,id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
        public void DeleteCategories(string id)
        {
            string query = string.Format("Delete FROM category WHERE id =  {0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
