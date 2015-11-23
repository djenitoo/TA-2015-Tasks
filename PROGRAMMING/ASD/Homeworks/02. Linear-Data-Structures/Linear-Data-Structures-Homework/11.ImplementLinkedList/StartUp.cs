using System;

namespace _11.ImplementLinkedList
{
    public class StartUp
    {
        static void Main(string[] args) //tnks to dentia(and others) exercise solution
        {
            var linkedList = new LinkedList<int>();
            var firstElement = new ListItem<int>(5);
            linkedList.FirstElement = firstElement;
            firstElement.NextItem = new ListItem<int>(2, new ListItem<int>(3));

            foreach (var element in linkedList)
            {
                Console.WriteLine(element);
            }

        }
    }
}
