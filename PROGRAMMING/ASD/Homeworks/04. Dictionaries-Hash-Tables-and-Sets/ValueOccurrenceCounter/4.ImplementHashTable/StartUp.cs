namespace _4.ImplementHashTable
{
    class StartUp
    {
        static void Main(string[] args) // muchos grasias to dentia solution
        {
            var table = new HashTable<int, string>();

            for (int i = 0; i < 50; i++)
            {
                table.Add(i, i.ToString());
            }

            System.Console.WriteLine(table);
            System.Console.WriteLine(table.Count);
        }
    }
}
