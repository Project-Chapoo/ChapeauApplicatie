using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModels
{
    public class Bill
    {
        public int TableID { get; }
        public string EmployeeFullName { get; set; }
        public int OrderID { get; }
        public List<BillItem> billItems { get; set; }
        public double TotalPrice { get; set; }
        public double SixPercentTaxPrice { get; set; }
        public double TwentyOnePercentTaxPrice { get; set; }
        public double TotalTaxPrice { get; set; }
        public double Tip { get; set; }

        public Bill(int tableID, int orderID, string employeeFirstName, string employeeLastName)
        {
            TableID = tableID;
            EmployeeFullName = employeeFirstName + " " + employeeLastName;
            OrderID = orderID;
            billItems = new List<BillItem>();
        }

        public Bill()
        {
        }
    }
}
