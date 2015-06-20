using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Extensions
{
    //Problem 2. IEnumerable extensions
    //Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

    public static class IEnumerableExtensions
    {
        public static dynamic Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);            
            foreach (T element in collection)
            {
                sum += element;
            }
            return sum;
        }

        public static dynamic Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;
            foreach (T element in collection)
            {
                product *= element;
            }
            return product;
        }

        public static dynamic Min<T>(this IEnumerable<T> collection)
                       // where T : IComparable<T>
        {
            dynamic min = collection.ElementAt(0);
            for (int i = 1; i < collection.Count(); i++)
            {
                if (collection.ElementAt(i) < min)
                {
                    min = collection.ElementAt(i);
                }
            }
            return min;
        }

        public static dynamic Max<T>(this IEnumerable<T> collection)
        // where T : IComparable<T>
        {
            dynamic max = collection.ElementAt(0);
            for (int i = 1; i < collection.Count(); i++)
            {
                if (collection.ElementAt(i) > max)
                {
                    max = collection.ElementAt(i);
                }
            }
            return max;
        }

        public static dynamic Average<T>(this IEnumerable<T> collection)
        // where T : IComparable<T>
        {
            dynamic average = collection.Sum() / collection.Count();
            return average;
        }
    }
}
