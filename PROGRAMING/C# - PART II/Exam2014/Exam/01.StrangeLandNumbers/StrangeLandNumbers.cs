using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.StrangeLandNumbers
{
    class StrangeLandNumbers
    {
        static void Main()
        {
            //string[] codes = { "f", "", "", "", "", "", "" };
            StringBuilder text = new StringBuilder();
            string input = Console.ReadLine();
            input.Trim();
            text.Append(input);
            string digit = string.Empty;
            List<int> numbers = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                digit += input[i];

                switch (digit)
                {
                    case "f": numbers.Add(0); digit = string.Empty;
                        break;
                    case "bIN": numbers.Add(1); digit = string.Empty;
                        break;
                    case "oBJEC": numbers.Add(2); digit = string.Empty;
                        break;
                    case "mNTRAVL": numbers.Add(3); digit = string.Empty;
                        break;
                    case "lPVKNQ": numbers.Add(4); digit = string.Empty;
                        break;
                    case "pNWE": numbers.Add(5); digit = string.Empty;
                        break;
                    case "hT": numbers.Add(6); digit = string.Empty;
                        break;
                }
            }

            BigInteger result = 0;
            BigInteger power = 1;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result += numbers[i] * power;
                power = power * 7;
            }

            Console.WriteLine(result);
        }
    }
}
