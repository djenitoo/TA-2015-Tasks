using System;
// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.


namespace _03.Min_Max_of_Seq_Numbers
{
    class SeqNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max;
            int min;
            int sum = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++ )
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
                sum += arr[i];
            }

            Console.WriteLine("Max number: {0} \nMin number: {1}\nSum is:{2}\nAvg is:{3:F2}", max, min, sum, sum/2);

        }
    }
}
