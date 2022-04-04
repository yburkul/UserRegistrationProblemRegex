using NUnit.Framework;
using UserRegistrationRegex;

namespace UserRegistrationTesting
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }

        [Test]
        public void firstName()
        {
            string firstName = "Yogesh";
            string result = null;
            try
            {
                result = validation.ValidFirstName(firstName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("First Name is Valid", ex.Message);
            }
        }

        [Test]
        public void lastName()
        {
            string Name = "Burkul";
            string result = null;
            try
            {
                result = validation.ValidLastName(Name);
            }
            catch(UserValidationCustomException ex)
            {
                Assert.AreEqual("Last Name is Valid", ex.Message);
            }
        }

        [Test]
        public void email_Id()
        {
            string Email = "y.burkul987@gmail.com";
            string result = null;
            try
            {
                result = validation.ValidEmailId(Email);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("EmailId is valid", ex.Message);
            }
        }

        [Test]
        public void Mobile_Number()
        {
            string MobileNumber = "91 8690023008";
            string result = null;
            try
            {
                result = validation.ValidMobileNumber(MobileNumber);
            }
            catch(UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_Min_Eight_Char()
        {
            string Password = "Yogeshburkul";
            string result = null;
            try
            {
                result = validation.ValidPasswordMinEightChar(Password);
            }
            catch(UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_At_Least_One_Upper_Case()
        {
            string Password = "YogiBurkul";
            string result = null;
            try
            {
                result = validation.ValidPasswordAtLeastOneUpperCase(Password);
            }
            catch(UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_AtLeast_One_Number()
        {
            string Passwords = "Yogi123Burkul";
            string result = null;
            try
            {
                result = validation.ValidPasswordAtLeastOneNumber(Passwords);
            }
            catch(UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_One_Special_Char()
        {
            string Password = "Yogesh@987";
            string result = null;
            try
            {
                result = validation.ValidPasswordOneSpecialChar(Password);
            }
            catch(UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }
    }
}