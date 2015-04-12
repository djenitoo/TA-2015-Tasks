using System;
// Write a program that prints to the console which day of the week is today. Use System.DateTime.


namespace _03._DayOfTheWeek
{
    class DayOfTheWeek
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is {0}.", today.DayOfWeek);
        }
    }
}
