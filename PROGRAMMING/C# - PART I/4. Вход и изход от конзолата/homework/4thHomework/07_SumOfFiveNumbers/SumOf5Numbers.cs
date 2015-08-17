using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumOfFiveNumbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            string str = Console.ReadLine().Trim();
            string[] arr = str.Split(' ');
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += Convert.ToInt32(arr[i]);
            }

            Console.WriteLine("Sum is =" + sum);
        }
    }
}
