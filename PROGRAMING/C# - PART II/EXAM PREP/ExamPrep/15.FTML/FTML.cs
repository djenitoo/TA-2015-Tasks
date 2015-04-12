using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTML
{
    class Program
    {
        const string revTagOpen = "<rev>";
        const string upperTagOpen = "<upper>";
        const string lowerTagOpen = "<lower>";
        const string toggleTagOpen = "<toggle>";
        const string delTagOpen = "<del>";

        const string revTagClose = "</rev>";
        const string upperTagClose = "</upper>";
        const string lowerTagClose = "</lower>";
        const string toggleTagClose = "</toggle>";
        const string delTagClose = "</del>";

        static List<string> currentOpenedTags = new List<string>();
        static List<int> revTagContentStarts = new List<int>();
        static int openedDelTags = 0;


        static string GetTag(string s, int searchStartInd)
        {
            int tagStart = 0;
            if (s[searchStartInd] == '<')
            {
                tagStart = searchStartInd;
            }

            int tagLast = s.IndexOf('>', tagStart + 1);

            string tag = s.Substring(tagStart, tagLast - tagStart + 1);

            return tag;
        }

        static bool IsClosing(string tag)
        {
            return tag[1] == '/';
        }

        static void Reverse(StringBuilder sb, int first, int lastInclusive)
        {
            int leftInd = first,
                rightInd = lastInclusive;

            while (leftInd < rightInd)
            {
                char leftBuffer = sb[leftInd];
                sb[leftInd] = sb[rightInd];
                sb[rightInd] = leftBuffer;

                leftInd++;
                rightInd--;
            }
        }

        static char GetAppliedTagEffect(char symbol, string tag)
        {
            char resultSymbol = symbol;
            if (Char.IsLetter(resultSymbol))
            {
                switch (tag)
                {
                    case lowerTagOpen: resultSymbol = Char.ToLower(symbol); break;
                    case upperTagOpen: resultSymbol = Char.ToUpper(symbol); break;

                    case toggleTagOpen:
                        if (Char.IsLower(symbol))
                        {
                            resultSymbol = Char.ToUpper(symbol);
                        }
                        else
                        {
                            resultSymbol = Char.ToLower(symbol);
                        }
                        break;
                }
            }
            return resultSymbol;
        }

        private static void ProcessTag(StringBuilder result, string tag)
        {
            if (tag == delTagOpen)
            {
                openedDelTags++;
            }
            else if (tag == delTagClose)
            {
                openedDelTags--;
            }
            else
            {
                if (openedDelTags == 0)
                {
                    if (tag == revTagOpen)
                    {
                        revTagContentStarts.Add(result.Length);
                    }
                    else if (tag == revTagClose)
                    {
                        int currentRevContentStart = revTagContentStarts[revTagContentStarts.Count - 1];
                        Reverse(result, currentRevContentStart, result.Length - 1);
                        RemoveLastRevTagContentStart();
                    }
                    else if (IsClosing(tag))
                    {
                        RemoveLastCurrentWrappingTag();
                    }
                    else
                    {
                        currentOpenedTags.Add(tag);
                    }
                }
            }
        }

        static void RemoveLastRevTagContentStart()
        {
            revTagContentStarts.RemoveAt(revTagContentStarts.Count - 1);
        }

        static void RemoveLastCurrentWrappingTag()
        {
            currentOpenedTags.RemoveAt(currentOpenedTags.Count - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string currLine = Console.ReadLine();

                int inputSymbolInd = 0;
                while (inputSymbolInd < currLine.Length)
                {
                    if (currLine[inputSymbolInd] == '<')
                    {
                        string tag = GetTag(currLine, inputSymbolInd);

                        ProcessTag(result, tag);

                        int tagLastInd = inputSymbolInd + tag.Length - 1;
                        inputSymbolInd = tagLastInd;
                    }
                    else
                    {
                        if (openedDelTags == 0)
                        {
                            char symbolToAdd = currLine[inputSymbolInd];
                            for (int tagInd = currentOpenedTags.Count - 1; tagInd >= 0; tagInd--)
                            {
                                symbolToAdd = GetAppliedTagEffect(symbolToAdd, currentOpenedTags[tagInd]);
                            }

                            result.Append(symbolToAdd);
                        }
                    }

                    inputSymbolInd++;
                }

                result.Append("\n");
            }

            result.Replace("\n", Environment.NewLine);

            Console.Write(result.ToString());
        }
    }
}
/*
1
<del><rev><rev>here</rev></rev><del>nothing</del>still nothing</del><upper><del>nothing</del><rev>emos</rev><del>some</del>thing</upper>
*/
/*
3
<del><rev></rev></del><upper>Shalalalalalalalalallalalalalalallallalalalalalala</upper>
sha
lala
/*
1
<rev>All right everyone, line up alphabetically according to your height</rev>
*/
/*
1
<rev>My fake plants died because I did not pretend to water them.</rev>
*/


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _15.FTML
//{
//    class FTML
//    {
//        static List<string> openedTags = new List<string>();
//        static void Main(string[] args)
//        {
//            int N = int.Parse(Console.ReadLine());
//            List<string> array = new List<string>();
//            StringBuilder wholeText = new StringBuilder();
//            for (int i = 0; i < N; i++)
//            {
//                string str = Console.ReadLine();
//                array.Add(str);
//                wholeText.Append(str + "</newLine>");
//            }

//            processFTMLOneString(wholeText);
//        }
//        private static void processFTMLOneString(StringBuilder wholeText)
//        {
//            string[] sep = { "<", ">" };
//            List<string> tags = new List<string> { "upper", "lower", "toggle", "del", "rev" };
//            //for (int i = 0; i < array.Count; i++)
//            //{
//                string[] splitedStr = wholeText.Split(sep, StringSplitOptions.RemoveEmptyEntries);
//                //Console.WriteLine(string.Join(", ", splitedStr));

//                int index;
//                //Console.WriteLine(index);
//                while (Array.FindIndex(splitedStr, x => x.StartsWith("/") && x != "/newLine") != -1)
//                {
//                    index = Array.FindIndex(splitedStr, x => x.StartsWith("/") && x != "/newLine");
//                    int firstTag = index - 2;
//                    if (splitedStr[index] == "/" + splitedStr[index - 1])
//                    {
//                        var list = new List<string>(splitedStr);
//                        list.RemoveAt(index);
//                        list.RemoveAt(firstTag + 1);
//                        splitedStr = list.ToArray();
//                        continue;
//                    }
//                    splitedStr = FormatFTMLText(splitedStr, firstTag, index);
//                }
//                string teem = "";
//                foreach (string item in splitedStr)
//                {
//                    teem += item;
//                }
//            string[] brr = new string[] { "/newLine", "/NEWLINE", "/newline", "/nEwLiNe", "/NeWlInE" };
//            splitedStr = teem.Split(brr, StringSplitOptions.RemoveEmptyEntries);
//                foreach (string item in splitedStr)
//                {
//                    Console.WriteLine(item);
//                    //if (brr.Contains(item))
//                    //{
//                    //    Console.WriteLine();
//                    //}
//                    //else
//                    //{
//                    //    Console.WriteLine(item);
//                    //}

//                }
//            //}
//        }

//        private static void processFTML(List<string> array)
//        {
//            string[] sep = { "<", ">" };
//            List<string> tags = new List<string>{ "upper", "lower", "toggle", "del", "rev" }; 
//            for (int i = 0; i < array.Count; i++)
//            {
//                string[] splitedStr = array[i].Split(sep, StringSplitOptions.RemoveEmptyEntries);
//                //Console.WriteLine(string.Join(", ", splitedStr));

//                int index;
//                //Console.WriteLine(index);
//                while (Array.FindIndex(splitedStr, x => x.StartsWith("/")) != -1)
//                {
//                    index = Array.FindIndex(splitedStr, x => x.StartsWith("/"));
//                    int firstTag = index - 2;
//                    if (splitedStr[index] == "/" + splitedStr[index - 1])
//                    {
//                        var list = new List<string>(splitedStr);
//                        list.RemoveAt(index);
//                        list.RemoveAt(firstTag + 1);
//                        splitedStr = list.ToArray();
//                        continue;
//                    }
//                    splitedStr = FormatFTMLText(splitedStr, firstTag, index);
//                }
//                foreach (string item in splitedStr)
//                {
//                    if (item == "")
//                    {
//                        Console.WriteLine();
//                    }
//                    else
//                    {
//                        Console.Write(item);
//                    }

//                }
//                Console.WriteLine();
//            }
//        }

//        private static string[] FormatFTMLText(string[] splitedStr, int firstTag, int index)
//        {
//            List<string> tags = new List<string> { "upper", "lower", "toggle", "del", "rev" }; 
//            string[] temp = splitedStr;
//            var list = new List<string>(temp);
//            switch (splitedStr[firstTag].ToLower())
//            {
//                case "upper":
//                    temp[firstTag + 1] = splitedStr[firstTag + 1].ToUpper();
//                    list = new List<string>(temp);
//                    list.RemoveAt(index);
//                    list.RemoveAt(firstTag);
//                    temp = list.ToArray();
//                    break;
//                case "lower":
//                    temp[firstTag + 1] = splitedStr[firstTag + 1].ToLower();
//                    list = new List<string>(temp);
//                    list.RemoveAt(index);
//                    list.RemoveAt(firstTag);
//                    temp = list.ToArray();
//                    break;
//                case "rev":
//                    char[] chTemp = splitedStr[firstTag + 1].ToCharArray();
//                    Array.Reverse(chTemp);
//                    temp[firstTag + 1] = new string(chTemp);
//                    list = new List<string>(temp);
//                    list.RemoveAt(index);
//                    list.RemoveAt(firstTag);
//                    temp = list.ToArray();
//                    break;
//                case "del":
//                    list = new List<string>(temp);
//                    list.RemoveRange(firstTag, 3);
//                    temp = list.ToArray();
//                    break;
//                case "toggle":
//                    StringBuilder str = new StringBuilder();
//                    for (int i = 0; i < temp[firstTag+1].Length; i++)
//                    {
//                        if (Char.IsLower(temp[firstTag+1][i]))
//                        {
//                            str.Append(Char.ToUpper(temp[firstTag + 1][i]));
//                        }
//                        else if (Char.IsUpper(temp[firstTag + 1][i]))
//                        {
//                            str.Append(Char.ToLower(temp[firstTag + 1][i]));
//                        }
//                        else
//                        {
//                            str.Append(temp[firstTag + 1][i]);
//                        }
//                    }
//                    temp[firstTag + 1] = str.ToString();
//                    list = new List<string>(temp);
//                    list.RemoveAt(index);
//                    list.RemoveAt(firstTag);
//                    temp = list.ToArray();
//                    break;
//            }
//            if (firstTag + 1 < temp.Length && !temp[firstTag + 1].StartsWith("/") && !tags.Contains(temp[firstTag + 1]))
//            {
//                list = new List<string>(temp);
//                list[firstTag] = list[firstTag] + list[firstTag + 1];
//                list.RemoveAt(firstTag + 1);
//                temp = list.ToArray();
//            }
//            if (firstTag - 1 >= 0 && !temp[firstTag - 1].StartsWith("/") && !tags.Contains(temp[firstTag - 1]))
//            {
//                list = new List<string>(temp);
//                list[firstTag - 1] = list[firstTag - 1] + list[firstTag];
//                list.RemoveAt(firstTag);
//                temp = list.ToArray();
//            }
//            return temp;
//        }
//    }
//}
