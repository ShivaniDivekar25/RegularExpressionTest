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
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void GivenNullFirstName_WhenAnalyse_ShouldReturnCustomException_NullInput()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern(null);
                string result = regularExpression.ValidateFirstName();
            }
            catch (UserRegExceptionHandling exceptionHandling)
            {
                Assert.AreEqual("First name should not be null", exceptionHandling.Message);
            }
        }
        [Test]
        public void GivenEmptyFirstName_WhenAnalyse_ShouldReturnCustomException_EmptyInput()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern(string.Empty);
                string result = regularExpression.ValidateFirstName();
            }
            catch (UserRegExceptionHandling exceptionHandling)
            {
                Assert.AreEqual("First name should not be empty", exceptionHandling.Message);
            }
        }
        [Test]
        public void GivenNullLastName_WhenAnalyse_ShouldReturnCustomException_NullInput()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern(null);
                string result = regularExpression.ValidateLastName();
            }
            catch (UserRegExceptionHandling exceptionHandling)
            {
                Assert.AreEqual("Last name should not be null", exceptionHandling.Message);
            }
        }
        [Test]
        public void GivenEmptyLastName_WhenAnalyse_ShouldReturnCustomException_EmptyInput()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern(string.Empty);
                string result = regularExpression.ValidateLastName();
            }
            catch (UserRegExceptionHandling exceptionHandling)
            {
                Assert.AreEqual("Last name should not be empty", exceptionHandling.Message);
            }
        }
        [Test]
        public void GivenNullSampleEmails_WhenAnalyse_ShouldReturnCustomException_NullInput()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern(null);
                string result = regularExpression.ValidateSampleEmails();
            }
            catch (UserRegExceptionHandling exceptionHandling)
            {
                Assert.AreEqual("Emails should not be null", exceptionHandling.Message);
            }
        }
        [Test]
        public void GivenEmptySampleEmails_WhenAnalyse_ShouldReturnCustomException_EmptyInput()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern(string.Empty);
                string result = regularExpression.ValidateSampleEmails();
            }
            catch (UserRegExceptionHandling exceptionHandling)
            {
                Assert.AreEqual("Emails should not be empty", exceptionHandling.Message);
            }
        }
        [Test]
        public void Should_Return_First_Name_Valid_Or_Invalid_ThrowCustomException()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern();
                //bool actual = regularExpression.FirstName("Shivani");
                bool actual = regularExpression.FirstName("Sh");
                Assert.IsTrue(actual);
            }
            catch (UserRegExceptionHandling ex)
            {
                Assert.AreEqual("Invalid First Name", ex.Message);
            }
        }
        [Test]
        public void Should_Return_Last_Name_Valid_Or_Invalid_ThrowCustomException()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern();
                //bool actual = regularExpression.LastName("Divekar");
                bool actual = regularExpression.LastName("Di");
                Assert.IsTrue(actual);
            }
            catch (UserRegExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Last Name", ex.Message);
            }
        }
        [Test]
        public void Should_Return_Email_Valid_Or_Invalid_ThrowCustomException()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern();
                //bool actual = regularExpression.ValidEmail("abc.xyz@bridgelabz.co.in");
                bool actual = regularExpression.ValidEmail("abc.xyz@bridge.co.in");
                Assert.IsTrue(actual);
            }
            catch (UserRegExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [Test]
        public void Should_Return_PhoneNumber_Valid_Or_Invalid_ThrowCustomException()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern();
                //bool actual = regularExpression.PhoneNumber("91 8983922706");
                bool actual = regularExpression.PhoneNumber("91 898392270");
                Assert.IsTrue(actual);
            }
            catch (UserRegExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Phone Number", ex.Message);
            }
        }
        [Test]
        public void Should_Return_Password_Valid_Or_Invalid_ThrowCustomException()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern();
                //bool actual = regularExpression.Password("Shiva12@");
                bool actual = regularExpression.Password("shiva12@");
                Assert.IsTrue(actual);
            }
            catch (UserRegExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }
        [Test]
        public void Should_Return_SampleEmails_Valid_Or_Invalid_ThrowCustomException()
        {
            try
            {
                RegexPattern regularExpression = new RegexPattern();
                //bool actual = regularExpression.ValidateSampleEmail(new string[] { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com"});
                bool actual = regularExpression.ValidateSampleEmail(new string[] { "abf@%*.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" });
                Assert.IsTrue(actual);
            }
            catch (UserRegExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Sample Emails", ex.Message);
            }
        }
    }
}