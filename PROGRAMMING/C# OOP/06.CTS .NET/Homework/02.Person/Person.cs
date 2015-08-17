﻿namespace _02.Person
{
    using System;
    using System.Linq;

    public class Person
    {
        public Person(string name)
            : this (name, null)
        {
        }

        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public byte? Age { get; set; }

        public override string ToString()
        {
            return string.Format(@"Name: {0}
Age: {1}", this.Name, String.IsNullOrEmpty(this.Age.ToString()) ? "Not specified" : this.Age.ToString());
        }
    }
}
