using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

/*
Implement the data structure hash table in a class HashTable<K,T>. Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. When the hash table load runs over 75%, perform resizing to 2 times larger capacity. Implement the following methods and properties:

  x Add(key, value) 
  x Find(key)->value
  x Remove(key)
  x Count
  x Clear()
  x this[]
  x Keys

Try to make the hash table to support iterating over its elements with foreach.

Write unit tests for your class.
*/
namespace _4.ImplementHashTable
{
    public class HashTable<K,V> : IEnumerable<KeyValuePair<K,V>>
    {
        private LinkedList<KeyValuePair<K, V>>[] internalCollection;
        private ICollection<K> keysHashSet;
        private int count; 

        public HashTable(int size)
        {
            this.internalCollection = new LinkedList<KeyValuePair<K, V>>[size];
            keysHashSet = new HashSet<K>();
            this.count = 0;
        }

        public HashTable() : this(16)
        {
        }

        public ICollection<K> Keys()
        {
            return this.keysHashSet;
        }

        public void Clear()
        {
            this.internalCollection = new LinkedList<KeyValuePair<K, V>>[16];
            this.keysHashSet = new HashSet<K>();
            this.count = 0;
        }

        public int Count { get; set; }
        
        public void Add(K key, V value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("Key cannot be null!");
            }

            this.Resize();
            int ind = this.GetIndex(key);

            if (this.internalCollection[ind] == null)
            {
                this.internalCollection[ind] = new LinkedList<KeyValuePair<K, V>>();
                this.Count++;
            }
            if (this.internalCollection[ind].Any(x=>x.Key.Equals(key)))
            {
                throw new DuplicateNameException("The key already exist!");
            }

            this.internalCollection[ind].AddLast(new KeyValuePair<K, V>(key, value));
            this.keysHashSet.Add(key);
            this.count++;

        }

        public void Remove(K key)
        {
            if (!this.keysHashSet.Contains(key))
            {
                //throw new KeyNotFoundException();
                return;
            }
            var value = default(V);
            int ind = this.GetIndex(key);
            if (this.Find(key, out value))
            {
                
                var elToRemove = this.internalCollection[ind].First(x => x.Key.Equals(key));
                this.internalCollection[ind].Remove(elToRemove);
                this.keysHashSet.Remove(key);
                this.count--;

                if (this.internalCollection[ind].Count == 0)
                {
                    this.Count--;
                }
            }
        }

        public bool Find(K key, out V value)
        {
            if (this.keysHashSet.Contains(key) && this.internalCollection[this.GetIndex(key)] != null)
            {
                var ind = this.GetIndex(key);

                value = this.internalCollection[ind].First(b => b.Key.Equals(key)).Value;
                return true;
            }

            value = default(V);

            return false;
        }

        public V this[K key]
        {
            get
            {
                V value;
                if (this.Find(key, out value))
                {
                    return value;
                }

                throw new KeyNotFoundException("Given key do not exist!");
            }
            set
            {
                this.Add(key, value);
            }
        } 

        private int GetIndex(K key)
        {
            return Math.Abs(key.GetHashCode()%this.internalCollection.Length);
        }

        private void Resize()
        {
            var len = this.internalCollection.Length;
            int percentage = (int)(len*0.75);

            if (this.count < percentage)
            {
                return;
            }

            var tempArr = new LinkedList<KeyValuePair<K, V>>[len * 2];
            Array.Copy(this.internalCollection,tempArr, len);
            this.internalCollection = tempArr;
        }

        public IEnumerator<KeyValuePair<K,V>> GetEnumerator()
        {
            foreach (var list in this.internalCollection)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            foreach (var pair in this)
            {
                output.AppendLine(pair.Key + " " + pair.Value);
            }

            return output.ToString();
        }
    }
}