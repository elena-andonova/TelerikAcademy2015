using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public abstract class Customer
    {
        private string name;
        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
