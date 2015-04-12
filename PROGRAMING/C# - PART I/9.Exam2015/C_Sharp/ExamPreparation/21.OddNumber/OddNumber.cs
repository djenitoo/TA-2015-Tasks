using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// za 80t
namespace _21.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            //TODO: read them in list; sort the list; loop for counting same elements + lastindexof?
            int n = int.Parse(Console.ReadLine());
            List<long> numbers = new List<long>();
            long answer = 0;
            for (int i = 0; i < n; i++)
            {
                //long item = long.Parse(Console.ReadLine());
                //answer ^= item;
               numbers.Add(long.Parse(Console.ReadLine()));
            }

            numbers.Sort();

            int count2 = 1;
            long previousIndex = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] == previousIndex)
                {
                    count2++;
                }
                else
                {
                    if (count2 % 2 != 0)
                    {
                        answer = previousIndex;
                        break;
                    }
                    count2 = 1;
                    previousIndex = numbers[i];
                }
                //long current = numbers[i];
                //int firstIndex = numbers.IndexOf(current);
                //int lastIndex = numbers.LastIndexOf(current);

                //if (lastIndex < 0)
                //{
                //    answer = current;
                //    break;
                //}
                //else
                //{
                //    int count = 1 + (lastIndex - firstIndex);
                //    if (count % 2 != 0)
                //    {
                //        answer = current;
                //        break;
                //    }
                //    else
                //    {
                //        i = lastIndex;
                //    }
                //}
            }
            if (count2 % 2 != 0)
            {
                answer = previousIndex;
            }
            Console.WriteLine(answer);
        }
    }
}
