namespace PetStore.Importer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PetStore.Data;

    public class PetsDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var petsPerSpecies = 50;

            var speciesId = data.Species.Select(s => s.CountryId).ToList();
            //var speciesNumbers = speciesId.Count();
            var speciesNumbers = count / petsPerSpecies;

            for (int i = 0; i < speciesNumbers; i++)
            {
                var singleSpeciesId = speciesId[i];
                var fromIndex = i * petsPerSpecies;
                var toIndex = fromIndex + petsPerSpecies;

                for (int j = fromIndex; j < toIndex; j++)
                {
                    var dateOfBirth = random.GetRandomDate(new DateTime(2010, 1, 1, 0, 0, 0), DateTime.Now.AddDays(-60));
                    var price = (decimal)random.GetRandomNumber(5, 2500);
                    var color = random.GetRandomNumber(1, 4);

                    var pet = new Pet
                    {
                        SpeciesId = singleSpeciesId,
                        DateOfBirth = dateOfBirth,
                        Price = price,
                        ColorId = color
                    };
                    data.Pets.Add(pet);

                    //if (j % 100 == 0)
                    //{
                    //    data.SaveChanges();
                    //    data.Dispose();
                    //    data = new PetStoreEntities();
                    //}
                }
            }
        }
    }
}
