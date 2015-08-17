using System;
// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and its manager and prints them on the console.


namespace _03.Exercise
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company \r\n");
            Console.Write("Name: ");
            string compName = Console.ReadLine();
            Console.Write("Adress: ");
            string compAdress = Console.ReadLine();
            Console.Write("Phone number: ");
            string compPhone = Console.ReadLine();
            Console.Write("Fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Web site: ");
            string compWebSite = Console.ReadLine();        // the phones and fax are string, not long, bc i want to be able to write + before 
            Console.WriteLine();                            // and make space after every 3 digits, or to be able to leave it empty
            Console.WriteLine("Manager \r\n");
            Console.Write("First name: ");
            string mangerFirstName = Console.ReadLine();
            Console.Write("Last name: ");
            string mangerLastName = Console.ReadLine();
            Console.Write("Age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Company name : {0}, \r\n Adress: {1}, \r\n Phone: {2} Fax: {3} \r\n Web site: {4} \r\n \r\nManager: {5}, {6} \r\n Age: {7} \r\n {8}",
                compName, compAdress, compPhone, compFax, compWebSite, mangerLastName, mangerFirstName, managerAge, managerPhone);
        }
    }
}
