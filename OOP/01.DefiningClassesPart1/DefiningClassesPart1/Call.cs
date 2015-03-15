using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    //Create a class Call to hold a call performed through a GSM.
    //It should contain date, time, dialled phone number and duration (in seconds).

    public class Call
    {
        private const uint maxDuration = 3600;
        private DateTime callDateTime;
        private uint dialedPhoneNumber;
        private uint duration;

        public Call(DateTime callDateTime, uint dialedPhoneNumber, uint duration)
        {
            this.CallDateTime = callDateTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public DateTime CallDateTime
        {
            get { return this.callDateTime; }
            set { this.callDateTime = value; }
        }

        public uint DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public uint Duration
        {
            get { return this.duration; }
            set 
            {
                if (value > maxDuration)
                {
                    throw new ArgumentOutOfRangeException("The call duration cannot be more than 60min(3600sec)!");
                }
                this.duration = value; 
            }
        }

    }
}
