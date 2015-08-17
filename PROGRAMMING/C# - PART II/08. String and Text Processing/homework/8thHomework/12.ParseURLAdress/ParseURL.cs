using System;
using System.Text;
// Write a program that parses an URL address given in the format:
// [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements. 
// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		[protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"

namespace _12.ParseURLAdress
{
    class ParseURL
    {
        static void Main()
        {
            string url = "http://www.devbg.org/forum/index.php";
            string[] separators = { "://", "/" };
            string[] array = url.Split(separators, 3, StringSplitOptions.None);
            Console.WriteLine("[protocol] = {0} \n[server] = {1} \n[resource] = /{2}", array[0], array[1], array[2]); // the idea is of http://pastebin.com/wrivhSw1
        }
    }
}
