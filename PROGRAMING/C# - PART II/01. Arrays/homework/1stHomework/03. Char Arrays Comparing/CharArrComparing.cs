using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that compares two char arrays lexicographically (letter by letter).

namespace _03.Char_Arrays_Comparing     
{
    class CharArrComparing
    {
        static void Main()
        {
            Console.Write("Please, enter the size of the first array: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the size of the second array: ");
            int M = int.Parse(Console.ReadLine());

            int middle = N;             // will help us to see if the two arrays are not with the same length, if the are not 
                                        // middle will get the value of the smaller array. And the main for loop will be in range 0 - middle.
            bool check = true;

            char[] firstArr = new char[N];
            char[] secondArr = new char[M];

            
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write("Please enter element {0} of the first array: ", i);
                firstArr[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                Console.Write("Please enter element {0} of the second array: ", i);
                secondArr[i] = char.Parse(Console.ReadLine());
            }
            if (N > M)          
            {
                middle = M;
            }
            for (int i = 0; i < middle; i++)
            {
                if ((int)firstArr[i] > (int)secondArr[i])
                {
                    Console.WriteLine("The second array is lexicographically bigger!");
                    check = false;
                    break;
                }
                if ((int)firstArr[i] < (int)secondArr[i])
                {
                    Console.WriteLine("The first array is lexicographically bigger!");
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                if (N < M)
                {
                    Console.WriteLine("The first array is lexicographicaly bigger!");
                }
                if (N > M)
                {
                    Console.WriteLine("The second array is lexicographicaly bigger!");
                }
                else
                {
                    Console.WriteLine("The arrays are equal!");
                }
            }
            
        }
    }
}
