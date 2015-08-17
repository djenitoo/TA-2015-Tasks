using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.TimeAfterSixHours
{
    class TimeAfterSixHours
    {
        static void Main()
        {
            //Console.WriteLine("Enter a date (ex. 15.04.2004 20:45:00)");
            //string date = Console.ReadLine();
            string date = "10.10.2010 10:10:00";
            DateTime finalDate = DateTime.ParseExact(date, "d.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            finalDate = finalDate.AddHours(6.5);
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine(finalDate + " " + finalDate.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
