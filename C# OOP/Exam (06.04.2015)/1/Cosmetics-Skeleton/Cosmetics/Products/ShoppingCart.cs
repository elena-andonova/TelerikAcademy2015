using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    /*There is also a shopping cart. Products can be added or removed from it. 
     * The same product can be added to the shopping cart more than once. 
     * The shopping cart can calculate the total price of all products in it.
     * Shopping cart should implement the IShoppingCart interface. 
     * Adding the same product more than once is allowed. Do not check if the product exists, when removing it from the shopping cart.*/
    public class ShoppingCart : IShoppingCart
    {
        private List<Product> productsInCart;

        public ShoppingCart()
        {
            this.ProductsInCart = new List<Product> { };
        }
        public List<Product> ProductsInCart
        {
            get { return this.productsInCart; }
            protected set { this.productsInCart = value; }
        }
        public void AddProduct(IProduct product)
        {
            Product productToAdd = product as Product;
            this.ProductsInCart.Add(productToAdd);
        }

        public void RemoveProduct(IProduct product)
        {
            Product productToRemove = product as Product;
            this.ProductsInCart.Remove(productToRemove);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.ProductsInCart.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TotalPrice()
        {
            //TODO
            decimal total = 0;
            foreach (var pr in this.ProductsInCart)
            {
                total += pr.CalculatingPrice();
            }
            return total;
        }
    }
}
