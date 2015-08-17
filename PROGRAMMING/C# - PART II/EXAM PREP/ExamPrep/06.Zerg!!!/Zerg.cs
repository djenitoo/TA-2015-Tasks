using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Zerg___
{
    class Zerg
    {
        static void Main()
        {
            string[] codeOfZerg = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
            string number = Console.ReadLine();
            List<ulong> decimalNumbers = new List<ulong>();
            string digits = string.Empty;
            for (int i = 0; i < number.Length; i++)
            {
                digits += number[i];

                switch (digits)
                {
                    case "Rawr": decimalNumbers.Add(0); digits = string.Empty;
                    break;
                    case "Rrrr": decimalNumbers.Add(1); digits = string.Empty;
                    break;
                    case "Hsst": decimalNumbers.Add(2); digits = string.Empty;
                    break;
                    case "Ssst": decimalNumbers.Add(3); digits = string.Empty;
                    break;
                    case "Grrr": decimalNumbers.Add(4); digits = string.Empty;
                    break;
                    case "Rarr": decimalNumbers.Add(5); digits = string.Empty;
                    break;
                    case "Mrrr": decimalNumbers.Add(6); digits = string.Empty;
                    break;
                    case "Psst": decimalNumbers.Add(7); digits = string.Empty;
                    break;
                    case "Uaah": decimalNumbers.Add(8); digits = string.Empty;
                    break;
                    case "Uaha": decimalNumbers.Add(9); digits = string.Empty;
                    break;
                    case "Zzzz": decimalNumbers.Add(10); digits = string.Empty;
                    break;
                    case "Bauu": decimalNumbers.Add(11); digits = string.Empty;
                    break;
                    case "Djav": decimalNumbers.Add(12); digits = string.Empty;
                    break;
                    case "Myau": decimalNumbers.Add(13); digits = string.Empty;
                    break;
                    case "Gruh": decimalNumbers.Add(14); digits = string.Empty;
                    break;
                }
            }
            ulong result = 0;
            ulong power = 1;

            for (int i = decimalNumbers.Count - 1; i >= 0; i--)
            {
                result += decimalNumbers[i] * power;
                power *= 15;
            }
            Console.WriteLine(result);
        }
    }
}
