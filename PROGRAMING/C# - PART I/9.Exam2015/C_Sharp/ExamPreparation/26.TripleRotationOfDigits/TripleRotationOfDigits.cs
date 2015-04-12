using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.TripleRotationOfDigits
{
    class TripleRotationOfDigits
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int numberTemp = K;
            
            for (int i = 1; i <= 3; i++)
            {
                string tempString = numberTemp.ToString();
                string rotation = tempString.Remove(tempString.Length - 1);
                rotation = tempString[tempString.Length - 1] + rotation;
                numberTemp = Convert.ToInt32(rotation);
            }
            Console.WriteLine(numberTemp);
        }
    }
}
