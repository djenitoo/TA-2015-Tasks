namespace Homework3.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class SubstringExtensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder temp = new StringBuilder();
            
            for (int i = index; i < index + length; i++)
            {
                temp.Append(str[i]);
            }

            return temp;
        }
    }
}
