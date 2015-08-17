using System;
//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

namespace _11.Exercise
{
    class SwapNum
    {
        static void Main(string[] args)
        {
            int firstNum = 5; 
            int secondNum = 10;
            int temp; // This will help us to swap the first and second number

            Console.WriteLine("First number is: " + firstNum +" and the second number is: " + secondNum); 
            temp = firstNum;          //
            firstNum = secondNum;    // Swaping
            secondNum = temp;       //

            Console.WriteLine("Now the first number is: " + firstNum+" and the second number is: " + secondNum); // The result
        }
    }
}
