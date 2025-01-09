using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpplusSample.Utilities
{
    public class DataFiles
    {
        private Dictionary<string, string> Files { get; set; } = new Dictionary<string, string>();
        public DataFiles() {
            Files.Add("Northwind Orders", "NWOrders.csv");
            Files.Add("NorthWind Products", "NWProducts.csv");
            Files.Add("NorthWind Salesmen", "NWSalesmen.csv");
            Files.Add("OrderDetails", "OrderDetails.csv");
            Files.Add("Suppliers by City", "NWCitySuppliers.csv");
        }

        public string FileName(string key)
        {
            if (Files.ContainsKey(key))
            {
                return Files[key];
            }
            return null;
        }
    }
}
