using NUnit.Framework;

namespace RegExPatterns
{
    public class Tests
    {

        UserRegistrationTestLambda userRegistration;
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistrationTestLambda();
        }

        /// <summary>
        /// Throw Custom Exception for Invalid FirstName
        /// </summary>
        [TestCase("Shivaraj")]
        [TestCase("Sh")]
        public void Given_FirstName_Expecting_ThrowCustomException(string firstName)
        {

            try
            {
                string actual = userRegistration.firstNameLambda(firstName);
            }
            catch (UserRegCustomException exception)
            {
                Assert.AreEqual("FirstName should contains atleast three characters", exception.Message);
            }
        }

        /// <summary>
        /// Throw Custom Exception for Invalid LastName
        /// </summary>
        [TestCase("Gowda")]
        [TestCase("Go")]
        public void Given_LastName_Expecting_ThrowCustomException(string lastName)
        {

            try
            {
                string actual = userRegistration.lastNameLambda(lastName);
            }
            catch (UserRegCustomException exception)
            {
                Assert.AreEqual("LastName should contains atleast three characters", exception.Message);
            }
        }
        /// <summary>
        /// Throw Custom Exception for Invalid Email
        /// </summary>
        [TestCase("abc@yahoo.com")]
        [TestCase("abc-100@yahoo.com,")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com,")]
        [TestCase("abc-100@abc.net,")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc@1.com,")]
        [TestCase("abc@gmail.com.com")]
        [TestCase("abc+100@gmail.com")]
        [TestCase("abc")]
        [TestCase("abc@.com.my")]
        [TestCase("abc123@gmail.a")]
        [TestCase("abc123@.com")]
        [TestCase("abc@.com.com")]
        [TestCase(".abc@abc.com")]
        [TestCase("abc()*@gmail.com")]
        [TestCase("abc@%*.com")]
        [TestCase("abc..2002@gmail.com")]
        [TestCase("abc.@gmail.com")]
        [TestCase("abc@abc@gmail.com")]
        [TestCase("abc@gmail.com.1a")]
        [TestCase("abc@gmail.com.aa.au")]
        public void Given_Email_Expecting_ThrowCustomException(string email)
        {

            try
            {
                string actual = userRegistration.emailLambda(email);
            }
            catch (UserRegCustomException exception)
            {
                Assert.AreEqual("Email should contains special characters", exception.Message);
            }
        }

        /// <summary>
        /// Throw Custom Exception for Invalid MobileNumber
        /// </summary>
        [TestCase("91 8618199771")]
        [TestCase("")]
        public void Given_MobileNumber_Expecting_ThrowCustomException(string mobileNumber)
        {

            try
            {
                string actual = userRegistration.mobileNumberLambda(mobileNumber);
            }
            catch (UserRegCustomException exception)
            {
                Assert.AreEqual("MobileNumber should not be empty", exception.Message);
            }
        }

        /// <summary>
        /// Throw Custom Exception for Invalid Password
        /// </summary>
        [TestCase("Shiva123@!")]
        [TestCase("")]
        public void Given_Password_Expecting_ThrowCustomException(string password)
        {

            try
            {
                string actual = userRegistration.passwordLambda(password);
            }
            catch (UserRegCustomException exception)
            {
                Assert.AreEqual("Password should not be empty", exception.Message);
            }
        }



    }
}