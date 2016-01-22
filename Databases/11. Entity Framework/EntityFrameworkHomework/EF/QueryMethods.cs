using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public static class QueryMethods
    {
        public static ICollection<string> FindAllCustomersWithOrdersFrom1997ShippedToCanada()
        {
            var db = new NorthwindEntities();
            var orders = db.Orders
                .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                .Select(o => o.Customer.ContactName)
                .Distinct()
                .ToList();

            // ???? db.Dispose();
            return orders;
        }

        public static ICollection<string> FindAllCustomersWithOrdersFrom1997ShippedToCanadaWithNativeSqlQuery()
        {
            var db = new NorthwindEntities();
            string nativeSqlQuery = @"
SELECT DISTINCT c.ContactName AS Name
FROM ORDERS o
JOIN CUSTOMERS c
	ON c.CustomerID = o.CustomerID
WHERE DATEPART(YEAR, OrderDate) = 1997 
	AND ShipCountry='Canada'";

            var ordersByQuery = db.Database.SqlQuery<string>(nativeSqlQuery).ToList();

            return ordersByQuery;
        }

        public static ICollection<Order> FindAllSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            var db = new NorthwindEntities();
            var sales = db.Orders
                        .Where(o => o.ShipRegion.ToLower() == region.ToLower() && (startDate < o.ShippedDate && o.ShippedDate < endDate))
                        .Select(o => o)
                        .ToList();

            return sales;
        }
    }
}
