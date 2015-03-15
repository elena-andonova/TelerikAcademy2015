using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    //Write a class GSMTest to test the GSM class:
    //Create an array of few instances of the GSM class.
    //Display the information about the GSMs in the array.
    //Display the information about the static property IPhone4S.

    static class GSMTest
    {
        public static void DisplayInfo()
        {
            Battery battery1 = new Battery("Samsung", 8, 7, BatteryType.LiIon);
            Display display1 = new Display(5.6, 43536);
            Battery battery2 = new Battery("Alcatel", 10, 8, BatteryType.NiCD);
            Display display2 = new Display(6.1 , 215648);

            GSM[] GSMArray = new GSM[]
            {
                //new GSM("Sony Experia", "Sony"),
                new GSM("HTC Desire", "HTC", 450, "GF", battery1, display1),
                new GSM("Samsung Galaxy S4", "Samsung", 768, "FT", battery2, display2)
            };

            foreach (var GSMitem in GSMArray)
            {
                Console.WriteLine(GSMitem.ToString());
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }

    }
}
