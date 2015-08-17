using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// * Write a program that sorts an array of integers 
// using the merge sort algorithm (find it in Wikipedia).

namespace _13.Merge_Sort
{
    class MergeSort
    {
        static void Main()
        {
            List<int> unsorted = new List<int> { 1, 3, 5, 7, 9, 8, 6, 4, 2, 10, 5, 3, 2, 1 };

            List<int> sorted = Merge_sort(unsorted);

            Console.WriteLine(string.Join(", ", sorted));
            Console.ReadKey();
        }

        static List<int> Merge_sort(List<int> arr) {

            if (arr.Count < 2)
            {
                return arr;
            }
            else
            {
                int middle = arr.Count / 2;
                List<int> left = new List<int>();
                List<int> right = new List<int>();

                for (int i = 0; i < middle; i++)
                {
                    left.Add(arr[i]);
                }
                for (int i = middle; i < arr.Count; i++)
                {
                    right.Add(arr[i]);
                }

                left = Merge_sort(left);
                right = Merge_sort(right);

                return Merge(left, right);
            }
            

        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            
            while (left.Count != 0 && right.Count != 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            while (left.Count != 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            while (right.Count != 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
            
            return result;
        } 
    }
}
