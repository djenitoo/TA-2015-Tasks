using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4.ImplementHashTable;
/*
Implement the data structure set in a class HashedSet<T> using 
your class HashTable<K,T> to hold the elements. 
Implement all standard set operations like

  + Add(T)
  + Find(T)
  + Remove(T)
  + Count
  + Clear()
  + union and
  + intersect

Write unit tests for your class.
*/

namespace _05.ImplementADTSet
{
    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<int, T> elements;

        public HashedSet()
        {
            this.elements = new HashTable<int, T>();
        }

        public void Clear()
        {
            this.elements = new HashTable<int, T>();
        }

        public void Add(T value)
        {
            this.elements.Add(value.GetHashCode(), value);
        }

        public int Count
        {
            get { return this.elements.Count; }
        }

        public bool Contains(T value)
        {
            var res = default(T);
            
            return this.elements.Find(value.GetHashCode(), out res);
        }

        public void Remove(T value)
        {
            this.elements.Remove(value.GetHashCode());
        }

        public void UnionWith(HashedSet<T> anotherSet)
        {
            foreach (var el in anotherSet.Where(el => !this.Contains(el)))
            {
                this.Add(el);
            }
        }

        public void IntersectWith(HashedSet<T> anotherSet)
        {
            var res = new HashedSet<T>();

            foreach (var el in this)
            {
                if (anotherSet.Contains(el))
                {
                    res.Add(el);
                }
                
            }

            this.elements = res.elements;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.Select(el => el.Value).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(" ", this);
        }
    }
}
