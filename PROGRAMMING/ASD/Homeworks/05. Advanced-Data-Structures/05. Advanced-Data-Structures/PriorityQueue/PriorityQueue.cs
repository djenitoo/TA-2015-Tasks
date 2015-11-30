using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> queue;
        public int Count
        {
            get { return this.queue.Count; }
        }
        public PriorityQueue()
        {
            this.queue = new List<T>(4);
        }
        public void Enqueue(T element)
        {
            this.queue.Add(element);
            // here sorting up
            SortingUp(this.queue.Count - 1);
        }
        public T Dequeue()
        {
            T biggestValue = this.queue[0];
            this.queue.RemoveAt(0);
            this.queue.TrimExcess();
            return biggestValue;
            
        }

        private void SortingUp(int index)
        {
            while (index > 0 && this.queue[index].CompareTo(this.queue[index - 1]) > 0)
            {
                T temp = this.queue[index];
                this.queue[index] = this.queue[index - 1];
                this.queue[index - 1] = temp;
                index--;
            }
        }
    }
}
