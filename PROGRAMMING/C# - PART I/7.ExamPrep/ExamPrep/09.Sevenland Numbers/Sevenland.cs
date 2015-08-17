using System;

namespace _09.Sevenland_Numbers
{
    class Sevenland
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a; 
            int num = 0;
            int i = 0;
            while (n > 0)
            {
                a = n % 10;
                n = n / 10;
                num += a * (int)Math.Pow(7, i);
                i++;
            }
            num = num + 1;
            int count = 0;
            int size = num;
            int[] arr = new int[size];
            int j = 0;
            while (num >= 1)
            {
                arr[j] = num % 7;
                num = num / 7;
                count++;
                j++;
            }
            for (int k = count - 1; k >= 0; k--)
            {
                Console.Write(arr[k]);
            }
            Console.WriteLine();
        }
    }
}
