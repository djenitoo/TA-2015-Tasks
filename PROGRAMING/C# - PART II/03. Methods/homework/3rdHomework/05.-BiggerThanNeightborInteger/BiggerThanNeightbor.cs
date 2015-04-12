using System;
// Write a method that checks if the element at given position 
// in given array of integers is bigger than its two neighbors (when such exist).


namespace _05._BiggerThanNeightborInteger
{
    public class BiggerThanNeightbor
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array:");
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the position<0,{0}>: ", length - 1);
            int position = int.Parse(Console.ReadLine());

            Console.WriteLine(Comparing(array, position));
        }

        public static string Comparing(int[] array, int position)
        {
            if (position == 0)
            {
                if (array[position] > array[1])
                {
                    return "yes";
                }
                else 
                {
                    return "no";
                }
            }
            if ((position != 0) && (position != (array.Length - 1)))
            {
                if ((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
                {
                    return "yes";
                }
                else 
                {
                    return "no";
                }
            }
            if (position == array.Length - 1)
            {
                if (array[position] > array[position - 1])
                {
                    return "yes";
                }
                else
                {
                    return "no";
                }
            }
            return "no";
        }
    }
}
