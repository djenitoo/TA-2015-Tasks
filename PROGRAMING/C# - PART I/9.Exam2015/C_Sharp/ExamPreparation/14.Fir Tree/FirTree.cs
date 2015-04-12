using System;

namespace _14.Fir_Tree
{
    class FirTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = ((n - 2) * 2) + 1;

            int tree = 1;
            int Dots = width / 2;
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', Dots));
                Console.Write(new string('*', tree));
                Console.Write(new string('.',Dots));
                
                tree += 2;
                Dots--;
                Console.WriteLine();
            }
            Console.Write(new string('.', width / 2));
            Console.Write("*");
            Console.Write(new string('.', width / 2));
            Console.WriteLine();
        }
    }
}
