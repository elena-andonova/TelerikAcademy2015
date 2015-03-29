using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
/*Problem 3. Range Exceptions
    Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
    Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
*/
    public class InvalidRangeException<T> : ApplicationException
    {
        private T startRange;
        private T endRange;
        public InvalidRangeException(string msg, T startRange, T endRange)
            :base(msg)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public T StartRange
        {
            get { return this.startRange; }
            set { this.startRange = value; }
        }

        public T EndRange
        {
            get { return this.endRange; }
            set { this.endRange = value; }
        }
    }
}
