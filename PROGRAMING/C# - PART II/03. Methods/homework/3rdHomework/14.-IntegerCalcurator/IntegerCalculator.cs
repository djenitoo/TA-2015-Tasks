using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._IntegerCalcurator
{
    class IntegerCalculator
    {
        static void Main(string[] args)
        {
            decimal[] intArr = { 1, 4, 22, -20, 321, 3, 2, 1, 5, -6655, 23, 12, 6, 3, 4, 24535 };
            double[] doubleArr = { 1.4, 4.2, 22.22222, -20.21, 321, 3, 2, 1, 5, -6655.54346, 23, 12, 6, 3, 4, 24535.322 };

            Calculator(intArr);
            Console.WriteLine();
            Calculator(doubleArr);
        }

        //private static void Calculator(decimal[] intArr)
        //{
        //    decimal min = intArr[0];
        //    decimal max = intArr[0];
        //    decimal sum = 0;
        //    decimal product = 1;

        //    for (int i = 0; i < intArr.Length; i++)
        //    {
        //        sum += intArr[i];
        //        product *= intArr[i];
        //        if (intArr[i] < min)
        //        {
        //            min = intArr[i];
        //        }
        //        if (intArr[i] > max)
        //        {
        //            max = intArr[i];
        //        }
        //    }

        //    Console.WriteLine("Min = " + min);
        //    Console.WriteLine("Max = " + max);
        //    Console.WriteLine("Sum = " + sum);
        //    Console.WriteLine("Product = " + product);
        //    Console.WriteLine("Average = " + sum / intArr.Length);
        //}

        private static void Calculator<T>(T[] intArr)
        {
            T min = intArr[0];
            T max = intArr[0];
            dynamic sum = 0;
            dynamic product = 1;

            for (dynamic i = 0; i < intArr.Length; i++)
            {
                sum += intArr[i];
                product *= intArr[i];
                if ((dynamic)intArr[i] < min)
                {
                    min = intArr[i];
                }
                if ((dynamic)intArr[i] > max)
                {
                    max = intArr[i];
                }
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Product = " + product);
            Console.WriteLine("Average = " + sum / intArr.Length);
        }
    }
}
