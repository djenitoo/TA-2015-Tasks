namespace Deffining_Classes_2.VersionAttr
{
    using System;
    using System.Reflection;

    [Version("01.120313")]
    public class Test
    {
        
    }

    public static class Mainie
    {
        public static void Main2()
        {
            System.Reflection.MemberInfo info = typeof(Test);
            foreach (object attribute in info.GetCustomAttributes(true))
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
