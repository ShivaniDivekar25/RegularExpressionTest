using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressionTest
{
    public class UserRegExceptionHandling : Exception
    {
        public enum ExceptionTypes
        {
            NULL_INPUT,
            EMPTY_INPUT,
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PHONENUMBER,
            INVALID_PASSWORD,
            INVALID_SAMPLE_EMAILS
        }
        public ExceptionTypes exceptionTypes;
        public UserRegExceptionHandling(string msg, ExceptionTypes exceptionTypes) : base(msg)
        {
            this.exceptionTypes = exceptionTypes;
            Console.WriteLine(msg);
        }
    }
}
