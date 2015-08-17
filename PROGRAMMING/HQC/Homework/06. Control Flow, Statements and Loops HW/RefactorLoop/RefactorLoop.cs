namespace RefactorLoop
{
    using System;

    public class RefactorLoop
    {
        public static void Main()
        {
            int[] arrayOfIntegers = new int[100];
            ////bool isFound = false;
            int expectedValue = 0;

            for (int i = 0; i < arrayOfIntegers.lenght; i++)
            {
                Console.WriteLine(arrayOfIntegers[i]);

                if (i % 10 == 0 && arrayOfIntegers[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}
