using System;
using _05._BiggerThanNeightborInteger;
// Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
// Use the method from the previous exercise.


namespace _06._FirstIntegerBiggerThanItsNeightbor
{
    class FirstBiggerInt
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
            //int result = Comparing(array);

            int position = 0;
            for (position = 0; position < array.Length; position++)
            {
                string output = BiggerThanNeightbor.Comparing(array, position);
                if (output == "yes")
                {
                    break;
                }
            }

            if (position != -1)
            {
                Console.WriteLine("The position is " + position);
            }
            else
            {
                Console.WriteLine("There is no element bigger than its neighbors!");
            }
        }
    }
}
