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
            EMPTY_INPUT
        }
        public ExceptionTypes exceptionTypes;
        public UserRegExceptionHandling(string msg, ExceptionTypes exceptionTypes) : base(msg)
        {
            this.exceptionTypes = exceptionTypes;
            Console.WriteLine(msg);
        }
    }
}
