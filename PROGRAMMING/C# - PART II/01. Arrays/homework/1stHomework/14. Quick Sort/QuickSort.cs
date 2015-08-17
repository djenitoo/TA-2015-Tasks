using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Not working, sorry
namespace _14.Quick_Sort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            //List<int> unsorted = new List<int> { 1, 3, 5, 7, 9, 8, 6, 4, 2 };
            List<int> unsorted = new List<int> { 1, 3, 5, 7, 9, 8, 6, 4, 2, 10, 5, 3, 2, 1 };

            List<int> sorted = quicksort(unsorted);

            Console.WriteLine(string.Join(",", sorted));
            Console.ReadKey();
        }

        private static List<int> quicksort(List<int> arr)
        {
            List<int> loe = new List<int>(), gt = new List<int>();
            if (arr.Count < 2)
            { return arr; }

            int pivot = arr.Count / 2;
            int pivot_val = arr[pivot];
            arr.RemoveAt(pivot);
            foreach (int i in arr)
            {
                if (i <= pivot_val)
                {
                    loe.Add(i);
                }
                else if (i > pivot_val)
                {
                    gt.Add(i);
                }
            }

            List<int> resultSet = new List<int>();
            
            resultSet.AddRange(quicksort(loe));
            if (gt.Count == 0)
            {
                resultSet.Add(pivot_val);
            }
            else
            {
                gt.Insert(0, pivot_val);
            }
            resultSet.AddRange(quicksort(gt));
            return resultSet;
        }
    }
}
