using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrations userRegistration = new UserRegistrations();
            Console.WriteLine("Enter a First Name");
            string FirstName = Console.ReadLine();
            userRegistration.validfirstname(FirstName);

            Console.WriteLine("Enter a Last Name");
            string LastName = Console.ReadLine();
            userRegistration.validlastname(LastName);
        }
    }
}
