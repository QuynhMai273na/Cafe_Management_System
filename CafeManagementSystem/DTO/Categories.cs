using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CafeManagementSystem.DTO
{
    public class Categories
    {
        private int idCategories;
        public int IdCategories
        {
            get { return idCategories; }
            set { idCategories = value; }
        }

        private string nameCategories;
        public string NameCategories
        {
            get { return nameCategories; }
            set { nameCategories = value; }
        }
        public Categories(int id, string name)
        {
            this.idCategories = id;
            this.nameCategories = name;
        }
        public Categories(DataRow row)
        {
            this.idCategories= (int)row["id"];
            this.nameCategories= row["name"].ToString();
        }
    }
}
