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
        public void validfirstname(string FirstName)
        {
            Console.WriteLine("First name: " + FirstName);
            if (FirstNameRegex.IsMatch(FirstName))
            {
                Console.WriteLine("First Name is valid");

            }
            else
            {
                Console.WriteLine("First Name is not valid");
            }
        }
        public void validlastname(string LastName)
        {
            if (LastNameRegex.IsMatch(LastName))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is not valid");
            }
        }
    }
}
