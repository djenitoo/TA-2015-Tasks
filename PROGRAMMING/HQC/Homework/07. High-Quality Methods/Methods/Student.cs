namespace Methods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
          DateTime firstDate = this.DateOfBirth;
          DateTime secondDate = other.DateOfBirth;
          if (firstDate == null || secondDate == null)
          {
            throw new ArgumentNullException("Birth dates cannot be null!");
          }

          return firstDate > secondDate;
        }
    }
}
