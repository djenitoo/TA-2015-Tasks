using System;
using System.Diagnostics;
/*
 * ## Task 3. Compare advanced Maths
 *	Write a program to `compare the performance` of:
	*	**square root**, **natural logarithm**, **sinus**
 *	for the values:
	*	`float`, `double` and `decimal`
 * */
namespace Compare_advanced_Maths
{
    class CompareAdvancedMaths
    {
        static void Main(string[] args)  // HW done with the help of dencia, ivaylo.kenov hw-s
        {
            const int times = 100000;
            const float fValue = 10.0F;
            const double dValue = 10.0;
            const decimal MValue = 10.0M;

            float floatValue = 0;
            double doubleValue = 0;
            decimal decimalValue = 0;
            

            Console.WriteLine("SQRT " + times + " times:");
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < times; i++)
            {
                floatValue = (float)Math.Sqrt(fValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Float time \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                doubleValue = Math.Sqrt(dValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Double time \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                decimalValue = (decimal)Math.Sqrt((double)MValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal time \t" + stopwatch.Elapsed);

            // LOG
            Console.WriteLine("\r\nNatural logarithm " + times + " times:");

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                floatValue = (float)Math.Log(fValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Float time \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                doubleValue = Math.Log(dValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Double time \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                decimalValue = (decimal)Math.Log((double)MValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal time \t" + stopwatch.Elapsed);

            //SINUS
            Console.WriteLine("\r\nSinus " + times + " times:");

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                floatValue = (float)Math.Sin(fValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Float time \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                doubleValue = Math.Sin(dValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Double time \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < times; i++)
            {
                decimalValue = (decimal)Math.Sin((double)MValue);
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal time \t" + stopwatch.Elapsed);

        }
    }
}
