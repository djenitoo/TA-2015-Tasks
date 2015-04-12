namespace Homework3
{
    using System;
    using System.Text;
    using System.Linq;
    using Homework3.Extensions;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            //Task 1
            StringBuilder str = new StringBuilder();
            Console.WriteLine("Substring extension method:");
            str.Append("abcdefghijklmnopqrstuvwxyz");
            Console.WriteLine(str);
            str = str.Substring(0, 3);
            Console.WriteLine("After Substring(0,3):");
            Console.WriteLine(str + "\n");

            //Task 2
            List<double> listOfDouble = new List<double>{ 2.323, 21.22, 1223, 56.13 };
            Console.WriteLine("IEnumerable<T> extension methods:");
            Console.WriteLine(string.Join(", ", listOfDouble));
            Console.WriteLine("Sum of list: {0}", listOfDouble.SumOfCollection());
            Console.WriteLine("Product of list: {0}", listOfDouble.Product());
            Console.WriteLine("Min of list: {0}", listOfDouble.Minimum());
            Console.WriteLine("Max of list: {0}", listOfDouble.Maximum());
            Console.WriteLine("Average of list: {0}", listOfDouble.AverageOfCollection());

            //Task 3
            var students = new[]{   new {FirstName = "Ivan", LastName = "Ivanov", Age = 20},
                                    new {FirstName = "Spas", LastName = "Parvanov", Age = 25},
                                    new {FirstName = "Georgi", LastName = "Slavkov", Age = 19}, // list of annon. type
                                    new {FirstName = "Strasimir", LastName = "Asenov", Age = 18},
                                    new {FirstName = "Denica", LastName = "Znaikov", Age = 16}
            };
            
            Console.WriteLine("\r\nList of students:");
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
            }
            
            var firstNameBeforeLast =
                students
                .Where(st => st.FirstName
                .CompareTo(st.LastName) == -1);

            Console.WriteLine("\r\nStudents whose first name is before last name: ");
            foreach (var item in firstNameBeforeLast)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //Task 4
            Console.WriteLine("\r\nStudents with age bw 18-24:");
            var ageBw18And24 = students
                .Where(st => (st.Age >= 18) && (st.Age <= 24))
                .Select(st => new { FirstName=st.FirstName, LastName = st.LastName});

            foreach (var item in ageBw18And24)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //Task 5
            Console.WriteLine("\r\nOrder by des with lambda:");
            // Using the extension methods OrderBy() and ThenBy() with lambda expressions 
            // sort the students by first name and last name in descending order.
            var orderStudents = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .Select(st => st);
            foreach (var item in orderStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
            }
            // Rewrite the same with LINQ.
            Console.WriteLine("\r\nOrder by des with linq:");
            var orderStudentsLinq =
                from st in students
                orderby st.FirstName descending
                orderby st.LastName descending
                select st;
            foreach (var item in orderStudentsLinq)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
            }
            //Task 6
            Console.WriteLine("\r\nArray of ints:");
            int[] arr = { 7, 3, 21, 42, 3, 5, 2, 84, 54, 2, 2545, 23 };
            Console.WriteLine(string.Join(", ", arr));
            var divBy7And3 = arr
                .Where(n => (n % 7 == 0) && (n % 3 == 0));
            Console.WriteLine("\r\nDivisable by 7 and 3 with lambda:");
            Console.WriteLine(string.Join(", ", divBy7And3));

            // with linq
            var divBy7And3Linq =
                from n in arr
                where (n % 7 == 0) && (n % 3 == 0)
                select n;
            Console.WriteLine("\r\nDivisable by 7 and 3 with linq:");
            Console.WriteLine(string.Join(", ", divBy7And3Linq));

        }
    }
}
