using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionTest
{
    public class RegexPattern
    {
        public string inputs;
        public string patternFirstName = "^[A-z]{1}[a-z]{2,}$";
        public string patternLastName = "^[A-z]{1}[a-z]{2,}$";
        public string patternValidEmail = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
        public string patternPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
        public string patternPassword = "^[A-Z]{1}[a-z]{4,}(@|#|$|&){1}[0-9]{1,}$";
        public string patternSampleEmail = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
        public RegexPattern()
        {

        }
        public RegexPattern(string inputs)
        {
            this.inputs = inputs;
        }

        public string ValidateFirstName(string input)
        {
            string pattern = "^[A-z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        public string ValidateLastName(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        public string ValidateEmail(string input)
        {
            string pattern = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            return TestPattern(pattern, input);
        }
        public string ValidatePhoneNumber(string input)
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            return TestPattern(pattern, input);
        }
        public string ValidatePassword(string input)
        {
            string pattern = "^[a-zA-Z]{8,}$";
            return TestPattern(pattern, input);
        }
        public string ValidatePasswordLeastUppercase(string input)
        {
            string pattern = "^[A-Za-z]{1,}$";
            return TestPattern(pattern, input);
        }
        public string ValidatePasswordWithLeastNumericValue(string input)
        {
            string pattern = "^[A-Za-z0-9]{1,}$";
            return TestPattern(pattern, input);
        }
        public string ValidatePasswordWithExactlyOneSpecialCharacter(string input)
        {
            string pattern = "^[A-Za-z0-9]{1,}(@|#|$|&){1}$";
            return TestPattern(pattern, input);
        }
        public string ValidateSampleEmails(string input)
        {
            string pattern = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
            return TestPattern(pattern, input);
        }
        public string TestPattern(string pattern,string input)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string ValidateFirstName()
        {
            try
            {
                if (inputs.Equals(string.Empty))
                {
                    throw new UserRegExceptionHandling("First name should not be empty", UserRegExceptionHandling.ExceptionTypes.EMPTY_INPUT);
                }
                else if (Regex.IsMatch(inputs, patternFirstName))
                {
                    return "Valid";
                }
                else
                {
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegExceptionHandling("First name should not be null", UserRegExceptionHandling.ExceptionTypes.NULL_INPUT);
            }
        }
        public string ValidateLastName()
        {
            try
            {
                if (inputs.Equals(string.Empty))
                {
                    throw new UserRegExceptionHandling("Last name should not be empty", UserRegExceptionHandling.ExceptionTypes.EMPTY_INPUT);
                }
                else if (Regex.IsMatch(inputs, patternLastName))
                {
                    return "Valid";
                }
                else
                {
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegExceptionHandling("Last name should not be null", UserRegExceptionHandling.ExceptionTypes.NULL_INPUT);
            }
        }
        public string ValidateSampleEmails()
        {
            try
            {
                if (inputs.Equals(string.Empty))
                {
                    throw new UserRegExceptionHandling("Emails should not be empty", UserRegExceptionHandling.ExceptionTypes.EMPTY_INPUT);
                }

                else if (Regex.IsMatch(inputs, patternSampleEmail))
                {
                    return "Valid";
                }
                else
                {
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegExceptionHandling("Emails should not be null", UserRegExceptionHandling.ExceptionTypes.NULL_INPUT);
            }
        }
        public bool FirstName(string inputs)
        {
            if (Regex.IsMatch(inputs, patternFirstName))
            {
                return true;
            }
            else
            {
                throw new UserRegExceptionHandling("Invalid First Name", UserRegExceptionHandling.ExceptionTypes.INVALID_FIRST_NAME);
            }
        }
        public bool LastName(string inputs)
        {
            if (Regex.IsMatch(inputs, patternLastName))
            {
                return true;
            }
            else
            {
                throw new UserRegExceptionHandling("Invalid Last Name", UserRegExceptionHandling.ExceptionTypes.INVALID_LAST_NAME);
            }
        }
        //Created email method
        public bool ValidEmail(string inputs)
        {
            if (Regex.IsMatch(inputs, patternValidEmail))
            {
                return true;
            }
            else
            {
                throw new UserRegExceptionHandling("Invalid Email", UserRegExceptionHandling.ExceptionTypes.INVALID_EMAIL);
            }
        }
        //Created phone number method
        public bool PhoneNumber(string inputs)
        {
            if (Regex.IsMatch(inputs, patternPhoneNumber))
            {
                return true;
            }
            else
            {
                throw new UserRegExceptionHandling("Invalid Phone Number", UserRegExceptionHandling.ExceptionTypes.INVALID_PHONENUMBER);
            }
        }
        //Created password method
        public bool Password(string inputs)
        {
            if (Regex.IsMatch(inputs, patternPassword))
            {
                return true;
            }
            else
            {
                throw new UserRegExceptionHandling("Invalid Password", UserRegExceptionHandling.ExceptionTypes.INVALID_PASSWORD);
            }
        }
        //Created validate Emails method
        public bool ValidateSampleEmail(string[] input)
        {
            foreach(string inputs in input)
            {
                if (Regex.IsMatch(inputs, patternSampleEmail))
                {
                    return true;
                }
                else
                {
                    throw new UserRegExceptionHandling("Invalid Sample Emails", UserRegExceptionHandling.ExceptionTypes.INVALID_SAMPLE_EMAILS);
                }
            }
            return default;
        }
    }
}
