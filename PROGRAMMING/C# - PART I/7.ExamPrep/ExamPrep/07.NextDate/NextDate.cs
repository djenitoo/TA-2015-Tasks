using System;

namespace _07.NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime givenTime = new DateTime(year, month, day);
            givenTime = givenTime.AddDays(1);

            Console.WriteLine(givenTime.Day + "." + givenTime.Month + "." + givenTime.Year);
        }
    }
}
