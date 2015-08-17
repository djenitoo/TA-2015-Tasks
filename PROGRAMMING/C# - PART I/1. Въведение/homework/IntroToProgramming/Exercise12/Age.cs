using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Age
    {
        static void Main(string[] args)
        {
            int CurrentAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years:");
            Console.WriteLine(CurrentAge+10);
        }
    }
}
