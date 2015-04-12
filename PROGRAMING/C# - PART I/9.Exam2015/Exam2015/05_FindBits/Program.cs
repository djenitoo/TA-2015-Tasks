using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FindBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            int midCount = 0;
            //uint maskS = (S & 31);
            //uint[] arr = new uint[N];

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                //arr[i] = number;
                if (number < 0)
                {
                    number *= -1;
                }
                
                for (int j = 24; j >= 0; j--)
                {
                    int numb = number>>j;
                    int stemp = S;
                    midCount = 0;
                    for (int p = 0; p < 5; p++)
                    {
                        int temp = numb>>p & 1;
                        int temp2 = stemp>>p & 1;
                        if (temp == temp2)
                        {
                            midCount++;
                        }
                        
                    }
                    if (midCount == 5)
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(count);

            

            
        }
    }
}
