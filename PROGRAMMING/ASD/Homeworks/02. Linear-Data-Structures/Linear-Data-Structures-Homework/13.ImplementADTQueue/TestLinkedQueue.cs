using System;

namespace _13.ImplementADTQueue
{
    class TestLinkedQueue
    {
        static void Main(string[] args)
        {
            var linkedQueue = new LinkedQueue<string>();
            linkedQueue.Enqueue("abc");
            linkedQueue.Enqueue("cba");
            linkedQueue.Enqueue("bac");

            while (linkedQueue.Count > 0)
            {
                Console.WriteLine(linkedQueue.Dequeue());
            }
        }
    }
}
