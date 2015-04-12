namespace _03._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public ulong this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index out of bit array range!");
                }
                return (this.number >> index) & 1; 
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index out of bit array range!");
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be something else than 0 or 1!");
                }
                ulong reverseValue = ((int)value - 1 < 0) ? (ulong)1 : 0;
                ulong temp = this.number ^ (reverseValue << index);
                this.number = temp ^ (value << index);
            }
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public static bool operator ==(BitArray64 num1, BitArray64 num2)
        {
            return num1.Equals(num2);
        }
        public static bool operator !=(BitArray64 num1, BitArray64 num2)
        {
            return !(num1.Equals(num2));
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public IEnumerator<int> GetEnumerator() // thanks to dentia
        {
            for (int index = 63; index >= 0; index--)
            {
                yield return (int)this[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach(var bit in this)
            {
                result += bit;
            }

            return result;
        }
    }
}
