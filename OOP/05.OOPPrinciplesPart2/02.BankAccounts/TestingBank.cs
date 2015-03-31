using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class TestingBank
    {
        static void Main()
        {
            Bank DSK = new Bank("DSK Bank");
            Individual person1 = new Individual("Asya Dimitrova");
            Company company1 = new Company("Monsters LTD");

            DepositAccount da1 = new DepositAccount(person1, 5);
            da1.Deposit(1000);
            Console.WriteLine(da1.GetType().Name + da1.ToString());
            Console.WriteLine();

            LoanAccount la1 = new LoanAccount(company1, 10);            
            Console.WriteLine(la1.GetType().Name + la1.ToString());
            Console.WriteLine();
            Console.WriteLine("---> After 5 months");
            la1.Months = 5;
            Console.WriteLine(la1.GetType().Name + la1.ToString());
            Console.WriteLine();

            MortgageAccount ma1 = new MortgageAccount(person1, 15);
            Console.WriteLine(ma1.GetType().Name + ma1.ToString());            
            Console.WriteLine("---> After 3 months");
            ma1.Months = 3;
            Console.WriteLine(ma1.GetType().Name + ma1.ToString());
            Console.WriteLine("---> After 6 months");
            ma1.Months = 6;
            Console.WriteLine(ma1.GetType().Name + ma1.ToString());
        }
    }
}
