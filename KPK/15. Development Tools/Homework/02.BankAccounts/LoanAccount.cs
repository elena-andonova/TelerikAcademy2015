using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer cu, double interest)
            : base(cu, interest)
        {
        }
        public override double CalculateInterestAmount()
        {
            if (this.Months <= 2 && this.CustomerName is Company)
            {
                return base.CalculateInterestAmount() * 0;
            }
            if (this.Months <= 3 && this.CustomerName is Individual)
            {
                return base.CalculateInterestAmount() * 0;
            }
            else
            {
                return base.CalculateInterestAmount();
            }
        }
    }
}
