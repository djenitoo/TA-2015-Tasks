namespace _03._64BitArray
{
    using System;

    class Test64BitArray
    {
        static void Main()
        {
            var number = new BitArray64(5u);
            var number2 = new BitArray64(5u);
            
            // try ToString() implemented using IEnumerator<int> override
            Console.WriteLine(number);
            
            // try indexer
            number[0] = 0;
            Console.WriteLine("\r\n" + number);
            
            //try equal()
            Console.WriteLine(number.Equals(number2)); // no bc we changed the bit at pos 0
            Console.WriteLine(number2.Equals(new BitArray64(5))); // true

            //try == and != operators
            Console.WriteLine(number == number2); // false
            Console.WriteLine(number2 != number2); // false, they are equal

            // try gethashcode()
            Console.WriteLine(number2.GetHashCode());
            Console.WriteLine(number.GetHashCode());

        }
    }
}
