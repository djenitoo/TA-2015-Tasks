using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
// Write a program for extracting all email addresses from given text.
// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = "An email address such as John.Smith@example.com is made up of a local part, an @ sign, then a domain part. niceandsimple@example.com le.style.email.with+symbol@example.com";

            foreach (var item in Regex.Matches(text, @"[\w.-_+]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}")) // by  kristina.bankova
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
