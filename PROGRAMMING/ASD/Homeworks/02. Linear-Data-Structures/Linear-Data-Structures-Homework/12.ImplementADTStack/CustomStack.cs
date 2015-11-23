using System;
using System.CodeDom;
using System.Collections;
/*
Implement the ADT stack as auto-resizable array.

    Resize the capacity on demand (when no space is available to add / insert a new element).
*/
namespace _12.ImplementADTStack
{
    public class CustomStack<T> : IEnumerable // understand and made thanks to dentia code
    {
        // pop push insert resize add count
        private T[] array;
        private int lastElementIndex;

        public CustomStack() : this(5)
        {
        }
         
        public CustomStack(int size)
        {
            this.array = new T[size];
            lastElementIndex = -1;
        }

        public int Count
        {
            get { return this.lastElementIndex + 1; }

        }

        public void Push(T element)
        {
            if (this.lastElementIndex == array.Length - 1)
            {
                // here resize
                Resize();
            }

            lastElementIndex++;
            array[lastElementIndex] = element;
        }

        public T Peek()
        {
            if (lastElementIndex < 0)
            {
                throw new IndexOutOfRangeException("There is no more element for poping in the stack!");
            }

            return this.array[lastElementIndex];
        }

        public T Pop()
        {
            if (lastElementIndex < 0)
            {
                throw new IndexOutOfRangeException("There is no more element for poping in the stack!");
            }

            lastElementIndex--;
            return array[lastElementIndex + 1];
        }

        public IEnumerator GetEnumerator()
        {
            //make pravilno
            for (int i = 0; i < this.lastElementIndex; i++)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Resize()
        {
            var temp = new T[this.array.Length*2 + 1];
            Array.Copy(this.array, temp, lastElementIndex + 1);
            this.array = temp;
        }
    }
}