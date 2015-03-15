using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
    //Create an instance of the GSM class.
    //Add few calls.
    //Display the information about the calls.
    //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    //Remove the longest call from the history and calculate the total price again.
    //Finally clear the call history and print it.

    static class GSMCallHistoryTest
    {
        public static void DisplayCalls()
        {
            Battery myBattery = new Battery("Sony", 8, 7, BatteryType.LiIon);
            Display myDisplay = new Display(5.2, 204650);
            GSM myGSM = new GSM("Sony Experia Arc", "Sony Ericsson", 560, "Me", myBattery, myDisplay);
            
            myGSM.AddCall(new Call(DateTime.Parse("21.03.2015 23:34"), 0889384859, 4354));

            foreach (var call in myGSM.CallHistory)
            {
                Console.WriteLine(@" 
CALL HISTORY 
-----------------------------------
Date and time of the call: {0};
Dialed number: {1};   
Duration: {2} seconds
-----------------------------------
                ", call.CallDateTime, call.DialedPhoneNumber, call.Duration);
            }

        }
    }
}
