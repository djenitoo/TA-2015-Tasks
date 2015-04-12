using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CheckCards
{
    class CheckCards
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str.Length > 1 && str == "10")
            {
                Console.WriteLine("yes");
            }
            else if (str.Length == 1)
            {
                if ((str[0] >= 50 && str[0] <= 57) || (str[0] == 'A') || (str[0] == 'K') || (str[0] == 'J') || (str[0] == 'Q'))
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
