using System;

namespace registration_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            RegexValidation regexValidation = new RegexValidation();
            Console.Write("Enter Your First Name::-");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
        }
    }
}