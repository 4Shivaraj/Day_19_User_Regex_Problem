namespace UserRegistrationNunitTest
{
    public class Tests
    {
        UserRegistrationDetails user;
        [SetUp]
        public void Setup()
        {
            user = new UserRegistrationDetails();
        }

        [Test]
        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Shivaraj";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Gowda";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "4shivaraj.gowda@gmail.com";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "91 8618199771";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateMobileNumber(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "Shiva123@!";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }

}
