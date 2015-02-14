using System;


namespace AgeInTenYears
{
    class AgeInTenYears
    {
        static void Main()
        {
            int BirthDay = 28;
            int BirthMonth = 10;
            int BirthYear = 1990;
            int CurrDay = int.Parse(DateTime.Now.ToString("dd"));
            int CurrMonth = int.Parse(DateTime.Now.ToString("MM"));
            int CurrYear = int.Parse(DateTime.Now.ToString("yyyy"));
            int CurrAge;
            int AgeInTenYears;

            if ((CurrMonth < BirthMonth) || ((CurrMonth == BirthMonth) && (CurrDay < BirthDay)))
            {
                CurrAge = CurrYear - BirthYear - 1;
                AgeInTenYears = CurrAge + 10;
            }
            else 
            {
                CurrAge = CurrYear - BirthYear;
                AgeInTenYears = CurrAge + 10;
            }
            
            Console.WriteLine("Now my age is " + CurrAge);
            Console.WriteLine("After ten years my age will be " + AgeInTenYears);                 
        }
    }
}
