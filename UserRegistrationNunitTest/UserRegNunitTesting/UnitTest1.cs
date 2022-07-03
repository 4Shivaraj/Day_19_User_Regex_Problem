
using RegExPatterns;
using System.Security.Cryptography.X509Certificates;

namespace RegExPatterns
{

    public class UnitTest1
    {
        Patterns patterns;
        [SetUp]
        public void Setup()
        {
            patterns = new Patterns();
        }

        [Test]

        public void HappyTest()
        {
            string message = null;
            patterns = new Patterns();
            bool check1 = patterns.ValidateFirstName("Shivaraj");
            bool check2 = patterns.ValidateLastName("Deepak");
            bool check3 = patterns.ValidateEmail("4shivraj.gowda@gmail.com");
            bool check4 = patterns.ValidatePhone("91 8618199771");
            bool check5 = patterns.ValidatePassword("Shiva123@!");
            if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true)
            {
                message = "Validation Successful";
            }
            Assert.AreEqual("Validation Successful", message);
        }
        [Test]
        public void SadTest()
        {
            string message = null;
            patterns = new Patterns();
            bool check1 = patterns.ValidateFirstName("shivaraj");
            bool check2 = patterns.ValidateLastName("deepak");
            bool check3 = patterns.ValidateEmail("4shivraj.gowda.gmail.com");
            bool check4 = patterns.ValidatePhone("8618199771");
            bool check5 = patterns.ValidatePassword("raf@24");
            if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true)
            {
                message = "Validation Successful";
            }
            else
            {
                message = "Validation Unsuccessful";
            }
            Assert.AreEqual("Validation Unsuccessful", message);
        }
        [Test]
        public void MultipleMail()
        {
            string message = null;
            patterns = new Patterns();
            bool check1 = patterns.ValidateEmail("abc@yahoo.com");
            bool check2 = patterns.ValidateEmail("abc-100@yahoo.com");
            bool check3 = patterns.ValidateEmail("abc.100@yahoo.com");
            if (check1 == true && check2 == true && check3 == true)
            {
                message = "Email Validation Successful";
            }
            Assert.AreEqual("Email Validation Successful", message);
        }
        [Test]
        public void given_empty_first_name_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = string.Empty;
                bool check = patterns.ValidateFirstName(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Fist Name cannot be empty", userException.message);
            }

        }
        public void given_null_first_name_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = null;
                bool check = patterns.ValidateFirstName(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Fist Name cannot be null", userException.message);
            }

        }
        [Test]
        public void given_empty_last_name_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = string.Empty;
                bool check = patterns.ValidateLastName(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Last Name cannot be empty", userException.message);
            }

        }
        public void given_null_last_name_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = null;
                bool check = patterns.ValidateLastName(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Last Name cannot be null", userException.message);
            }

        }
        [Test]
        public void given_empty_email_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = string.Empty;
                bool check = patterns.ValidateEmail(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Email cannot be empty", userException.message);
            }

        }
        public void given_null_email_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = null;
                bool check = patterns.ValidateEmail(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Email cannot be null", userException.message);
            }

        }
        [Test]
        public void given_empty_phone_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = string.Empty;
                bool check = patterns.ValidatePhone(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Phone number cannot be empty", userException.message);
            }

        }
        public void given_null_phone_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = null;
                bool check = patterns.ValidatePhone(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Phone number cannot be null", userException.message);
            }

        }
        [Test]
        public void given_empty_password_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = string.Empty;
                bool check = patterns.ValidatePassword(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Password cannot be empty", userException.message);
            }

        }
        public void given_null_password_should_return_this_exception()
        {
            try
            {
                patterns = new Patterns();
                string message = null;
                bool check = patterns.ValidatePassword(message);

            }
            catch (UserRegCustomException userException)
            {
                Assert.AreEqual("Password cannot be null", userException.message);
            }

        }

    }
}