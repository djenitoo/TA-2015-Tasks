using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ImplementADTSet
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var set1 = new HashedSet<int>();
            var set2 = new HashedSet<int>();

            for (int i = 0; i < 10; i++)
            {
                set1.Add(i*2);
                set2.Add(i*3);
            }

            Console.WriteLine("Set 1: " + set1.ToString());
            Console.WriteLine("Set 2: " + set2.ToString());

            Console.WriteLine("Set 1 union with set 2:");
            Console.WriteLine("Set 1:");
            set1.UnionWith(set2);
            Console.WriteLine(set1);

            Console.WriteLine("Set 1 intersect with set 2:");
            Console.WriteLine("Set 1:");
            set1.IntersectWith(set2);
            Console.WriteLine(set1);
        }
    }
}
