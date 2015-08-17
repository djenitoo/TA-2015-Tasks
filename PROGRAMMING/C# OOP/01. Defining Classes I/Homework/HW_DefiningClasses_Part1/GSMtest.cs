namespace HW_DefiningClasses_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMtest
    {
        // TASK 7
        private static List<GSM> gsmInstances;

        private static void CreateInstances()
        {
            gsmInstances = new List<GSM>();

            GSM gsm = new GSM("Sony Experia", "Sony");
            gsmInstances.Add(gsm);

            gsm = new GSM("Lumnia", "Nokia", 50M, null, new Battery(null, 26, 15));
            gsmInstances.Add(gsm);

            gsm = new GSM("Galaxy 6", "Samsung", 1000M, "Gerasimo", null, new Display(7, 200000000));
            gsmInstances.Add(gsm);
        }

        public static void ShowGSMsInfo()
        {
            CreateInstances();

            foreach (GSM gsmA in gsmInstances)
            {
                Console.WriteLine(gsmA.ToString());
            }
        }

        public static void ShowIPhoneInfo()
        {
            Console.WriteLine(GSM.IPhone4S.ToString());
        }

    }
}
