using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    //display characteristics (size and number of colors).
    public class Display
    {
        public const double minSize = 2;
        public const double maxSize = 7;
        public const uint minNumberOfColors = 2;
        
        private double size;
        private uint numberOfColors;

        public Display(double size, uint numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get { return this.size; }
            set 
            { 
                if (value < minSize || value > maxSize)
                {
                    throw new ArgumentOutOfRangeException("The size of the display must be between 2 and 7 inches!");
                }
                if (value == 0)
                {
                    value = minSize;
                }

                this.size = value; 
            }
        }

        public uint NumberOfColors
        {
            get { return this.numberOfColors; }
            set 
            { 
                if (value < minNumberOfColors)
                {
                    throw new ArgumentOutOfRangeException("The number of colors of the display cannot be less than 3!");
                }
                if (value == 0)
                {
                    value = minNumberOfColors;
                }
                this.numberOfColors = value; 
            }
        }
    }
}
