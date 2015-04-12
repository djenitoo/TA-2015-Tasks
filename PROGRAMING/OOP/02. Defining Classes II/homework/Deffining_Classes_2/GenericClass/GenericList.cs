namespace Deffining_Classes_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // TASK 5
    class GenericList<T> where T: IComparable<T>
    {
        private T[] listOfElements;
        private int index;

        public GenericList(int capacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException("Capacity cannot be less than one!");
            }
            this.listOfElements = new T[capacity];
            this.index = 0;
        }

        public void Add(T element)
        {
            this.listOfElements[this.index] = element;
            this.index++;
            if (this.index.Equals(this.listOfElements.Length))
            {
                Expand();
            }
        }

        public void Remove(int ind)
        {
            if (ind < 0 || ind > this.listOfElements.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            this.listOfElements[ind] = default(T);

            for (int i = ind; i < this.listOfElements.Length - 2; i++)
            {
                this.listOfElements[i] = this.listOfElements[i + 1]; 
            }

            this.listOfElements[this.listOfElements.Length - 1] = default(T);
        }

        public void InsertAt(int ind, T el)
        {
            if (ind < 0 || ind > this.listOfElements.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            if (!(this.listOfElements[this.listOfElements.Length - 1].Equals(default(T))))
            {
                Expand();
            }
            for (int i = this.listOfElements.Length - 1; i > ind; i--)
            {
                this.listOfElements[i] = this.listOfElements[i - 1];
            }

            this.listOfElements[ind] = el;
        }

        public void Clear()
        {
            int len = this.listOfElements.Length;
            this.listOfElements = new T[len];
        }

        public int Find(T el)
        {
            for (int i = 0; i < this.listOfElements.Length - 1; i++)
            {
                if (this.listOfElements[i].Equals(el))
                {
                    return i;
                }
            }

            return -1;
        }

        public T this[int ind]
        {
            get
            {
                if (ind < 0 || ind >= this.listOfElements.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.listOfElements[ind];
            }

            set
            {
                if (ind < 0 || ind >= this.listOfElements.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                this.listOfElements[ind] = value;
            }
        }

        // TASK 6
        private void Expand()
        {
            int len = this.listOfElements.Length;

            List<T> tempList = new List<T>(this.listOfElements);
            tempList.Capacity = len * 2;
            this.listOfElements = tempList.ToArray();
        }

        public override string ToString()
        {
            string output = String.Empty;

            foreach (var item in this.listOfElements)
            {
                output += item.ToString() + "\r\n";
            }

            return output;
        }

        // TASK 7
        public T Min() 
        {
            T min = this.listOfElements[0];
            for (int i = 1; i < this.listOfElements.Length - 1; i++)
            {
                if (this.listOfElements[i].CompareTo(min) == -1)
                {
                    min = this.listOfElements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.listOfElements[0];
            for (int i = 1; i < this.listOfElements.Length - 1; i++)
            {
                if (this.listOfElements[i].CompareTo(max) == 1)
                {
                    max = this.listOfElements[i];
                }
            }
            return max;
        }

    }
}
