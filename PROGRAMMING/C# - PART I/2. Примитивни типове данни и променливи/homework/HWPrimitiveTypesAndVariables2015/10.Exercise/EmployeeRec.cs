using System;
//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – 
//first name, 
//family name, 
//age, 
//gender (m or f), 
//ID number, 
//unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

namespace _10.Exercise
{
    class EmployeeRec
    {
        static void Main(string[] args)
        {
            string firstName, familyName;
            byte age;
            char gender;
            ulong ID;
            uint uniqueEmplNumber; 

            firstName = "Jane";
            familyName = "Dow";
            age = 28;
            gender = 'f';
            ID = 8306112507;
            uniqueEmplNumber = 27569999; 
            // Example
            Console.WriteLine("Employee Record: \n Name: {0} \n Family Name: {1} \n Age: {2} \n Gender: {3} \n ID: {4} \n Unique Employee Number: {5}", firstName, familyName, age, gender, ID, uniqueEmplNumber);
        }
    }
}
