using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    //Problem 5. Generic class

    //Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    //Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
    //Check all input parameters to avoid accessing elements at invalid positions.

    //    Problem 6. Auto-grow
    //    Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

    //Problem 7. Min and Max
    //    Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
    //    You may need to add a generic constraints for the type T.


    class GenericList<T> : IEnumerable<T>
    {
        private const int DefaultCapacity = 4;
        private T[] items;
        public int Count { get; set; }
        public int Capacity { get; set; }

        public GenericList()
        {
            this.Capacity = DefaultCapacity;
            this.items = new T[this.Capacity];
        }

        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }

        //adding element
        public void Add(T item)
        {
            if (this.Count == this.Capacity)
            {
                var oldItems = this.items;
                this.Capacity *= 2;
                this.items = new T[this.Capacity];
                Array.Copy(oldItems, this.items, this.Count);
            }

            this.items[this.Count] = item;
            ++this.Count;
        }
        //inserting element at given position
        public void InsertAtPosition(T item, int position)
        {
            this.items[position] = item;
        }

        //accessing element by index
        public T AccessAtPosition(int position)
        {
            return this.items[position];
        }

        //removing element by index
        public void RemoveAtPosition(int position)
        {
            this.items[position] = default(T);
        }

        //clearing the list
        public void ClearAll()
        {
            int index = 0;
            foreach (var item in this.items)
            {
                RemoveAtPosition(index);
                ++index;
            }
        }

        //finding element by its value
        public int FindElementByValue(T value)
        {
            int position = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(value))
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
        
        //ToString()??
        public override string ToString()
        {
            return string.Format("{0}", this.items);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                var item = this.items[i];
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
