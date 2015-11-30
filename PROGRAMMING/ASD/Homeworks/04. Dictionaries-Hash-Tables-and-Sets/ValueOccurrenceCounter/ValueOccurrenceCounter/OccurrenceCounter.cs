using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*


    Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}

    -2.5 -> 2 times

    3 -> 4 times

    4 -> 3 times

*/
namespace ValueOccurrenceCounter
{
    class OccurrenceCounter
    {
        static void Main(string[] args)
        {
            var numberOccurrenceDictionary = new Dictionary<double, int>();

            double[] exampleArray = new double[] {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5};

            foreach (var number in exampleArray)
            {
                if (numberOccurrenceDictionary.ContainsKey(number))
                {
                    numberOccurrenceDictionary[number] = numberOccurrenceDictionary[number] + 1;
                }
                else
                {
                    numberOccurrenceDictionary.Add(number, 1);
                }
            }

            foreach (var pair in numberOccurrenceDictionary)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value + " times.");
            }
        }
    }
}
