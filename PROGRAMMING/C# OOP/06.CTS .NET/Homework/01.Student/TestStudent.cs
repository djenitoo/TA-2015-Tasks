namespace _01.Student
{
    using System;

    public class TestStudent
    {
        static void Main()
        {
            var student1 = new Student("peter", "petrov", "ivanov", "123-12-1587", 
                "V. Levski 98", "+359897889", "whyyy@no.com", 3, Specialities.BiologyScience, 
                Universities.Harvard, Faculties.History);

            var student2 = new Student("peter", "petrov", "ivanov", "123-12-1587",
                "V. Levski 98", "+359897889", "whyyy@no.com", 3, Specialities.BiologyScience,
                Universities.Harvard, Faculties.History);

            var student3 = new Student("mati", "petrov", "ivanov", "113-12-1587",
                "V. Levski 98", "+359897889", "whyyy@no.com", 3, Specialities.BiologyScience,
                Universities.Harvard, Faculties.History);

            // try Equal()
            Console.WriteLine(student1.Equals(student2));
            Console.WriteLine(student1.Equals(student3));

            //try ToString()
            Console.WriteLine("\r\n" + student1.ToString());
            Console.WriteLine("\r\n" + student3.ToString());

            // try GetHashCode()
            Console.WriteLine("\r\nStudent 1: " + student1.GetHashCode());
            Console.WriteLine("Student 2(= Student 1): " + student2.GetHashCode());
            Console.WriteLine("Student 3: " + student3.GetHashCode());

            // try == & !=
            Console.WriteLine("\r\n");
            Console.WriteLine(student1 == student2);
            Console.WriteLine(student2 == student3);

            // test Clone()
            var abv = student1.Clone();
            Console.WriteLine("\r\n" + abv.ToString());

            // test CompareTo()
            Console.WriteLine(student1.CompareTo(student2)); // they are the same = 0
            Console.WriteLine(student1.CompareTo(student3)); // peter && mati comparing = 1, p is after m
        }
    }
}
