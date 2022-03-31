﻿using System;
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
        public Regex EmailIdRegex = new Regex(@"^[A-Z a-z]+([.+-][A-Z a-z 0-9]+)*@[A-Z a-z 0-9]+.[A-Z a-z]([.][A-Z a-z]{2,})?$");
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRuleOne = new Regex(@"^[A-Z][A-Za-z]{8,}$");
        public Regex PasswordRuleTwo = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
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
            Console.WriteLine("Password Rule One" + PasswordOne);
            if (PasswordRuleOne.IsMatch(PasswordOne))
                Console.WriteLine("Password One is valid");
            else
                Console.WriteLine("Password One is not valid");
        }
        public void validPasswordRuleTwo(string PasswordTwo)
        {
            Console.WriteLine("Password Rule Two" + PasswordTwo);
            if (PasswordRuleTwo.IsMatch(PasswordTwo))
                Console.WriteLine("Password Two is valid");
            else
                Console.WriteLine("Password Two is Not valid");
        }
    }
}
