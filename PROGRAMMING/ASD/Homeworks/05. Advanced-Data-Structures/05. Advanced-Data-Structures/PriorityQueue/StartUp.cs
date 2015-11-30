namespace PriorityQueue
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var priorityQueueExample = new PriorityQueue<int>();
            priorityQueueExample.Enqueue(1);
            priorityQueueExample.Enqueue(5);
            priorityQueueExample.Enqueue(3);
            priorityQueueExample.Enqueue(4);
            priorityQueueExample.Enqueue(0);
            priorityQueueExample.Enqueue(10);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(priorityQueueExample.Dequeue());
            }
        }
    }
}
