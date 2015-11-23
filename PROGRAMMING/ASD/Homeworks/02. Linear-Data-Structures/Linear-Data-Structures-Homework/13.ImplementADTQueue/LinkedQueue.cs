using System;
using System.Collections;
using System.Collections.Generic;

namespace _13.ImplementADTQueue
{
    public class LinkedQueue<T> : IEnumerable
    {
        // count dequeue enqueue peek
        LinkedList<T> internalList;

        public LinkedQueue()
        {
            internalList = new LinkedList<T>();
        }

        public int Count
        {
            get { return this.internalList.Count; }
        }

        public T Peek()
        {
            if (this.internalList.Count == 0)
            {
                throw new ArgumentNullException();
            }

            return this.internalList.First.Value;
        }

        public void Enqueue(dynamic value)
        {
            this.internalList.AddLast(value);
        }

        public T Dequeue()
        {
            T element = this.internalList.First.Value;
            this.internalList.RemoveFirst();
            return element;
        }
         
        public IEnumerator GetEnumerator()
        {
            return this.internalList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}