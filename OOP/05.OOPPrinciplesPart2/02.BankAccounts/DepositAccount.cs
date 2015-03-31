using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customerName, double interest)
            : base(customerName, interest)
        {
        }

        public override double CalculateInterestAmount()
        {
            if (this.Balance <= 1000 && this.Balance >= 0)
            {
                return base.CalculateInterestAmount() * 0;
            }
            else
            {
                return base.CalculateInterestAmount();
            }
        }
        public void WithDraw(double money)
        {
            if (money <= this.Balance)
            {
                this.Balance -= money;
            }
            else
            {
                throw new ArgumentException("Not enough money!");
            }
        }
    }
}
