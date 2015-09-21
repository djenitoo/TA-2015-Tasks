using System;
using System.Diagnostics;

namespace Compare_simple_Maths
{
    class CompareSimpleMaths
    {
        static void Main(string[] args) //hw done with the help of ivaylo.kenov's HW!
        {
            int intValue = 0;
			long longValue = 0L;
			double doubleValue = 0;
            float floatValue = 0F;
            decimal decimalValue = 0M;



            Stopwatch stopwatch = new Stopwatch();

            //ADDITION
            #region addition
            Console.WriteLine("ADDITION:");

            stopwatch.Start();
            for (int i = 1; i <= 10000; i++)
            {
                intValue += i;
            }

            stopwatch.Stop();

            Console.WriteLine("Int value: " + intValue + "\t - \t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (long i = 1L; i <= 10000L; i++)
            {
                longValue += i;
            }

            stopwatch.Stop();

            Console.WriteLine("Long value: " + longValue + "\t - \t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (double i = 0.0001; i <= 1.0000; i+= 0.0001)
            {
                doubleValue += i;
            }

            stopwatch.Stop();

            Console.WriteLine("Double value: " + doubleValue + "\t - \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (float i = 0.0001F; i <= 1.0000F; i += 0.0001F)
            {
                floatValue += i;
            }

            stopwatch.Stop();

            Console.WriteLine("Float value: " + floatValue + "\t - \t\t" + stopwatch.Elapsed);
            
            stopwatch.Restart();
            for (decimal i = 0.0001M; i <= 1.0000M; i += 0.0001M)
            {
                decimalValue += i;
            }

            stopwatch.Stop();

            Console.WriteLine("Decimal value: " + decimalValue + "\t - \t" + stopwatch.Elapsed);
            #endregion
            
            //SUBSTRACTION
            #region substraction
            Console.WriteLine("\r\nSUBSTRACTION:");
            stopwatch.Restart();
            for (int i = 10000; i >= 1; i--)
            {
                intValue -= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Int value: " + intValue + "\t - \t\t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (long i = 10000L; i >= 1L; i--)
            {
                longValue -= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Long value: " + longValue + "\t - \t\t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (double i = 1.0000; i >= 0.0001; i -= 0.0001)
            {
                doubleValue -= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Double value: " + doubleValue + " - \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (float i = 1.0000F; i >= 0.0001F; i -= 0.0001F)
            {
                floatValue -= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Float value: " + floatValue + "\t - \t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (decimal i = 1.0000M; i >= 0.0001M; i -= 0.0001M)
            {
                decimalValue -= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Decimal value: " + decimalValue + "\t - \t\t" + stopwatch.Elapsed); 
            #endregion

            //INCREMENT
            #region increment
            Console.WriteLine("\r\nINCREMENT:");
            stopwatch.Restart();
            for (int i = 1; i <= 10000; i++)
            {
                intValue++;
            }

            stopwatch.Stop();

            Console.WriteLine("Int value: " + intValue + "\t - \t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (long i = 1L; i <= 10000L; i++)
            {
                longValue++;
            }

            stopwatch.Stop();

            Console.WriteLine("Long value: " + longValue + "\t - \t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (double i = 0.0001; i <= 1.0000; i += 0.0001)
            {
                doubleValue++;
            }

            stopwatch.Stop();

            Console.WriteLine("Double value: " + doubleValue + "\t - \t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (float i = 0.0001F; i <= 1.0000F; i += 0.0001F)
            {
                floatValue++;
            }

            stopwatch.Stop();

            Console.WriteLine("Float value: " + floatValue + "\t - \t\t" + stopwatch.Elapsed);

            stopwatch.Restart();
            for (decimal i = 0.0001M; i <= 1.0000M; i += 0.0001M)
            {
                decimalValue++;
            }

            stopwatch.Stop();

            Console.WriteLine("Decimal value: " + decimalValue + "\t - \t" + stopwatch.Elapsed);
            #endregion


            // MULTIPLY
            #region multipy
            Console.WriteLine("\r\nMULTIPLY:");

            intValue = 1;
            stopwatch.Restart();
            for (int i = 1; i < 10; i++)
            {
                intValue *= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Int value: " + intValue + "\t - \t\t" + stopwatch.Elapsed);

            longValue = 1;
            stopwatch.Restart();
            for (long i = 1L; i < 10L; i++)
            {
                longValue *= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Long value: " + longValue + "\t - \t\t" + stopwatch.Elapsed);

            doubleValue = 1;
            stopwatch.Restart();
            for (double i = 0.1; i < 1.0; i+= 0.1)
            {
                doubleValue *= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Double value: " + doubleValue + "\t - \t" + stopwatch.Elapsed);

            floatValue = 1;
            stopwatch.Restart();
            for (float i = 0.1F; i < 1.0F; i += 0.1F)
            {
                floatValue *= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Float value: " + floatValue + "\t - \t" + stopwatch.Elapsed);

            decimalValue = 1;
            stopwatch.Restart();
            for (decimal i = 0.1M; i < 1.0M; i += 0.1M)
            {
                decimalValue *= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Decimal value: " + decimalValue + "\t - \t" + stopwatch.Elapsed);
            #endregion

            // DIVIDE
            #region divide
            Console.WriteLine("\r\nDIVIDE:");

            //intValue = 1;
            stopwatch.Restart();
            for (int i = 1; i < 10; i++)
            {
                intValue /= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Int value: " + intValue + "\t - \t\t\t" + stopwatch.Elapsed);

            //longValue = 1;
            stopwatch.Restart();
            for (long i = 1L; i < 10L; i++)
            {
                longValue /= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Long value: " + longValue + "\t - \t\t\t" + stopwatch.Elapsed);

            //doubleValue = 1;
            stopwatch.Restart();
            for (double i = 0.1; i < 1.0; i += 0.1)
            {
                doubleValue /= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Double value: " + doubleValue + "\t - \t\t\t" + stopwatch.Elapsed);

            //floatValue = 1;
            stopwatch.Restart();
            for (float i = 0.1F; i < 1.0F; i += 0.1F)
            {
                floatValue /= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Float value: " + floatValue + "\t - \t\t\t" + stopwatch.Elapsed);

            //decimalValue = 1;
            stopwatch.Restart();
            for (decimal i = 0.1M; i < 1.0M; i += 0.1M)
            {
                decimalValue /= i;
            }

            stopwatch.Stop();

            Console.WriteLine("Decimal value: " + decimalValue + " - \t\t\t" + stopwatch.Elapsed);
            #endregion

        }
    }
}
