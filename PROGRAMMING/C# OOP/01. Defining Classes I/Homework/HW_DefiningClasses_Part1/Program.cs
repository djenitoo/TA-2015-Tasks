namespace HW_DefiningClasses_Part1
{
    using System;

    public class Program
    {
        static void Main()
        {
            //var gsm = new GSM("Sony", "AI Enterprise");
            //Console.WriteLine(gsm.ToString());

            //TASK 7 - TEST GSM
            GSMtest.ShowGSMsInfo();
            GSMtest.ShowIPhoneInfo();

            // TASK 12 - TEST CALL HISTORY
            GSMCallHistoryTest.AddCalls();
            GSMCallHistoryTest.DisplayCallHistory();
            GSMCallHistoryTest.CalculateAndPrintTotalPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            GSMCallHistoryTest.CalculateAndPrintTotalPrice();
            GSMCallHistoryTest.ClearHistory();
            Console.WriteLine();
            GSMCallHistoryTest.DisplayCallHistory();
            Console.WriteLine();
        }
    }
}
