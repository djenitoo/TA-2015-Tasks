//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05.Doge
//{
//    class Program
//    {
//        static void Main()
//        {
//            string num = Console.ReadLine();
//            string[] arr = num.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            int[] nums = arr.Select(str => (int.Parse(str))).ToArray();
//            int N = nums[0];
//            int M = nums[1];
//            int K = int.Parse(Console.ReadLine());
//            int F = int.Parse(Console.ReadLine());

            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.KaspichanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphabetLowCase = alphabet.ToLower();
           
           //Console.WriteLine("Enter: ");
           BigInteger letter = BigInteger.Parse(Console.ReadLine());
           BigInteger temp = letter;
           BigInteger newTemp = letter;
           StringBuilder bubulechi = new StringBuilder();
           string tempBukva = "";
           int  index ;

           if (letter < 256)
           {
               for (int i = 0; i < alphabet.Length; i++)
               {
                   if (letter > alphabet.Length - 1)
                   {
                       letter = letter % alphabet.Length;
                       index =(int)(temp / 26);
                       char first = alphabetLowCase[index - 1];
                       Console.Write(first);
                       if (letter == i)
                       {
                           Console.WriteLine(alphabet[i]);
                           break;
                       }
                   }
                   if (letter == i)
                   {
                       Console.WriteLine(alphabet[i]);
                       break;
                   }
					
               }
           }
           else
           {
               BigInteger remainder = 0;
               
               while (newTemp > 0)
               {
                   remainder = newTemp % 256;
                   newTemp = newTemp / 256;
				   // tova proverqva remaindera dali e po-golqmo ot daljinata na azbukata t.e. dali chisloto e za 2 bukvi
				   if (remainder > alphabet.Length - 1)
                   {
                       int oneMoreTemp = (int)remainder % alphabet.Length;
                       index = (int)(remainder / 26);
                       //char first = alphabetLowCase[index - 1];
                       tempBukva = alphabetLowCase[index - 1].ToString() + alphabet[(int)oneMoreTemp] + tempBukva; //here to string bc if we + two chars they became their int representation
                        // taka v stringa noviq lower char i upper char se dobavqt otpred
                   }
                   else
                   {
                       tempBukva = alphabet[(int)remainder] + tempBukva;
                   }
               }
              Console.Write(tempBukva);
           }
           
       }
            
    }
}

//        }
//    }
//}
