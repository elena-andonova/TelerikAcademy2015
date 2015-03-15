using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Program
    {
        static void Main()
        {
            GSMTest.DisplayInfo();
            Console.WriteLine(GSM.IPhone4S.ToString());

            Battery myBattery = new Battery("Sony", 8, 7, BatteryType.LiIon);
            Display myDisplay = new Display(5.2, 204650);
            GSM myGSM = new GSM("Sony Experia Arc", "Sony Ericsson", 560, "Me", myBattery, myDisplay);

            Call newCall = new Call(DateTime.Parse("21.03.2015 23:34"), 0889384859, 4354);
            myGSM.AddCall(new Call(DateTime.Parse("21.03.2015 23:34"), 0889384859, 4354));
            Console.WriteLine(myGSM.CallHistory.Count);

            foreach (var call in myGSM.CallHistory)
            {
                Console.WriteLine("Date and time of the call: {0}; Dialed number: {1}; Duration: {2} seconds", call.CallDateTime, call.DialedPhoneNumber, call.Duration);
            }

        }
    }
}
