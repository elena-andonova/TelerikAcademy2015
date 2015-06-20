using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
//     All accounts have customer, balance and interest rate (monthly based).

//    Deposit accounts are allowed to deposit and with draw money.
//    Loan and mortgage accounts can only deposit money.

//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
    public abstract class Account
    {
        private Customer customerName;
        private double balance;
        private double interestRate;
        private uint months;

        public Account(Customer customerName, double interest)
        {
            this.CustomerName = customerName;
            this.Balance = 0;
            this.interestRate = interest;
            this.Months = 0;
        }

        public double Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }
        public uint Months
        {
            get { return this.months; }
            set { this.months = value; }
        }
        public double InterestRate
        {
            get { return this.interestRate; }
            private set 
            { this.interestRate = value; }
        }

        public Customer CustomerName
        {
            get { return this.customerName; }
            private set { this.customerName = value; }
        }

        public virtual double CalculateInterestAmount()
        {
            return this.InterestRate * this.Months;
        }
        public virtual void Deposit(double money)
        {
            this.Balance += money;
        }

        public override string ToString()
        {
            return string.Format(@"
Customer: {0}
Balance: {1}
Interest Rate: {2}
Months: {3}
Interest Amount: {4}",
           this.CustomerName.Name, this.Balance, this.InterestRate, this.Months, CalculateInterestAmount());
        }

    }
}
