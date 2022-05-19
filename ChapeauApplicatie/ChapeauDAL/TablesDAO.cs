using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauModels;

namespace ChapeauDAL
{
    public class TablesDAO : BaseDao
    {
        public List<Tables> GetAllTables()
        {
            string query = "SELECT TableID, Reserved, EmployeeID FROM Tables";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Tables> ReadTables(DataTable dataTable)
        {
            List<Tables> tables = new List<Tables>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tables table = new Tables()
                {
                    tableId = (int)dr["TableID"],
                    reserved = (bool)dr["Reserved"],
                    employeeId = (int)dr["EmployeeID"],
                };
                tables.Add(table);
            }
            return tables;
        }
        public bool Reserved(int tafelNummer)
        {
            bool reserved = false;
            List<Tables> tables = GetAllTables();
            foreach(Tables t in tables)
            {
               
                if (tafelNummer == t.tableId)
                {
                    reserved = t.reserved;
                    return reserved;
                }
            }
            return reserved;
        }
    }
}
