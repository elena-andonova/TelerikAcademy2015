using PetStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Importer
{
    public interface IDataGenerator
    {
        void GenerateData(PetStoreEntities data, IRandomGenerator random, int count);
    }
}
