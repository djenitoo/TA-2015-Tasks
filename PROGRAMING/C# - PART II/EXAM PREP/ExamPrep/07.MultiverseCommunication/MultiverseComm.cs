using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiverseCommunication
{
    class MultiverseComm
    {
        static void Main()
        {
            string[] codes = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
            string code = Console.ReadLine();
            string digits = string.Empty;
            List<long> decimalNumbers = new List<long>();

            for (int i = 0; i < code.Length; i++)
            {
                digits += code[i];
                switch (digits)
                {
                    case "CHU": decimalNumbers.Add(0); digits = string.Empty;
                        break;
                    case "TEL": decimalNumbers.Add(1); digits = string.Empty;
                        break;
                    case "OFT": decimalNumbers.Add(2); digits = string.Empty;
                        break;
                    case "IVA": decimalNumbers.Add(3); digits = string.Empty;
                        break;
                    case "EMY": decimalNumbers.Add(4); digits = string.Empty;
                        break;
                    case "VNB": decimalNumbers.Add(5); digits = string.Empty;
                        break;
                    case "POQ": decimalNumbers.Add(6); digits = string.Empty;
                        break;
                    case "ERI": decimalNumbers.Add(7); digits = string.Empty;
                        break;
                    case "CAD": decimalNumbers.Add(8); digits = string.Empty;
                        break;
                    case "K-A": decimalNumbers.Add(9); digits = string.Empty;
                        break;
                    case "IIA": decimalNumbers.Add(10); digits = string.Empty;
                        break;
                    case "YLO": decimalNumbers.Add(11); digits = string.Empty;
                        break;
                    case "PLA": decimalNumbers.Add(12); digits = string.Empty;
                        break;
                }
            }
            long result = 0;
            long power = 1;

            for (int i = decimalNumbers.Count - 1; i >= 0; i--)
            {
                result += decimalNumbers[i] * power;
                power *= 13;
            }

            Console.WriteLine(result);
        }
    }
}
