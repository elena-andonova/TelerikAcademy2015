namespace PetStore.Importer
{
    using System.Collections.Generic;
    using System.Linq;
    using PetStore.Data;

    public class ProductsDataGenerator : IDataGenerator
    {
        public void GenerateData(Data.PetStoreEntities data, IRandomGenerator random, int count)
        {
            var productsPerCategory = 400;

            var categoriesId = data.Categories.Select(c => c.CategoryId).ToList();
            //var categoriesNumbers = categoriesId.Count();
            var categoriesNumbers = count / productsPerCategory;

            var allSpecies = data.Species.Select(s => s).ToList();
            var speciesCount = allSpecies.Count() - 1;

            //var speciesPerProduct = random.GetRandomNumber(2, 10);
            //var speciesForProduct = new List<Species>();
            //for (int k = 0; k < speciesPerProduct; k++)
            //{
            //    var index = random.GetRandomNumber(0, speciesCount);
            //    speciesForProduct.Add(allSpecies[index]);
            //}

            for (int i = 0; i < categoriesNumbers; i++)
            {
                var categoryId = categoriesId[i];
                var fromIndex = i * productsPerCategory;
                var toIndex = fromIndex + productsPerCategory;

                for (int j = fromIndex; j < toIndex; j++)
                {
                    var name = random.GetRandomString(random.GetRandomNumber(5, 25));
                    var price = (decimal)random.GetRandomNumber(10, 1000);

                    var speciesPerProduct = random.GetRandomNumber(2, 10);
                    var speciesForProduct = new List<Species>();
                    for (int k = 0; k < speciesPerProduct; k++)
                    {
                        var index = random.GetRandomNumber(0, speciesCount);
                        speciesForProduct.Add(allSpecies[index]);
                    }

                    var product = new Product
                    {
                        Name = name,
                        Price = price,
                        CategoryId = categoryId,
                        Species = speciesForProduct
                    };

                    data.Products.Add(product);

                    //        if (j % 100 == 0)
                    //        {
                    //            data.SaveChanges();
                    //            data.Dispose();
                    //            data = new PetStoreEntities();
                    //        }
                    //    }
                }
            }
        }
    }
}