namespace HW_DefiningClasses_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSMCallHistoryTest
    {
        // TASK 12
        private static GSM gsm;

        public static void AddCalls()
        {
            gsm = new GSM("Lumnia", "Nokia");
            
            var call = new Call(new DateTime(2015, 05, 14, 13, 20, 15), "+359889966543", 260);
            gsm.AddCall(call);

            call = new Call(new DateTime(2014, 06, 20, 05, 13, 16), "+359889966654", 15);
            gsm.AddCall(call);

            call = new Call(new DateTime(2013, 07, 16, 15, 13, 12), "+359889966654", 220);
            gsm.AddCall(call);
            
            gsm.CallHistory = gsm.CallHistory.OrderBy(o => o.Date).ToList();
        }

        public static void DisplayCallHistory()
        {
            Console.WriteLine("Call History:");
            if (gsm.CallHistory.Count == 0)
            {
                Console.WriteLine("-No history to show-");
            }
            else
            {
                foreach (Call item in gsm.CallHistory)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            
        }

        public static void CalculateAndPrintTotalPrice(decimal price = 0.37M)
        {
            decimal totalPrice = gsm.TotalCallPrice(price);

            Console.WriteLine("Total price for the call duration is " + totalPrice);
        }

        public static void RemoveLongestCall()
        {
            gsm.CallHistory = gsm.CallHistory.OrderByDescending(o => o.Duration).ToList(); //order calls by duration
            gsm.DeleteCall(0); // remove first call with longest duration
            gsm.CallHistory = gsm.CallHistory.OrderBy(o => o.Date).ToList(); // return order of call to order by date
        }

        public static void ClearHistory()
        {
            gsm.ClearCallHistory();
        }
    }
}
