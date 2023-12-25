using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagementSystem.DTO;


namespace CafeManagementSystem.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
            private set { TableDAO.instance = value; }
        }
        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> listTable = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }
        public List<Table> LoadTableListByOrderDate(string dateCheckin)
        {
            List<Table> listTable = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableListByDateCheckin @dateCheckin", new object[] {dateCheckin});
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }
    }
}
