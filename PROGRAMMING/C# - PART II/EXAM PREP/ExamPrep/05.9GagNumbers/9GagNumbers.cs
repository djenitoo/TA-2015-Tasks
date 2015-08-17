using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._9GagNumbers
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            string digits = "";
            List<ulong> decimalNumers = new List<ulong>();
            for (int i = 0; i < number.Length; i++)
            {
                digits += number[i];

                switch (digits)
                {
                    case "-!": decimalNumers.Add(0); digits = "";
                        break;
                    case "**": decimalNumers.Add(1); digits = "";
                        break;
                    case "!!!": decimalNumers.Add(2); digits = "";
                        break;
                    case "&&": decimalNumers.Add(3); digits = "";
                        break;
                    case "&-": decimalNumers.Add(4); digits = "";
                        break;
                    case "!-": decimalNumers.Add(5); digits = "";
                        break;
                    case "*!!!": decimalNumers.Add(6); digits = "";
                        break;
                    case "&*!": decimalNumers.Add(7); digits = "";
                        break;
                    case "!!**!-": decimalNumers.Add(8); digits = "";
                        break;
                }
            }
            ulong result = 0;
            ulong power = 1;
            for (int numb = decimalNumers.Count - 1; numb >= 0; numb--)
            {
                result += decimalNumers[numb] * power;
                power *= 9;
            }
            Console.WriteLine(result);
        }
    }
}
