namespace PetStore.Importer
{
    using System.Collections.Generic;
    using System.Linq;
    using PetStore.Data;

    public class SpeciesDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var allAddedSpecies = new List<Species>();

            var uniqueNames = new HashSet<string>();
            while (uniqueNames.Count < count)
            {
                uniqueNames.Add(random.GetRandomString(random.GetRandomNumber(5, 50)));
            }

            foreach (var uniqueName in uniqueNames)
            {
                var species = new Species { Name = uniqueName };
                allAddedSpecies.Add(species);
            }

            var speciesPerCountry = 5;

            var countryIds = data.Countries.Select(c => c.CountryId).ToList();
            //var countryNumbers = countryIds.Count();
            var countryNumbers = 20;

            for (int i = 0; i < countryNumbers; i++)
            {
                var countryId = countryIds[i];
                var fromIndex = i * speciesPerCountry;
                var toIndex = fromIndex + speciesPerCountry;

                for (int j = fromIndex; j < toIndex; j++)
                {
                    allAddedSpecies[j].CountryId = countryId;
                    data.Species.Add(allAddedSpecies[j]);
                }
            }
        }
    }
}
