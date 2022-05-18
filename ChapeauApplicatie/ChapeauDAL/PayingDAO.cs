using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using ChapeauModels;

namespace ChapeauDAL
{
    public class PayingDAO : BaseDao
    {
        public List<Bill> GetBills()
        {
            string query = "Get FROM [dbo].[Order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bill = new List<Bill>();

            foreach(DataRow dr in dataTable.Rows)
            {
                Bill billItem = new Bill();
                {

                }
                bill.Add(billItem);
            }
            return bill;
        }

        public void AddNewBill(Bill bill)
        {
            string query = "INSERT INTO [dbo].[Receipt](EmployeeID, ReservationID, TableID, Commentary, DateAndTime) VALUES(@EmployeeID, @ReservationID, @TableID, @Commentary, @DateAndTime)";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = bill.EmployeeID } , 
                new SqlParameter("@ReservationID", SqlDbType.Int) { Value = bill.ReservationID }, 
                new SqlParameter("@TableID", SqlDbType.Int) { Value = bill.TableID } , 
                new SqlParameter("@Commentary", SqlDbType.VarChar) { Value = bill.Commentary }, 
                new SqlParameter("@DateAndTime", SqlDbType.DateTime) { Value = bill.DateAndTime }
            };
            
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
