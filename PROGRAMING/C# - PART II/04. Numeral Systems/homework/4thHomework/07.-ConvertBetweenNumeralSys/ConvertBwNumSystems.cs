using System;
using System.Collections.Generic;
// Write a program to convert from any numeral system of given base s 
// to any other numeral system of base d (2 ≤ s, d ≤  16).


namespace _07._ConvertBetweenNumeralSys
{
    class ConvertBwNumSystems
    {
        static int FromLowerBaseToBase10(string number, byte numberBase)
        {
            int result = 0;
            int intNumber = int.Parse(number);
            int power = 0;
            while (intNumber > 0)
            {
                int mid = intNumber % 10;
                result = result + (mid * (int)Math.Pow(numberBase, power));
                intNumber /= 10;
                power++;
            }
            return result;
        }

        static int FromHigerBaseToBase10(string number, byte numberBase)
        {
            number = number.ToUpper();
            int result = 0;
            byte power = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    result = result + (((int)number[i] - 48) * (int)Math.Pow(numberBase, power));
                }
                else if (number[i] == 'A')
                {
                    result = result + (10 * (int)Math.Pow(numberBase, power));
                }
                else if (number[i] == 'B')
                {
                    result = result + (11 * (int)Math.Pow(numberBase, power));
                }
                else if (number[i] == 'C')
                {
                    result = result + (12 * (int)Math.Pow(numberBase, power));
                }
                else if (number[i] == 'D')
                {
                    result = result + (13 * (int)Math.Pow(numberBase, power));
                }
                else if (number[i] == 'E')
                {
                    result = result + (14 * (int)Math.Pow(numberBase, power));
                }
                else if (number[i] == 'F')
                {
                    result = result + (15 * (int)Math.Pow(numberBase, power));
                }
            }
            return result;
        }
        static void FromDecimalToAnotherBase(int number, byte numberBase)
        {
            List<char> result = new List<char>();
            
            while (number > 0)
            {
                int mask = number % numberBase;
                if (mask > 9)
                {
                    if (mask == 10)
                    {
                        result.Add('A');
                    }
                    else if (mask == 11)
                    {
                        result.Add('B');
                    }
                    else if (mask == 12)
                    {
                        result.Add('C');
                    }
                    if (mask == 13)
                    {
                        result.Add('D');
                    }
                    else if (mask == 14)
                    {
                        result.Add('E');
                    }
                    else if (mask == 15)
                    {
                        result.Add('F');
                    }
                }
                else
                {
                    result.Add((char)(mask + 48));
                }
                number /= numberBase;
            }

            result.Reverse();
            foreach (char numb in result)
            {
                Console.Write(numb);
            }
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            Console.Write("Enter the number's base (2,16): ");
            byte numberBase = byte.Parse(Console.ReadLine());
            Console.Write("Enter the  wanted base (2,16): ");
            byte wantedBase = byte.Parse(Console.ReadLine());

            int numberInDes = 0;

            if (numberBase < 10)
            {
                numberInDes = FromLowerBaseToBase10(number, numberBase);
            }
            else if (numberBase > 10)
            {
                numberInDes = FromHigerBaseToBase10(number, numberBase);
            }
            else
            {
                numberInDes = int.Parse(number);
            }
            Console.WriteLine("The number {0} in {1} base is: ", number, wantedBase);
            FromDecimalToAnotherBase(numberInDes, wantedBase);
            Console.WriteLine();

        }
    }
}
