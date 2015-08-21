using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    //A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
    public class Bank
    {
        private string name;
        private List<LoanAccount> loanAccounts;
        private List<MortgageAccount> mortgageAccounts;
        private List<DepositAccount> depositAccounts;

        public Bank(string name)
        {
            this.Name = name;
            this.LoanAccounts = new List<LoanAccount> { };
            this.MortgageAccounts = new List<MortgageAccount> { };
            this.DepositAccounts = new List<DepositAccount> { };
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public List<LoanAccount> LoanAccounts
        {
            get { return this.loanAccounts; }
            set { this.loanAccounts = value; }
        }
        public List<MortgageAccount> MortgageAccounts
        {
            get { return this.mortgageAccounts; }
            set { this.mortgageAccounts = value; }
        }
        public List<DepositAccount> DepositAccounts
        {
            get { return this.depositAccounts; }
            set { this.depositAccounts = value; }
        }

    }
}
