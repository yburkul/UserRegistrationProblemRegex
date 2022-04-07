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

        /// <summary>
        /// TC-1 First Name test
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("Yogesh")]
        [TestCase("Yo")]

        public void FirstName_Expecting_ThrowCustomException(string firstName)
        {
            try
            {
                string actual = validation.ValidFirstName(firstName);

            }
            catch(UserValidationCustomException ex)
            {
                Assert.AreEqual("FirstName is not valid", ex.Message);
            }
        }
        /// <summary>
        /// TC-2 Last Name Test
        /// </summary>
        /// <param name="lastName"></param>

        [TestCase("Burkul")]
        [TestCase("Bu")]

        public void LastName_Expecting_ThrowCustomException(string lastName)
        {
            try
            {
                string actual = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("LastName is not valid", ex.Message);
            }
        }
        /// <summary>
        /// TC- Email id Test
        /// </summary>
        /// <param name = "emailId" ></ param >

        [TestCase("y.burkul123@gmail.com")]
        [TestCase("yburkul@gmail.com")]

        public void EmailId_Expecting_ThroCustomExeption(string emailId)
        {
            try
            {
                string actual = validation.ValidEmailId(emailId);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("EmailID is not valid", ex.Message);
            }
        }
        /// <summary>
        /// TC -Mobile number test
        /// </summary>
        /// <param name="MobileNumber"></param>

        [TestCase("91 8866779905")]
        [TestCase("919911224455")]

        public void MobileNumber_Expecting_ThroCustomExeption(string MobileNumber)
        {
            try
            {
                string actual = validation.ValidMobileNumber(MobileNumber);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("MobileNumber is not valid", ex.Message);
            }
        }
        /// <summary>
        /// TC- Password Min eight char
        /// </summary>
        /// <param name="CharPassword"></param>

        [TestCase("Burkulyogesh")]
        [TestCase("Bu123yog")]
        public void Password_EightChar_Expecting_ThroCustomExeption(string CharPassword)
        {
            try
            {
                string actual = validation.ValidPasswordMinEightChar(CharPassword);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is not valid", ex.Message);
            }
        }
        /// <summary>
        /// TC- Password use One Upper case
        /// </summary>
        /// <param name="PasswordOneUpperCase"></param>

        [TestCase("Burkulyogi")]
        [TestCase("Bu1yog")]
        public void Password_OneUpperCase_Expecting_ThroCustomExeption(string PasswordOneUpperCase)
        {
            try
            {
                string actual = validation.ValidPasswordAtLeastOneUpperCase(PasswordOneUpperCase);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is not valid", ex.Message);
            }
        }
        /// <summary>
        /// TC - Passsword use one number
        /// </summary>
        /// <param name="PasswordUseOneNumber"></param>


        [TestCase("YogeshB1yb")]
        [TestCase("Burkulyog")]
        public void Password_OneNubmer_Expecting_ThroCustomExeption(string PasswordUseOneNumber)
        {
            try
            {
                string actual = validation.ValidPasswordAtLeastOneNumber(PasswordUseOneNumber);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is not valid", ex.Message);
            }
        }
        /// <summary>
        /// TC- Pawword use one special char
        /// </summary>
        /// <param name="PasswordUseOneSpecialChar"></param>

        [TestCase("Yogesh@917")]
        [TestCase("Buyog")]
        public void Password_AtleastOneSpecialChar_Expecting_ThroCustomExeption(string PasswordUseOneSpecialChar)
        {
            try
            {
                string actual = validation.ValidPasswordOneSpecialChar(PasswordUseOneSpecialChar);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password is not valid", ex.Message);
            }
        }
    }
}