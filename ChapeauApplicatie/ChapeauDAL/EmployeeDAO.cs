using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModels;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDao
    {
        public List<EmployeeModel> GetAllEmployees()
        {
            string query = "SELECT FirstName, LastName, EmployeeFunction, LoginPassword, LoginUsername, [Admin] FROM Employee";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<EmployeeModel> ReadTables(DataTable dataTable)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    firstName = (string)dr["FirstName"].ToString(),
                    lastName = (string)dr["LastName"].ToString(),
                    employeeFunction = (string)dr["EmployeeFunction"].ToString(),
                    loginPassword = (string)dr["LoginPassword"].ToString(),
                    loginUsername = (string)dr["LoginUsername"].ToString(),
                    isAdmin = (bool)dr["Admin"],
                };
                employees.Add(employee);
            }
            return employees;
        }
        public bool CheckEmployeeLogIn(string checkPassword)
        {
            List<EmployeeModel> employees = GetAllEmployees();

            foreach(EmployeeModel e in employees)
            {
                if(checkPassword == e.loginPassword)
                    return true;
            }
            return false;
        }
    }
}
