using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class UserValidationCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            FIRST_NAME_MESSAGE,
            LAST_NAME_MESSAGE,
            EMAIL_ID_MESSAGE,
            MOBILE_NUMBER_MESSAGE,
            PASSWORD_MIN_EIGHT_CHAR,
            PASSWORD_ONE_UPPER_CASE,
            PASSWORD_ONE_NUMBER_USE,
            PASSWORD_ONE_SPECIAL_CHAR
        }
        public UserValidationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
