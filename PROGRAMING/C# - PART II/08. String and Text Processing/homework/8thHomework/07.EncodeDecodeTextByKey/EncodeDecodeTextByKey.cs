using System;
using System.Text;
//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by
//performing XOR (exclusive or) operation over the first letter of the string with
//the first of the key, the second – with the second, etc. When the last key
//character is reached, the next is the first.

namespace _07.EncodeDecodeTextByKey
{
    class EncodeDecodeTextByKey
    {
        static void Main()
        {
            string text = "Write a program that encodes and decodes a string using given encryption key (cipher). ";
            string key = "abc";
            StringBuilder text1 = new StringBuilder();
            text1.Append(text);

            Console.Write("The ENCODED text is: " + EncodeText(text1, key) + "\r\n\r\n");
            Console.Write("The DECODED text is: " + EncodeText(EncodeText(text1, key), key) + "\r\n");
            
        }
        static StringBuilder EncodeText(StringBuilder text, string key)
        {
            StringBuilder mainKey = new StringBuilder();
            while (mainKey.Length <= text.Length) // making the length of key == length of text by repeating
            {
                mainKey.Append(key);
            }
            while (mainKey.Length > text.Length) // if the length of key is > of the length of key, then we remove the last char until
            {                                   // the lengths are equal
                mainKey.Length--;
            }
            key = mainKey.ToString();          // the short key get the value == of the length of the text

            char[] encodedArr = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                encodedArr[i] = (char)(text[i] ^ key[i]);
            }

            StringBuilder encodedText = new StringBuilder();
            foreach (char ch in encodedArr)
            {
                encodedText.Append(ch);
            }
            return encodedText;
        }
    }
}
