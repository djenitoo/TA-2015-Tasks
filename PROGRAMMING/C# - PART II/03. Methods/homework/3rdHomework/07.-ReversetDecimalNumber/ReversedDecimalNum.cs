using System;
// Write a method that reverses the digits of given decimal number. Example: 256  652


namespace _07._ReversetDecimalNumber
{
    class ReversedDecimalNum
    {
        static void Main()
        {
            Console.Write("Please enter the number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal result = NumberReverser(number);
            Console.WriteLine("Result = " + result);
        }

        static decimal NumberReverser(decimal number)
        {
            int mask = 0;
            //while (number != 0)
            //{
            //    mask = (mask * 10) + number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine(mask);
            string str = "";
            char[] arr = number.ToString().ToCharArray();
            char[] reverse = new char[arr.Length];
            for (int i = arr.Length - 1; i >= 0 ; i--)
            {
                str += arr[i];
            }

            decimal result = decimal.Parse(str);

            return result;
        }
    }
}
