using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrations userRegistration = new UserRegistrations();
            int option = 0;
            do
            {
                Console.WriteLine("1: For First name validation");
                Console.WriteLine("2: For Last name validation");
                Console.WriteLine("3: For Email validation");
                Console.WriteLine("4: For Mobile Number");
                Console.WriteLine("5: For Password Rule One");
                Console.WriteLine("6: For Password Rule Two");

                    option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter a First Name");
                        string FirstName = Console.ReadLine();
                        userRegistration.validfirstname(FirstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter a Last Name");
                        string LastName = Console.ReadLine();
                        userRegistration.validlastname(LastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter your EmailId: ");
                        string EmailId = Console.ReadLine();
                        userRegistration.validEmailId(EmailId);
                        break;
                    case 4:
                        Console.WriteLine("Enter a Mobile Number");
                        string MobileNumber = Console.ReadLine();
                        userRegistration.validMobileNumber(MobileNumber);
                        break;
                    case 5:
                        Console.WriteLine("Enter a Password");
                        string PasswordOne = Console.ReadLine();
                        userRegistration.validPasswordRuleOne(PasswordOne);
                        break;
                    case 6:
                        Console.WriteLine("Enter a Password");
                        string PasswordTwo = Console.ReadLine();
                        userRegistration.validPasswordRuleTwo(PasswordTwo);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (option != 0);
        }
    }
}
