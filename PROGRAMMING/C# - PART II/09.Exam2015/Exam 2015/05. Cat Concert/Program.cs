using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cat_Concert
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string strC = Console.ReadLine();
            string strS = Console.ReadLine();
            string temp2 = strC[0].ToString() + strC[1].ToString();
            int C = Convert.ToInt32(temp2);
            temp2 = strS[0].ToString() + strS[1].ToString();
            int S = Convert.ToInt32(temp2);
            bool[] contCats = new bool[C];
            List<string> lines = new List<string>();
            string line = Console.ReadLine();

            while (line != "Mew!")
            {
                lines.Add(line);
                line = Console.ReadLine();
            }

            int[] array = new int[S];
            var songs = new List<List<int>>();
            for (int i = 0; i < S; i++)
            {
                List<int> kkk = new List<int>{0};
                songs.Add(kkk);
            }
            for (int i = 0; i < lines.Count; i++)
            {
                string[] brr = lines[i].Split(' ');
                int[] temp = new int[2];
                int ind = 0;
                for (int p = 0; p < brr.Length; p++)
                {
                    if (Char.IsDigit(brr[p][0]))
                    {
                        temp[ind] = int.Parse(brr[p]);
                        ind++;
                    }
                }
                if (songs[temp[1]-1][0] == 0)
                {
                    songs[temp[1] - 1][0] = temp[0];
                }
                else
                {
                    songs[temp[1] - 1].Add(temp[0]);
                }
                
            }

            int well = 0;
            for (int i = 0; i < songs.Count; i++)
            {
                bool tempBool = false;
                for (int j = 1; j <= C; j++)
                {
                    if (songs[i].Contains(j) && !contCats[j - 1])
                    {
                        contCats[j - 1] = true;
                        tempBool = true;
                    }
                    if (tempBool)
                    {
                        well++;
                        tempBool = false;
                    }
                }
            }
           
            if (songs.Max(e => e.Count) == C)
            {
                Console.WriteLine(1);
            }
            else if (!contCats.Contains(false))
            {
                Console.WriteLine(well);
            }
            else
            {
                Console.WriteLine("No concert!");
            }
            
        }
    }
}
