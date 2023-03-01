using RegularExpressionTest;

namespace RegularExpressionTestProgram
{
    public class Tests
    {
        RegexPattern regex = new RegexPattern();
        [Test]
        public void ShouldReturn_FirstName_ValidOrNot()
        {
            string result = regex.ValidateFirstName("Shivani");
            Assert.AreEqual("Valid", result);
            Assert.Pass();
        }
        [Test]
        public void ShouldReturn_LastName_ValidOrNot()
        {
            string result = regex.ValidateLastName("Divekar");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Email_ValidOrNot()
        {
            string result = regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_PhoneNumber_ValidOrNot()
        {
            string result = regex.ValidatePhoneNumber("91 8983922703");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot()
        {
            string result = regex.ValidatePassword("ShivaniD");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot_WithLeastOneUpperCase()
        {
            string result = regex.ValidatePasswordLeastUppercase("ShivaniD");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot_WithLeastOneNumericValue()
        {
            string result = regex.ValidatePasswordWithLeastNumericValue("Shivani12");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot_WithExactlyOneSpecialCharacter()
        {
            string result = regex.ValidatePasswordWithExactlyOneSpecialCharacter("Shivani1@");
            Assert.AreEqual("Valid", result);
        }
    }
}