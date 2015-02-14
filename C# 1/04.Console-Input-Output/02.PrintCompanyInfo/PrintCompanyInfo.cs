using System;


namespace _02.PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.WriteLine("Please enter the following information.");
            Console.Write("Company name: ");
            string compName = Console.ReadLine();
            Console.Write("Company address: ");
            string compAdd = Console.ReadLine();
            Console.Write("Phone number: ");
            string compPhone = Console.ReadLine();
            Console.Write("Fax number: ");
            string compFax = Console.ReadLine();
            Console.Write("Web site: ");
            string compWeb = Console.ReadLine();
            Console.Write("Manager first name: ");
            string manFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string manLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string manAge = Console.ReadLine();
            Console.Write("Manager phone: ");
            string manPhone = Console.ReadLine();
            Console.WriteLine(@"
{0}
Address: {1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, tel. {8})",
compName, compAdd, compPhone, compFax, compWeb, manFirstName, manLastName, manAge, manPhone);
        }
    }
}
