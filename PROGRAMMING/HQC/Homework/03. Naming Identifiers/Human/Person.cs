namespace People
{
    public class Person
    {
        public Genre Genre { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person(int age)
        {
            this.Age = age;
        }

        public void CreatePerson(int age)
        {
            var newPerson = new Person(age);

            if (age % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Genre = Genre.Male;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Genre = Genre.Female;
            }
        }
    }
}