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
        public string TestPattern(string pattern,string name)
        {
            if (Regex.IsMatch(name, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }
}
