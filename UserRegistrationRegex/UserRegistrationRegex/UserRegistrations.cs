using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class UserRegistrations
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex EmailIdRegex = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordMinEightChar = new Regex(@"^[A-Z][A-Za-z]{8,}$");
        public Regex PasswordAtLeastOneUpperCase = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        public Regex PasswordAtLeastOneNumber = new Regex(@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");
        public Regex PasswordOneSpecialChar = new Regex(@"^(?=[a-zA-Z0-9#@$?]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
        public void validfirstname(string FirstName)
        {
            Console.WriteLine("First name: " + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
                Console.WriteLine("First Name is valid");
            else
                Console.WriteLine("First Name is not valid");
        }
        public void validlastname(string LastName)
        {
            if (LastNameRegex.IsMatch(LastName)) 
               Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Last Name is not valid");
        }
        public void validEmailId(string EmailId)
        {
            Console.WriteLine("EmailId: " + EmailId);
            if (EmailIdRegex.IsMatch(EmailId))
                Console.WriteLine("Email Id is valid");
            else
                Console.WriteLine("Email Id is Not valid");
        }
        public void validMobileNumber(string MobileNumber)
        {
            Console.WriteLine("Mobile Number: " + MobileNumber);
            if (MobileNumberRegex.IsMatch(MobileNumber))
                Console.WriteLine("Mobile number is valid");
            else
                Console.WriteLine("Mobile number is not valid");
        }
        public void validPasswordRuleOne(string PasswordOne)
        {
            Console.WriteLine("Password Rule One: " + PasswordOne);
            if (PasswordMinEightChar.IsMatch(PasswordOne))
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Password is not valid");
        }
        public void validPasswordRuleTwo(string PasswordTwo)
        {
            Console.WriteLine("Password Rule Two: " + PasswordTwo);
            if (PasswordAtLeastOneUpperCase.IsMatch(PasswordTwo))
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Password is Not valid");
        }
        public void validPasswordRuleThree(string PasswordThree)
        {
            Console.WriteLine("Password Rule Three: " + PasswordThree);
            if (PasswordAtLeastOneNumber.IsMatch(PasswordThree))
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Password is not valid");
        }
        public void validPasswordRuleFour(string PasswordFour)
        {
            Console.WriteLine("Passord Rule four: " + PasswordFour);
            if (PasswordOneSpecialChar.IsMatch(PasswordFour))
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Password is invalid");
        }

    }
}
