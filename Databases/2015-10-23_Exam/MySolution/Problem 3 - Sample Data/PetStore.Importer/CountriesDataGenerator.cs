namespace PetStore.Importer
{
    using System.Collections.Generic;
    using PetStore.Data;

    public class CountriesDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var uniqueCountries = new HashSet<string>();

            while (uniqueCountries.Count < count)
            {
                uniqueCountries.Add(random.GetRandomString(random.GetRandomNumber(5, 50)));
            }

            foreach (var uniqueCountry in uniqueCountries)
            {
                var country = new Country { Name = uniqueCountry };
                data.Countries.Add(country);
            }
        }
    }
}
