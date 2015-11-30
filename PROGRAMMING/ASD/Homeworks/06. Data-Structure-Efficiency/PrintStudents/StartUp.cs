using System;
using System.Collections.Generic;
using System.IO;

namespace PrintStudents
{
    class StartUp
    {
        struct Student
        {
            public string firstName;
            public string lastName;
        }

        static void Main(string[] args)
        {
            var dataBase = new SortedDictionary<string,List<Student>>();
            foreach (string line in File.ReadLines(@"..\\..\\students.txt"))
            {
                string[] words = line.Split(new char[] {' ', '|'}, StringSplitOptions.RemoveEmptyEntries);
                var currentStudent = new Student();
                currentStudent.firstName = words[0];
                currentStudent.lastName = words[1];
                var subject = words[2];
                if (dataBase.ContainsKey(subject))
                {
                    dataBase[subject].Add(currentStudent);
                }
                else
                {
                    dataBase.Add(subject, new List<Student>() { currentStudent });
                }
            }

            foreach (var key in dataBase.Keys)
            {
                Console.Write("{0}: ", key);
                dataBase[key].Sort((emp1, emp2) => emp1.firstName.CompareTo(emp2.lastName));

                for (int i = 0; i < dataBase[key].Count; i++)
                {
                    Console.Write(dataBase[key][i].firstName + " " + dataBase[key][i].lastName);
                    if (i != dataBase[key].Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
