using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _16.NumberOfDaysBWDates
{
    class NumberOfDaysBWDates
    {
        static void Main()
        {
            Console.WriteLine("Enter a date (ex. 15.04.2004)");
            string firstDate = Console.ReadLine();
            Console.WriteLine("Enter a second date (ex. 16.04.2004)");
            string secondDate = Console.ReadLine();

            DateTime dateOne = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime dateTwo = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture); // with the little help of jassonpet
            Console.WriteLine((dateTwo - dateOne).TotalDays);
        }
    }
}
