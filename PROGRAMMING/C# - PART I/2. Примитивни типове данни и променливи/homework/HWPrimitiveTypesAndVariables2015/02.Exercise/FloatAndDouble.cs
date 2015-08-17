using System;
//Which of the following values can be assigned to a variable of type float and 
//which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091

namespace _02.Exercise
{
    class FloatAndDouble
    {
        static void Main(string[] args)
        {
            double a = 34.567839023; // because there are more than 6 characters after the decimal point
            float b = 12.345f; // because there are less than 6 characters after the decimal point
            double c = 8923.1234857; // because there are more than 6 characters after the decimal point
            float d = 3456.091f; // because there are less than 6 characters after the decimal point

            Console.WriteLine("double -> {0} \n float -> {1} \n double -> {2} \n float -> {3}",a,b,c,d); // Write the final result

        }
    }
}
