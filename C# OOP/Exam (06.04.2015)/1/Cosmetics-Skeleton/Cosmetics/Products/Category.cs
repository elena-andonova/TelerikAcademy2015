using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    /*There are categories of products. Each category has name and products can be added or removed. The same product can be added to a category more than once.
        Categories should implement ICategory. Adding the same product to one category more than once is allowed. 
     * Minimum category name’s length length is 2 symbols and maximum is 15 symbols. 
     * The error message should be "Category name must be between {min} and {max} symbols long!". 
     * Products in category should be sorted by brand in ascending order and then by price in descending order. 
     * When removing product from category, if the product is not found, the error message should be "Product {product name} does not exist in category {category name}!". 
     * Category’s print method should return text in the following format:*/
    public class Category : ICategory
    {
        public const int CategoryMinNameLength = 2;
        public const int CategoryMaxNameLength = 15;

        private string name;
        private List<Product> productsInCategory;
        public Category(string name)
        {
            this.Name = name;
            this.ProductsInCategory = new List<Product> { };
        }
        public string Name
        {
            get { return this.name; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(Common.GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name + " name"));
                Validator.CheckIfStringLengthIsValid(value, CategoryMaxNameLength, CategoryMinNameLength, string.Format(Common.GlobalErrorMessages.InvalidStringLength, this.GetType().Name + " name",
                                                        CategoryMinNameLength, CategoryMaxNameLength));
                this.name = value;
            }
        }

        public List<Product> ProductsInCategory
        {
            get { return this.productsInCategory; }
            protected set { this.productsInCategory = value; }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Product productToAdd = cosmetics as Product;
            this.ProductsInCategory.Add(productToAdd);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Product productToRemove = cosmetics as Product;
            if (this.ProductsInCategory.Contains(productToRemove))
            {
                this.ProductsInCategory.Remove(productToRemove);
            }
            else
            {
                Console.WriteLine("Product {0} does not exist in category {1}!", productToRemove, this.Name);
            }            
        }

        public string Print()
        {
            //TODO
            var sortedProducts = this.ProductsInCategory.OrderBy(pr => pr.Brand).ThenByDescending(pr => pr.Price).Select(pr => pr.Print());
            StringBuilder productsPrint = new StringBuilder();
            foreach (var pr in sortedProducts)
            {
                productsPrint.AppendLine(pr);
            }
            string forPrint = productsPrint.ToString().TrimEnd();
            

            if (this.ProductsInCategory.Count == 0)
            {
                return string.Format(
@"{0} category - {1} products in total",
      this.Name, this.ProductsInCategory.Count);
            }

            else if (this.ProductsInCategory.Count == 1)
            {
                return string.Format(
@"{0} category - {1} product in total
{2}",
this.Name, this.ProductsInCategory.Count, forPrint);
            }
            else
            {
                return string.Format(
    @"{0} category - {1} products in total
{2}",
        this.Name, this.ProductsInCategory.Count, forPrint);
            }

        }
    }
}
