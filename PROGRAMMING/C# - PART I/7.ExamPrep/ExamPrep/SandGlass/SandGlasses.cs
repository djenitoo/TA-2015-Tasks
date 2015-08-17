using System;

namespace SandGlass
{
    class SandGlasses
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(line);

            for (int i = 0; i <= n / 2; i++)
            {
                string dots = new string('.',i);
                string asterix = new string('*',n - 2 * i );

                Console.WriteLine("{0}{1}{0}", dots, asterix);
            }
            for (int i = n / 2 - 1 ; i >= 0; i--)
            {
                string dots = new string('.', i);
                string asterix = new string('*', n - 2 * i );

                Console.WriteLine("{0}{1}{0}", dots, asterix);
            }
        }
    }
}
