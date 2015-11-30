using System;
using System.Linq;
using System.Text;

namespace ReadProductCollection
{
    using Wintellect.PowerCollections;

    class StartUp
    {
        static void Main(string[] args) //thanks to dentia!!
        {
            var products = new OrderedMultiDictionary<decimal, string>(false);

            for (int i = 0; i < 500000; i++)
            {
                products.Add(i, "Item#" + i);
            }
            var output = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                var res = products.Range(i, true, 50*i, true).Take(20);
                output.AppendLine(string.Join(", ", res.Select(el=>el.Value))).AppendLine();
            }

            Console.WriteLine(output.ToString());
        }
    }
}
