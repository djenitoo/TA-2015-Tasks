using System;
using System.Text;
//Write a program that extracts from a given text all sentences containing given word.
//        Example: The word is "in". The text is:
//                  We are living in a yellow submarine. We don't have anything else. Inside the submarine is 
//                  very tight. So we are drinking all the day. We will move out of it in 5 days.
//        The expected result is:
//                  We are living in a yellow submarine.
//                  We will move out of it in 5 days.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.


namespace _08.ExactSentencesWithGivenWord
{
    class ExtractsSentencesWithGivenWord
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string givenWord = "in";

            ExtractSentences(text, givenWord);
        }

        static void ExtractSentences(string text, string givenWord)
        {
            string[] separators = {". ", "."};
            string[] array = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                string[] midArr = array[i].Split(',', ' ');
                bool thereIsGivenWord = false;
                foreach (string str in midArr)
                {
                    if (str == givenWord)
                    {
                        thereIsGivenWord = true;
                    }
                }
                if (thereIsGivenWord)
                {
                    Console.Write(array[i] + ". ");
                }
            }
            Console.WriteLine();
        }
    }
}
