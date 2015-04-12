using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._AppearanceCount
{
    public class AppearanceCount
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = {1,2,3,4,5,6,7,8,39,1,3,5,2,3,7,5,32,112,11,12};

            Console.WriteLine("AppearanceCount = " + CheckAppearance(array, number)); 
        }

        public static int CheckAppearance(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
