namespace PetStore.Importer
{
    using System;

    public interface IRandomGenerator
    {
        int GetRandomNumber(int min, int max);

        string GetRandomString(int length);

        DateTime GetRandomDate(DateTime? after = null, DateTime? before = null);
    }
}
