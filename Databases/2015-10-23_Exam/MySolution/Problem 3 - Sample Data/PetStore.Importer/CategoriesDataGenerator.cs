namespace PetStore.Importer
{
    using PetStore.Data;

    public class CategoriesDataGenerator : IDataGenerator
    {
        public void GenerateData(Data.PetStoreEntities data, IRandomGenerator random, int count)
        {          
            for (int i = 0; i < count; i++)
            {
                var categoryName = random.GetRandomString(random.GetRandomNumber(5, 20));

                var category = new Category
                {
                    Name = categoryName
                };

                data.Categories.Add(category);
            }
        }
    }
}
