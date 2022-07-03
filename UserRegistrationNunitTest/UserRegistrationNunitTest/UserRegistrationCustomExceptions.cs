using System;
using System.Collections.Generic;
using System.Text;

namespace RegExPatterns
{
    public class UserRegCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            ENTERED_EMPTY,
            ENTERED_LESSTHAN_MINIMUM_LENGTH,
            ENTERED_NUMBER,
            ENTERED_LOWERCASE,
            ENTERED_SPECIAL_CHARACTER,
        }
        public UserRegCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}