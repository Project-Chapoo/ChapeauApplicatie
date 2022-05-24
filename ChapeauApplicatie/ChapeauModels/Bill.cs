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
        public double SubTotalPrice 
        {
            get 
            {
                return TotalPrice - SixPercentTaxPrice - TwentyOnePercentTaxPrice;
            } 
        }
        public double SixPercentTaxPrice
        {
            get
            {
                const int sixPercentFactor = 6;
                const int hunderdAndSixPercentFactor = 106;
                double sixPercentPrice = 0;
                foreach (BillItem b in billItems)
                {
                    if (b.Alcohol)
                    {
                        continue;
                    }
                    else
                    {
                        sixPercentPrice += (b.Price / hunderdAndSixPercentFactor) * sixPercentFactor;
                    }
                }
                return sixPercentPrice;
            }
        }
        public double TwentyOnePercentTaxPrice
        {
            get
            {
                const int twentyOnePercentFactor = 21;
                const int hunderdAndTwentyOnePercentFactor = 121;
                double twentyOnePercentPrice = 0;
                foreach (BillItem b in billItems)
                {
                    if (!b.Alcohol)
                    {
                        continue;
                    }
                    else
                    {
                        twentyOnePercentPrice += (b.Price / hunderdAndTwentyOnePercentFactor) * twentyOnePercentFactor;
                    }
                }
                return twentyOnePercentPrice;
            }
        }
        public double TotalPrice { get; set; }

        public Bill(int tableID, int orderID, string employeeFirstName, string employeeLastName)
        {
            TableID = tableID;
            EmployeeFullName = employeeFirstName + " " + employeeLastName;
            OrderID = orderID;
            billItems = new List<BillItem>();
        }

        public void AddTip(double tip)
        {
            billItems.Add(new BillItem(billItems.Count, 1, "fooi", tip, false));
        }

        public Bill()
        {
        }
    }
}
