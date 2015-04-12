using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FourDigitNumer
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a four digit number (cant begin with 0): ");
            int number = int.Parse(Console.ReadLine());
            if ((number > 9999) || (number < 1000))
            {
                while ((number > 9999) || (number < 1000))
                {
                    Console.WriteLine("Please, enter a four digit number (cant begin with 0): ");
                    number = int.Parse(Console.ReadLine());
                }
            }

            int d = (number % 10);
            int c = (number % 100) / 10;
            int b = (number % 1000) / 100;
            int a = (number % 10000) / 1000;


            Console.WriteLine("The sum of the digits is = " + (a + b + c + d));
            Console.WriteLine("The reverse is = " + d + "" + c + "" + b + "" + a);
            Console.WriteLine("Last to first digit: " + d + "" + a + "" + b + "" + c);
            Console.WriteLine("Reverse second and third: " + a + "" + c + "" + b + "" + d);
        }
    }
}
