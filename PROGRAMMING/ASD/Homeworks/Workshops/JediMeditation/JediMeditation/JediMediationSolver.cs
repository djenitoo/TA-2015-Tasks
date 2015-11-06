using System;
using System.Collections.Generic;

namespace JediMeditation
{
    class JediMediationSolver
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var keys = new char[] { 'm', 'k', 'p'};
            var jediCollection = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var jediMeditiationList = new List<string>();

            for (int i = 0; i < keys.Length; i++)
            {
                for (int j = 0; j < jediCollection.Length; j++)
                {
                    if (keys[i] == jediCollection[j][0])
                    {
                        jediMeditiationList.Add(jediCollection[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", jediMeditiationList));
        }
    }
}
