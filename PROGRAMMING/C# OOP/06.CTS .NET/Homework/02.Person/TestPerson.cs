namespace _02.Person
{
    using System;

    class TestPerson
    {
        static void Main()
        {
            var person = new Person("Pesho", 20);
            Console.WriteLine(person.ToString());

            var person2 = new Person("Gosho");
            Console.WriteLine(person2.ToString());
        }
    }
}
