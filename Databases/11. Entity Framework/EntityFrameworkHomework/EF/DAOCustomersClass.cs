namespace EF
{
    using System.Linq;

    public class DAOCustomersClass
    {
        static string AddNewCustomer(string companyName)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer newCustomer = new Customer
            {
                CompanyName = companyName
            };

            northwindEntities.Customers.Add(newCustomer);
            northwindEntities.SaveChanges();
            return newCustomer.CustomerID;
        }

        static void ModifyCompanyName(string customerId, string newCompanyName)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerId);
            customer.CompanyName = newCompanyName;
            northwindEntities.SaveChanges();
        }

        static void DeleteProduct(string customerId)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerId);
            northwindEntities.Customers.Remove(customer);
            northwindEntities.SaveChanges();
        }

        static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerId)
        {
            Customer customer = northwindEntities.Customers.FirstOrDefault(
                c => c.CustomerID == customerId);
            return customer;
        }
    }
}
