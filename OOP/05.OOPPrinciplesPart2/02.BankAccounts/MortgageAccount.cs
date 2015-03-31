using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer cu, double interest)
            : base(cu, interest)
        {
        }
        public override double CalculateInterestAmount()
        {
            if (this.Months <= 12 && this.CustomerName is Company)
            {
                return base.CalculateInterestAmount() / 2;
            }
            if (this.Months <= 6 && this.CustomerName is Individual)
            {
                return base.CalculateInterestAmount() / 2;
            }
            else
            {
                return base.CalculateInterestAmount();
            }
        }
    }
}
