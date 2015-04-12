using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Workdays
{
    class Workdays
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Enter date in format DD/MM/YYYY: ");
            //string strDate = Console.ReadLine();
            //DateTime date = Convert.ToDateTime(strDate);
            DateTime date = new DateTime(2015, 12, 26);
            DateTime today = DateTime.Now;
            List<DateTime> arr = new List<DateTime>();
            arr.Add(new DateTime(today.Year, 1, 1));
            arr.Add(new DateTime(today.Year, 3, 3));
            arr.Add(new DateTime(today.Year, 5, 1));
            arr.Add(new DateTime(today.Year, 5, 5));
            arr.Add(new DateTime(today.Year, 5, 12));
            arr.Add(new DateTime(today.Year, 5, 6));
            arr.Add(new DateTime(today.Year, 5, 24));
            arr.Add(new DateTime(today.Year, 9, 6));
            arr.Add(new DateTime(today.Year, 9, 22));
            arr.Add(new DateTime(today.Year, 11, 1));
            arr.Add(new DateTime(today.Year, 12, 24));
            arr.Add(new DateTime(today.Year, 12, 25));
            arr.Add(new DateTime(today.Year, 12, 26));
            //bool isHolliday = false;
            int workDays = 0;
            //Console.WriteLine(today.AddDays(1));
            if (today < date)
            {
                for (DateTime i = today; i <= date; i = i.AddDays(1))
                {
                    //foreach (DateTime dt in arr)
                    //{
                    //    if (i == dt)
                    //    {
                    //        isHolliday = true;
                    //        break;
                    //    }
                    //}
                    if (!arr.Contains(i) &&  i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                    {
                        workDays++;
                    }
                    //isHolliday = false;
                }

                Console.WriteLine("Workdays are = " + workDays);
            }
            else
            {
                Console.WriteLine("The date was not after today!");
            }
        }
    }
}
