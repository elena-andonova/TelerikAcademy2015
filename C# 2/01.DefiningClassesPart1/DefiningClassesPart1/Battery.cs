using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    //battery characteristics (model, hours idle and hours talk)
    //Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCD,
        Default
    }
    public class Battery
    {
        public const uint minHoursIdle = 5;
        public const uint minHoursTalk = 4;

        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        private BatteryType batType;

        public Battery(string model, uint hoursIdle, uint hoursTalk, BatteryType batType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatType = batType;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public uint HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            { 
                if (value < minHoursIdle)
                {
                    throw new ArgumentOutOfRangeException("Hours Idle cannot be less than 5 hours!");
                }
                this.hoursIdle = value;
            }
        }

        public uint HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value < minHoursTalk)
                {
                    throw new ArgumentOutOfRangeException("Hours Talk cannot be less than 4 hours!");
                }
                this.hoursTalk = value; 
            }
        }

        public BatteryType BatType
        {
            get { return this.batType; }
            set { this.batType = value; }
        }

    }
}
