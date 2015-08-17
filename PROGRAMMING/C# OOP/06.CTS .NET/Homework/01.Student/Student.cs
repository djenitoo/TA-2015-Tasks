
namespace _01.Student
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student() { }
        public Student(string fname, string mname, string lname,
                        string ssn, string address, string phone,
                        string email, byte course, Specialities spec,
                        Universities uni, Faculties fac)
        {
            this.FirstName = fname;
            this.MiddleName = mname;
            this.LastName = lname;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.Course = course;
            this.Speciality = spec;
            this.University = uni;
            this.Faculty = fac;
        }
        
        public string FirstName { get; set; }   // Did not put date validation, bc is not the purpouse of that homework
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Specialities Speciality { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }


        public override bool Equals(object obj)
        {
            Student student = obj as Student;  // make obj in student type

            //if (student == null)  // if object is not student by default, when parsing above, it will become null
            //{
            //    return false;  // then its not equal
            //}
            FieldInfo[] fields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public); // here we put every field in []

            foreach (FieldInfo field in fields)   // we compare every field info of both students
            {
                if (!object.Equals(field.GetValue(this), field.GetValue(student))) // if one field dont have equal info, then they are not equal Students
                {
                    return false;
                }
            }
            return true;  // else return true (every field info is equal)
        }

        public override string ToString()
        {

            return String.Format(@"First name: {0}
Middle name: {1}
Last name: {2}
SSN: {3}
Address: {4}
Mobile: {5}
Email: {6}
Course: {7}
Speciality: {8}
University: {9}
Faculty: {10}",
              this.FirstName, this.MiddleName, this.LastName, this.SSN, 
              this.Address, this.MobilePhone, this.Email,
              this.Course, this.Speciality, this.University, this.Faculty);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + this.SSN.GetHashCode();
            hash = (hash * 7) + this.Email.GetHashCode();

            return hash;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1.Equals(student2));
        }

        public object Clone()  //thanks to dentia source code
        {
            Student cloned = new Student(this.FirstName, this.MiddleName, this.LastName, 
                                        this.SSN, this.Address, this.MobilePhone, this.Email,
                                        this.Course, this.Speciality, this.University, this.Faculty);

            return cloned;
        }

        public int CompareTo(Student student2)
        {
            if (this.FirstName.CompareTo(student2.FirstName) != 0)
            {
                return this.FirstName.CompareTo(student2.FirstName);
            }
            else if (this.MiddleName.CompareTo(student2.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(student2.MiddleName);
            }
            else if (this.LastName.CompareTo(student2.LastName) != 0)
            {
                return this.LastName.CompareTo(student2.LastName);
            }
            else
            {
                return this.SSN.CompareTo(student2.SSN);
            }
        }
    }
}
