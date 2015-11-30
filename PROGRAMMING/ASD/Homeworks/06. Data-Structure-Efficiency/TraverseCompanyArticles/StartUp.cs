/*
A large trade company has millions of articles, each described by barcode, vendor, title and price.

    Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y].
    Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET.
*/
namespace TraverseCompanyArticles
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Item : IComparable<Item>
    {
        public string title { get; set; }
        public string vendor { get; set; }
        public string barcode { get; set; }
        public decimal price { get; set; }

        public int CompareTo(Item other)
        {
            return String.Compare(this.barcode, other.barcode, StringComparison.Ordinal);
        }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            var database = new OrderedMultiDictionary<decimal, Item>(false);

            for (int i = 1; i < 1000; i++)
            {
                var entry = new Item()
                {
                    price = i + (20 * i % 5),
                    title = "Item#"+i,
                    vendor = "Vendor" + i
                };
                entry.barcode = entry.GetHashCode().ToString();

                database.Add(i,entry);
            }

            var result = database.Range(20, true, 1000, true).Select(ent=>ent.Key);

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
