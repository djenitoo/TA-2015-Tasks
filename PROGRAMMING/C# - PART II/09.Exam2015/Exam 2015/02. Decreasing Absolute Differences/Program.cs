using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Decreasing_Absolute_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            List<List<int>> sequences = new List<List<int>>();
            var absoluteDiff = new List<List<int>>();
            var output = new List<bool>();
            for (int i = 0; i < T; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                List<int> arr = line.Select(int.Parse).ToList();
                sequences.Add(arr);
            }
            for (int i = 0; i < sequences.Count; i++)
            {
                absoluteDiff.Add(GetAbsloluteDiff(sequences[i]));
            }

            for (int i = 0; i < absoluteDiff.Count; i++)
            {
                bool temp = true;
                for (int j = 1; j < absoluteDiff[i].Count; j++)
                {
                    int one = absoluteDiff[i][j - 1];
                    int two = absoluteDiff[i][j];
                    if (!(one >= two) || (Math.Abs(one - two) > 1))
                    {
                        temp = false;
                        break;
                    }
                }
                output.Add(temp);
            }

            foreach (bool item in output)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> GetAbsloluteDiff(List<int> list)
        {
            var seqAbsDiff = new List<int>();

            for (int i = 0; i < list.Count - 1; i++)
            {
                int max = list[i];
                int min = list[i + 1];
                if (max < list[i + 1])
                {
                    max = list[i + 1];
                    min = list[i];
                }
                int diff = max - min;
                seqAbsDiff.Add(diff);
            }

            return seqAbsDiff;
        }
    }
}
