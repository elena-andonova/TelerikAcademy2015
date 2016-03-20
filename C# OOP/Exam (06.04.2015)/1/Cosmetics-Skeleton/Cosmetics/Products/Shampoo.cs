using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    /*All shampoos should implement the IShampoo interface. Shampoo’s price is given per milliliter.
     * Usage type can be “EveryDay” or “Medical”.*/
    public class Shampoo : Product, IProduct, IShampoo
    {
        private uint milliliters;
        private Common.UsageType usage;

        public Shampoo(string name, string brand, decimal price, Common.GenderType gender, uint milliliters, Common.UsageType usage)
            :base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
            protected set
            {
                base.Price = value;
            }
        }
        public uint Milliliters
        {
            get { return this.milliliters; }
            protected set
            {
                Common.Validator.CheckIfNull(value, string.Format(Common.GlobalErrorMessages.ObjectCannotBeNull, this.GetType().Name));
                this.milliliters = value;
            }
        }

        public Common.UsageType Usage 
        { 
            get { return this.usage;}
            protected set
            {
                if (value != Common.UsageType.EveryDay && value != Common.UsageType.Medical)
                {
                    throw new ArgumentException(@"Usage type can only be ""EveryDay"" or ""Medical""!");
                }
                this.usage = value;
            }
        }

        public override string Print()
        {
            //TODO
            return string.Format(
@"{0}
  * Quantity: {1} ml
  * Usage: {2}", 
              base.Print(), this.Milliliters, this.Usage);
        }

    }
}
