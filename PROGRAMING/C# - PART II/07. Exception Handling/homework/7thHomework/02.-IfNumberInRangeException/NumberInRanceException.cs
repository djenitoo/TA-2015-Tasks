using System;
// Write a method ReadNumber(int start, int end) that enters an integer number
// in given range [start…end]. If an invalid number or non-number text is entered, 
// the method should throw an exception. Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100


namespace _02._IfNumberInRangeException
{
    class NumberInRanceException
    {
        static void ReadNumber(int start, int end)
        {
            try
            {
                int a;
                string number = Console.ReadLine();
                a = int.Parse(number);
                if ((a < start) || (a > end))
                {
                    throw new IndexOutOfRangeException();
                }
                start = a;
                for (int i = 0; i < 9; i++)
                {
                    number = Console.ReadLine();
                    a = int.Parse(number);
                    if (a <= start)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else if (a > end)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    start = a;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format!");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number out of range!");

            }
            catch (Exception)
            {
                Console.WriteLine("Error occured!");
            }
            

        }
        static void Main()
        {
            ReadNumber(1, 100);
        }
    }
}
