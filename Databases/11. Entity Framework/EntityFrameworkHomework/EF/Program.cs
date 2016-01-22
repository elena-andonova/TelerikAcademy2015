using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class Program
    {
        static void Main()
        {
            var customersWithOrders = QueryMethods.FindAllCustomersWithOrdersFrom1997ShippedToCanada();
            //var customersWithOrders = QueryMethods.FindAllCustomersWithOrdersFrom1997ShippedToCanadaWithNativeSqlQuery();

            Console.WriteLine("-- All customers who have orders made in 1997 and shipped to Canada are: {0} --", customersWithOrders.Count());
            foreach (var cu in customersWithOrders)
            {
                Console.WriteLine(cu);
            }
            Console.WriteLine();

            var sales = QueryMethods.FindAllSalesByRegionAndPeriod("RJ", new DateTime(1996, 07, 10), new DateTime(2015, 10, 10));
            Console.WriteLine(sales.Count());

            //NOTE: First change Initial catalog in App.config
            //NorthwindTwinEntities.CreateTwin();

        }
    }
}
