using System;
class ANacci2
{
    static void Main(string[] args)
    {
        int shift = 64;
        string first = Console.ReadLine();
        int one = first[0] - shift;
        string second = Console.ReadLine();
        int two = second[0] - shift;
        int row = int.Parse(Console.ReadLine());

        Console.WriteLine(first);

        if (row > 1)
        {
            Console.Write(second);
            int next = one + two;
            if (next > 26)
            {
                next = next % 26;
            }
            Console.WriteLine((char)(next + shift));
            one = two;
            two = next;
            for (int i = 3; i <= row; i++)
            {
                next = one + two;
                if (next > 26)
                {
                    next = next % 26;
                }
                one = two;
                two = next;
                Console.Write((char)(next + shift));

                Console.Write(new String(' ', i - 2));

                next = one + two;
                if (next > 26)
                {
                    next = next % 26;
                }
                one = two;
                two = next;
                Console.WriteLine((char)(next + shift));
            }
        }
        
    }
}
