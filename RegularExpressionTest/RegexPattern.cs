using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionTest
{
    public class RegexPattern
    {
        public string ValidateFirstName(string name)
        {
            string firstName = "^[A-z]{1}[a-z]{2,}$";
            return TestPattern(firstName, name);
        }
        public string TestPattern(string firstName,string name)
        {
            if (Regex.IsMatch(name, firstName))
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
