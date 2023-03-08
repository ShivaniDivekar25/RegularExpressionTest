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
        [Test]
        public void ShouldReturn_SampleEmails_Valid()
        {
            //string result = regex.ValidateSampleEmails("abc.xyz@bridgelabz.co.in");
            //string result = regex.ValidateSampleEmails("abc@yahoo.com");
            //string result = regex.ValidateSampleEmails("abc-100@yahoo.com");
            //string result = regex.ValidateSampleEmails("abc.100@yahoo.com");
            //string result = regex.ValidateSampleEmails("abc111@abc.com");
            //string result = regex.ValidateSampleEmails("abc_100@abc.net");
            //string result = regex.ValidateSampleEmails("abc.100@abc.com.au");
            //string result = regex.ValidateSampleEmails("abc@1.com");
            //string result = regex.ValidateSampleEmails("abc@gmail.com.com");
            string result = regex.ValidateSampleEmails("abc+100@gmail.com");
            Assert.AreEqual("Valid",result);
        }
    }
}