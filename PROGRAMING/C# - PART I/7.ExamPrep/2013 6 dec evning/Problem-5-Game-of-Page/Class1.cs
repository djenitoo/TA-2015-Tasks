using System;
using System.Collections.Generic;
using System.Text;

class GameOfPage
{
    static void Main()
    {

        string trail = Console.ReadLine();
        List<string> input = new List<string>();
        while (trail != "paypal")
        {
            input.Add(trail);
            trail = Console.ReadLine();
        }
        input.Add(trail);
        string[] arr = new string[input.Count];
        for (int i = 0; i < input.Count; i++)
        {
            arr[i] = input[i];
        }
        int currentCaseCounter = 0;
        string currentCase = "";
        decimal buyCookie = 0m;
        int row = 0, col = 0;
        string result = "";
        for (int i = 16; i < arr.Length - 1; i++)
        {
            if (currentCaseCounter == 0)
            {
                currentCase = arr[i];
                currentCase = currentCase.Trim();
                currentCaseCounter = 2;
            }
            else
            {
                currentCaseCounter--;
            }
            switch (currentCase)
            {
                case "what is":
                    currentCase = "";
                    row = Convert.ToInt16(arr[i + 1]);
                    col = Convert.ToInt16(arr[i + 2]);
                    if (arr[row][col] == '0')
                    {
                        //Console.WriteLine("smile");
                        //Console.WriteLine(arr[row].Length-1);
                        result += "smile" + "\n";
                    }
                    else
                    {
                        if (col > 0 && col < 15 && row > 0 && row < 15) // possible coockie or  cookie crumb or broken cookie
                        {
                            int rowCookie = row - 1, colCookie = col - 1, cookieCountRow = 3, cookieCountCol = 3;
                            bool cookie = true;
                            byte crumbsCount = 0;
                            while (cookieCountRow > 0)
                            {
                                cookieCountCol = 3;
                                colCookie = col - 1;
                                while (cookieCountCol > 0)
                                {
                                    if (arr[rowCookie][colCookie] == '0')
                                    {
                                        cookie = false;
                                        //break;
                                    }
                                    else
                                    {
                                        crumbsCount++;
                                    }
                                    cookieCountCol--;
                                    colCookie++;
                                }
                                rowCookie++;
                                cookieCountRow--;
                            }
                            if (cookie && crumbsCount == 9)
                            {
                                //Console.WriteLine("cookie");
                                result += "cookie" + "\n";
                            }
                            else
                            {
                                if (crumbsCount < 2)
                                {
                                    //Console.WriteLine("cookie crumb");
                                    result += "cookie crumb" + "\n";
                                }
                                else
                                {
                                    //Console.WriteLine("broken cookie");
                                    result += "broken cookie" + "\n";
                                }
                            }
                        }
                        else // cookie crumb or broken cookie
                        {
                            switch (row)
                            {
                                case 0:
                                    switch (col)
                                    {
                                        case 0:
                                            if (arr[row + 1][col] == '1' || arr[row][col + 1] == '1' || arr[row + 1][col + 1] == '1')
                                            {
                                                //Console.WriteLine("broken cookie");
                                                result += "broken cookie" + "\n";
                                            }
                                            else
                                            {
                                                //Console.WriteLine("cookie crumb");
                                                result += "cookie crumb" + "\n";
                                            }
                                            break;
                                        case 15:
                                            if (arr[row + 1][col] == '1' || arr[row][col - 1] == '1' || arr[row + 1][col - 1] == '1')
                                            {
                                                //Console.WriteLine("broken cookie");
                                                result += "broken cookie" + "\n";
                                            }
                                            else
                                            {
                                                //Console.WriteLine("cookie crumb");
                                                result += "cookie crumb" + "\n";
                                            }
                                            break;
                                        default:
                                            if (arr[row][col + 1] == '1' || arr[row][col - 1] == '1' || arr[row + 1][col] == '1' || arr[row + 1][col + 1] == '1' || arr[row + 1][col - 1] == '1')
                                            {
                                                //Console.WriteLine("broken cookie");
                                                result += "broken cookie" + "\n";
                                            }
                                            else
                                            {
                                                //Console.WriteLine("cookie crumb");
                                                result += "cookie crumb" + "\n";
                                            }
                                            break;
                                    }
                                    break;
                                case 15:
                                    switch (col)
                                    {
                                        case 0:
                                            if (arr[row - 1][col] == '1' || arr[row][col + 1] == '1' || arr[row - 1][col + 1] == '1')
                                            {
                                                //Console.WriteLine("broken cookie");
                                                result += "broken cookie" + "\n";
                                            }
                                            else
                                            {
                                                //Console.WriteLine("cookie crumb");
                                                result += "cookie crumb" + "\n";
                                            }
                                            break;
                                        case 15:
                                            if (arr[row - 1][col] == '1' || arr[row][col - 1] == '1' || arr[row - 1][col - 1] == '1')
                                            {
                                                //Console.WriteLine("broken cookie");
                                                result += "broken cookie" + "\n";
                                            }
                                            else
                                            {
                                                //Console.WriteLine("cookie crumb");
                                                result += "cookie crumb" + "\n";
                                            }
                                            break;
                                        default:
                                            if (arr[row][col + 1] == '1' || arr[row][col - 1] == '1' || arr[row - 1][col] == '1' || arr[row - 1][col - 1] == '1' || arr[row - 1][col + 1] == '1')
                                            {
                                                //Console.WriteLine("broken cookie");
                                                result += "broken cookie" + "\n";
                                            }
                                            else
                                            {
                                                //Console.WriteLine("cookie crumb");
                                                result += "cookie crumb" + "\n";
                                            }
                                            break;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case "buy":
                    currentCase = "";
                    row = Convert.ToInt16(arr[i + 1]);
                    col = Convert.ToInt16(arr[i + 2]);
                    if (col > 0 && col < 15 && row > 0 && row < 15) // possible coockie or  cookie crumb or broken cookie
                    {
                        int rowCookie = row - 1, colCookie = col - 1, cookieCountRow = 3, cookieCountCol = 3;
                        bool cookie1 = true;
                        byte crumbsCount1 = 0;
                        while (cookieCountRow > 0)
                        {
                            cookieCountCol = 3;
                            colCookie = col - 1;
                            while (cookieCountCol > 0)
                            {
                                if (arr[rowCookie][colCookie] == '0')
                                {
                                    cookie1 = false;
                                    //break;
                                }
                                else
                                {
                                    crumbsCount1++;
                                }
                                cookieCountCol--;
                                colCookie++;
                            }
                            rowCookie++;
                            cookieCountRow--;
                        }
                        if (cookie1 && crumbsCount1 == 9)
                        {
                            rowCookie = row - 1; colCookie = 0; cookieCountRow = 3; cookieCountCol = 16;
                            int startCol = col - 1;
                            string change = "";
                            while (cookieCountRow > 0)
                            {
                                colCookie = 0;
                                cookieCountCol = 16;
                                change = "";
                                while (cookieCountCol > 0)
                                {
                                    if (colCookie >= startCol && colCookie < startCol + 3)
                                    {
                                        change += '0';
                                    }
                                    else
                                    {
                                        change += arr[rowCookie][colCookie];
                                    }
                                    colCookie++;
                                    cookieCountCol--;
                                }
                                cookieCountRow--;
                                arr[rowCookie] = change;
                            }

                            buyCookie += 1.79M;
                        }
                        else
                        {
                            //Console.WriteLine("page");
                            result += "page" + "\n";
                        }
                    }
                    else
                    {
                        //Console.WriteLine("page");
                        result += "page" + "\n";
                    }
                    break;
                case "paypal":
                    currentCase = "";
                    break;
                default:
                    break;
            }
        }
        //Console.WriteLine("{0:0.00}",buyCookie);
        result += buyCookie.ToString("0.00");
        Console.WriteLine(result);
    }
}