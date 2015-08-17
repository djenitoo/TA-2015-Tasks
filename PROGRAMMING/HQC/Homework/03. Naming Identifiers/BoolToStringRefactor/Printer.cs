namespace PrintVariable
{
    using System;

    public class Printer
    {
        private const int MaxCount = 6;
        
        public class PrintBoolean
        {
            public PrintBoolean()
            {
            }

            public void Print(bool boolVariable)
            {
                Console.WriteLine(boolVariable);
            }
        }
    }
}
