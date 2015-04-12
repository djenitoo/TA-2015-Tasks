using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class house
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int h = int.Parse(line);
            string line2 = Console.ReadLine();
            int b = int.Parse(line2);
            int lenght = h * 2;

            // Triangle
            for (int i = 1, space = h-1; i <= h; i++)
            {
                Console.Write(new string(' ', space));
                Console.Write(new string('/', i));
                Console.Write(new string('\\', i));
                Console.Write(new string(' ', space));
                Console.WriteLine();
                space--;
            }
            for (int i = 1; i <= b; i++)
            {
                Console.Write(new string(' ', (lenght / 2) - b));
                Console.Write(new string('=', b));
                Console.Write(new string('=', b));
                Console.Write(new string(' ', (lenght / 2) - b));

                Console.WriteLine();
            }
        }
    }
}
