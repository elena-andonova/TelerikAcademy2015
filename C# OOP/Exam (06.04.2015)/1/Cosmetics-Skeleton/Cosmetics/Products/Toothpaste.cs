using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    /*All toothpastes should implement the IToothpaste interface. 
     * Ingredients should be represented as text, joined in their order of addition, separated by “, “ (comma and space). 
     * Each ingredient name’s length should be between 4 and 12 symbols, inclusive. 
     * The error message should be "Each ingredient must be between {min} and {max} symbols long!".*/
    public class Toothpaste : Product, Contracts.IProduct, Contracts.IToothpaste
    {
        private const int IngredientMinLength = 4;
        private const int IngredientMaxLength = 12;

        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, Common.GenderType gender, IList<string> ingredients)
            :base(name, brand, price, gender)
        {
            this.Ingredients = GetIngredients(ingredients);
        }
        public string Ingredients
        {
            get { return this.ingredients; }
            protected set
            {
                this.ingredients = value;
            }
        }

        public override string Print()
        {
            //TODO
            return string.Format(
@"{0}
  * Ingredients: {1}",
        base.Print(), this.Ingredients);
        }

        public string GetIngredients(IList<string> ingredients)
        {
            string[] getIngrArr = ingredients.ToArray();
            foreach (var ingr in getIngrArr)
            {
                Common.Validator.CheckIfStringLengthIsValid(ingr, IngredientMaxLength, IngredientMinLength, 
                    string.Format(Common.GlobalErrorMessages.InvalidStringLength, "Each ingredient", IngredientMinLength, IngredientMaxLength));
            }
            string validatedString = string.Join(", ", getIngrArr);
            return validatedString;
        }
    }
}
