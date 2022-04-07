using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Validation
    {
        public Regex FirstNameRegex = new Regex (@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex LastNameRegex = new Regex (@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex EmailIdRegex = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordMinEightChar = new Regex(@"^[A-Z][A-Za-z]{8,}$");
        public Regex PasswordAtLeastOneUpperCase = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        public Regex PasswordAtLeastOneNumber = new Regex(@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");
        public Regex PasswordOneSpecialChar = new Regex(@"^(?=[a-zA-Z0-9#@$?]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");

        public string ValidFirstName(string firstName)
        {
            bool FirstNamePattern(string FirstNamePattern) => FirstNameRegex.IsMatch(firstName);
            bool result = FirstNamePattern(firstName);
            try
            {
                if (result == false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.FIRST_NAME_MESSAGE, "FirstName is not valid");
                }
                return "FirstName is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.FIRST_NAME_MESSAGE, "FirstName is not valid");
            }
        }
        public string ValidLastName(string lastName)
        {
            bool LastNamePattern(string LastNamePattern) => LastNameRegex.IsMatch(lastName);
            bool result = LastNamePattern(lastName);
            try
            {
                if (result == false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.LAST_NAME_MESSAGE, "LastName is not valid");
                }
                return "LastName is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.LAST_NAME_MESSAGE, "LastName is not valid");
            }
        }

        public string ValidEmailId(string email)
        {
            bool EmailPattern(string EmailPattern) => EmailIdRegex.IsMatch(email);
            bool result = EmailPattern(email);
            try
            {
                if (result == false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EMAIL_ID_MESSAGE, "EmailId is not valid");
                }
                return "EmailID is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EMAIL_ID_MESSAGE, "EmailId is not valid");
            }
        }

        public string ValidMobileNumber(string MobileNumber)
        {
            bool MobileNumberPattern(string MobileNumberPattern) => MobileNumberRegex.IsMatch(MobileNumber);
            bool result = MobileNumberPattern(MobileNumber);
            try
            {
                if (result==false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MOBILE_NUMBER_MESSAGE, "MobileNumber is not valid");
                }
                return "MobileNumber is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MOBILE_NUMBER_MESSAGE, "MobileNumber is not valid");
            }
        }
        public string ValidPasswordMinEightChar(string CharPassword)
        {
            bool EightCharPasswordPattern(string EightCharPasswordPattern) => PasswordMinEightChar.IsMatch(CharPassword);
            bool result = EightCharPasswordPattern(CharPassword);
            try
            {
                if (result == false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_MIN_EIGHT_CHAR, "Password is not valid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_MIN_EIGHT_CHAR, "Password is not valid");
            }
        }
        public string ValidPasswordAtLeastOneUpperCase(string PasswordOneUpperCase)
        {
            bool OneUpperCasePasswordPattern(string OneUpperCasePasswordPattern) => PasswordAtLeastOneUpperCase.IsMatch(PasswordOneUpperCase);
            bool result = OneUpperCasePasswordPattern(PasswordOneUpperCase);
            try
            {
                if (result == false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_ONE_UPPER_CASE, "Password is not valid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_ONE_UPPER_CASE, "Password is not valid");
            }
        }

        public string ValidPasswordAtLeastOneNumber(string PasswordUseOneNumber)
        {
            bool AtLeastOneNumberPattern(string AtLeastOneNumberPattern) => PasswordAtLeastOneUpperCase.IsMatch(PasswordUseOneNumber);
            bool result = AtLeastOneNumberPattern(PasswordUseOneNumber);
            try
            {
                if (result == false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_ONE_NUMBER_USE, "Password is not valid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_ONE_NUMBER_USE, "Password is not valid");
            }
        }
        public string ValidPasswordOneSpecialChar(string PasswordUseOneSpecialChar)
        {
            bool AtLeastOneSpecialPattern(string AtLeastOneSpecialPattern) => PasswordOneSpecialChar.IsMatch(PasswordUseOneSpecialChar);
            bool result = AtLeastOneSpecialPattern(PasswordUseOneSpecialChar);
            try
            {
                if (result == false)
                {
                    throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_ONE_SPECIAL_CHAR, "Password is not valid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PASSWORD_ONE_SPECIAL_CHAR, "Password is not valid");
            }
        }
    }
}
