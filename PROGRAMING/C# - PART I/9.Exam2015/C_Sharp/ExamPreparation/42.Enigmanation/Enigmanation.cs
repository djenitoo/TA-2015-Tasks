using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Enigmanation
{
    class Enigmanation
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            
            int sum = 0;
            int i = 0;
            bool brackes = false;
            //int sumOfBrackes = 0;
            
            //while (expression[i] != '=')
            //{
            //    bool letter = char.IsLetter(expression[i]);
            //    switch (expression[i])
            //    {
                        
            //        case '(':
            //            // slaga rezultata v promenliva Skobi
            //            break;
            //        case ')':
            //            //spira da polzva sumOfbr i go zanulqva
            //            break;
            //        case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9':
            //            // sum or brsum + operation + next digit
            //            break;
            //        case '+': case '-': case '*': case '%':
            //            // zapazva current operation
            //            break;
            //        default:
            //            break;
            //    }
            //}

            int innerSum = 0;
            int currDigit = 0;
            int outerDigit = 0;
            //char nextDigit = 0;
            char innerOperator = '+';
            char outerOperator = '+';
            for (int j = 0; j < expression.Length; j++)
            {
                if (char.IsLetter(expression[j]))
                {
                    continue;
                }
                else
                {
                    #region Brackets expression
                    if (expression[j] == '(')
                    {
                        j++;
                        while (expression[j] != ')')
                        {
                            
                            if ((expression[j] >= '0' && expression[j] <= '9') || expression[j] == '+' 
                                || expression[j] == '-' || expression[j] == '*' || expression[j] == '%')
                            {
                                if ((expression[j] >= '0' && expression[j] <= '9'))
                                {
                                    currDigit = (int)expression[j] - (int)('0');
                                    
                                    if (innerOperator == '+')
                                    {
                                        innerSum += currDigit;
                                    }
                                    else if (innerOperator == '-')
                                    {
                                        innerSum -= currDigit;
                                    }
                                    else if (innerOperator == '*')
                                    {
                                        innerSum *= currDigit;
                                    }
                                    else if (innerOperator == '%')
                                    {
                                        innerSum %= currDigit;
                                    }
                                }
                                else
                                {
                                    

                                    innerOperator = expression[j];
                                }
                            }
                            j++;
                        }

                        if (outerOperator == '+')
                        {
                            sum += innerSum;
                        }
                        else if (outerOperator == '-')
                        {
                            sum -= innerSum;
                        }
                        else if (outerOperator == '*')
                        {
                            sum *= innerSum;
                        }
                        else if (outerOperator == '%')
                        {
                            sum %= innerSum;
                        }
                        innerOperator = '+';
                        innerSum = 0;
                    }
                    #endregion

                    if (char.IsDigit(expression[j]) || expression[j] == '+' || expression[j] == '-' 
                        || expression[j] == '*' || expression[j] == '%')
                    {
                        if (char.IsDigit(expression[j]))
                        {
                            outerDigit = (int)expression[j] - (int)('0');

                            if (outerOperator == '+')
                            {
                                sum += outerDigit;
                            }
                            else if (outerOperator == '-')
                            {
                                sum -= outerDigit;
                            }
                            else if (outerOperator == '*')
                            {
                                sum *= outerDigit;
                            }
                            else if (outerOperator == '%')
                            {
                                sum %= outerDigit;
                            }
                        }
                        else
                        {
                            

                            outerOperator = expression[j];
                        }
                    }
                }
            }

            Console.WriteLine("{0:F3}", sum);
        }
    }
}
