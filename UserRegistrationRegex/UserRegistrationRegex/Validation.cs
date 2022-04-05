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
        string FirstNameRegex = (@"^[A-Z]{1}[A-Za-z]{2,}$");
        string LastNameRegex = (@"^[A-Z]{1}[A-Za-z]{2,}$");
        string EmailIdRegex = (@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        string MobileNumberRegex = (@"^[0-9]{2}\s[0-9]{10}$");
        string PasswordMinEightChar = (@"^[A-Z][A-Za-z]{8,}$");
        string PasswordAtLeastOneUpperCase = (@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        string PasswordAtLeastOneNumber = (@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");
        string PasswordOneSpecialChar = (@"^(?=[a-zA-Z0-9#@$?]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");

        public string ValidFirstName(string firstName)
        {
            Regex regex = new Regex(FirstNameRegex);
            var result = regex.Match(firstName);
            try
            {
                if (!result.Success)
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
            Regex regex = new Regex(LastNameRegex);
            var result = regex.Match(lastName);
            try
            {
                if (!result.Success)
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
            Regex regex = new Regex(EmailIdRegex);
            var result = regex.Match(email);
            try
            {
                if(!result.Success)
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
            Regex regex = new Regex(MobileNumberRegex);
            var result = regex.Match(MobileNumber);
            try
            {
                if(!result.Success)
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
            Regex regex = new Regex(PasswordMinEightChar);
            var result = regex.Match(CharPassword);
            try
            {
                if(!result.Success)
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
            Regex regex = new Regex(PasswordAtLeastOneUpperCase);
            var result = regex.Match(PasswordOneUpperCase);
            try
            {
                if (!result.Success)
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
            Regex regex = new Regex(PasswordAtLeastOneNumber);
            var result = regex.Match(PasswordUseOneNumber);
            try
            {
                if (!result.Success)
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
            Regex regex = new Regex(PasswordOneSpecialChar);
            var result = regex.Match(PasswordUseOneSpecialChar);
            try
            {
                if(!result.Success)
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
