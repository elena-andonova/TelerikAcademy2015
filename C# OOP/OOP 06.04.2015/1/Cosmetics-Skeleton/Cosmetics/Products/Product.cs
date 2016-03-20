using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cosmetics.Products
{
    /*All products should implement the IProduct interface. 
     * Minimum product name’s length is 3 symbols and maximum is 10 symbols. 
     * The error message should be "Product name must be between {min} and {max} symbols long!". 
     * Minimum brand name’s length is 2 symbols and maximum is 10 symbols. 
     * The error message should be "Product brand must be between {min} and {max} symbols long!". 
     * Gender type can be “Men”, “Women” or “Unisex”. */
    public abstract class Product : IProduct
    {
        private const int ProductMinNameLength = 3;
        private const int ProductMaxNameLength = 10;

        private const int ProductMinBrandLength = 2;
        private const int ProductMaxBrandLength = 10;

        private string name;
        private string brand;
        private decimal price;
        private Common.GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        public string Name
        {
            get { return this.name; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(Common.GlobalErrorMessages.InvalidStringLength,
                    "Product name", ProductMinNameLength, ProductMaxNameLength));
                Validator.CheckIfStringLengthIsValid(value, ProductMaxNameLength, ProductMinNameLength, string.Format(Common.GlobalErrorMessages.InvalidStringLength, 
                    "Product name", ProductMinNameLength, ProductMaxNameLength));
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(Common.GlobalErrorMessages.InvalidStringLength,
                     "Product brand", ProductMinBrandLength, ProductMaxBrandLength));
                Validator.CheckIfStringLengthIsValid(value, ProductMaxBrandLength, ProductMinBrandLength, string.Format(Common.GlobalErrorMessages.InvalidStringLength,
                     "Product brand", ProductMinBrandLength, ProductMaxBrandLength));
                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                Validator.CheckIfNull(value, string.Format(Common.GlobalErrorMessages.ObjectCannotBeNull, this.GetType().Name));
                this.price = value;
            }
        }

        public Common.GenderType Gender
        {
            get { return this.gender; }
            protected set
            {
                if ((value != Common.GenderType.Men) && (value != Common.GenderType.Women) && (value != Common.GenderType.Unisex))
                {
                    throw new ArgumentException(@"Gender type can only be ""Men"", ""Women"" or ""Unisex""!");
                }
                this.gender = value;
            }
        }

        public virtual decimal CalculatingPrice()
        {
            int number = 1;
            return this.Price * number;
        }
        public virtual string Print()
        {
            return string.Format
(@"- {0} - {1}:
  * Price: ${2}
  * For gender: {3}",
this.Brand, this.Name, this.Price, this.Gender);
        }
    }
}
