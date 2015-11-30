using System;
using System.IO;

namespace _6.PhonesTraversal
{
    /*
    A text file phones.txt holds information about people, their town and phone number:

Mimi Shmatkata          | Plovdiv  | 0888 12 34 56
Kireto                  | Varna    | 052 23 45 67
Daniela Ivanova Petrova | Karnobat | 0899 999 888
Bat Gancho              | Sofia    | 02 946 946 946

Duplicates can occur in people names, towns and phone numbers. Write a program to read the phones file and execute a sequence of commands given in the file commands.txt:

    find(name) – display all matching records by given name (first, middle, last or nickname)
    find(name, town) – display all matching records by given name and town

    */
    class StartUp
    {
        static void Main(string[] args)
        {
            var db = File.ReadAllLines(@"..\\..\\phones.txt");
            var phoneBook = new PhoneBook();

            foreach (var line in db)
            {
                var parts = line.Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                var entry = new Entry
                {
                    Name = parts[0].Trim(),
                    Town = parts[1].Trim(),
                    Tel = parts[2].Trim()
                };

                phoneBook.Add(entry);
            }


            var entriesWithNameMimi = phoneBook.Find("mimi");
            Console.WriteLine("Entries with name mimi:");
            Console.WriteLine(string.Join("\n\r", entriesWithNameMimi));

            var entriesWithTownPl = phoneBook.Find("mimi","pl");
            Console.WriteLine("Entries with name mimi and town Pl:");
            Console.WriteLine(string.Join("\n\r", entriesWithTownPl));

        }
    }
}
