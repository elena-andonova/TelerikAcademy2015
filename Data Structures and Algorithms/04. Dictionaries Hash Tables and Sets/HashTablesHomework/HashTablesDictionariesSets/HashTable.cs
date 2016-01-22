using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesDictionariesSets
{
    // 4. Implement the data structure hash table in a class HashTable<K,T>. Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) 
    // with initial capacity of 16. When the hash table load runs over 75%, perform resizing to 2 times larger capacity. Implement the following methods and properties:

    //    Add(key, value)
    //    Find(key)->value
    //    Remove(key)
    //    Count
    //    Clear()
    //    this[]
    //    Keys

    // Try to make the hash table to support iterating over its elements with foreach.

    // Write unit tests for your class.
    public class HashTable<K, T> : IDictionary<K,T>
    {
        private LinkedList<KeyValuePair<K, T>>[] elements;
        private readonly int capacity = 16;
        private readonly double capacityPercantageToResize = 0.75;

        public void Add(K key, T value)
        {

        }


        public bool ContainsKey(K key)
        {
            throw new NotImplementedException();
        }

        public ICollection<K> Keys
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(K key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(K key, out T value)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> Values
        {
            get { throw new NotImplementedException(); }
        }

        public T this[K key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<K, T> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<K, T> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<K, T>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(KeyValuePair<K, T> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
