using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegExPatterns
{
    public class UserRegistrationTestLambda
    {
        //Regex pattern
        public static string REGEX_FIRST_NAME = "^[A-Z][a-z]{2,}?";
        public static string REGEX_LAST_NAME = "^[A-Z][a-z]{2,}?";
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$";
        public static string REGEX_MOBILE = "^[1-9][0-9][ ]?[6-9][0-9]{9}$";
        public static string REGEX_PASSWORD = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

        public bool firstName(string patternFirstName) => Regex.IsMatch(patternFirstName, REGEX_FIRST_NAME);
        public bool lastName(string patternLastName) => Regex.IsMatch(patternLastName, REGEX_LAST_NAME);
        public bool mobileNumber(string patternMobileNumber) => Regex.IsMatch(patternMobileNumber, REGEX_MOBILE);
        public bool password(string patternPassword) => Regex.IsMatch(patternPassword, REGEX_PASSWORD);
        public bool email(string patternEmail) => Regex.IsMatch(patternEmail, REGEX_EMAIL);


        /// <summary>
        /// FirstName Custom Exception
        /// </summary>

        public string firstNameLambda(string patternFirstName)
        {
            bool result = firstName(patternFirstName);
            try
            {
                if (result == false)
                {

                    if (patternFirstName.Equals(string.Empty))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_EMPTY, "FirstName should not be empty");
                    }


                    if (patternFirstName.Length < 3)
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "FirstName should contains atleast three characters");

                    }

                    if (patternFirstName.Any(char.IsDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_NUMBER, "FirstName should not contains number");
                    }
                    if (!char.IsUpper(patternFirstName[0]))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_LOWERCASE, "FirstName first letter should not be a lowercase");
                    }
                    if (patternFirstName.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_SPECIAL_CHARACTER, "FirstName should not contains special characters");
                    }

                }
            }

            catch (UserRegCustomException exception)
            {
                throw exception;
            }
            return "FirstName is not valid";
        }

        /// <summary>
        /// LastName Custom Exception
        /// </summary>

        public string lastNameLambda(string patternLastName)
        {
            bool result = lastName(patternLastName);
            try
            {
                if (result == false)
                {

                    if (patternLastName.Equals(string.Empty))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_EMPTY, "LastName should not be empty");
                    }


                    if (patternLastName.Length < 3)
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "LastName should contains atleast three characters");

                    }

                    if (patternLastName.Any(char.IsDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_NUMBER, "LastName should not contains number");
                    }
                    if (!char.IsUpper(patternLastName[0]))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_LOWERCASE, "LastName first letter should not be a lowercase");
                    }
                    if (patternLastName.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_SPECIAL_CHARACTER, "LastName should not contains special characters");
                    }

                }
            }

            catch (UserRegCustomException exception)
            {
                throw exception;
            }
            return "LastName is not valid";
        }
        /// <summary>
        /// Email Custom Exception
        /// </summary>

        public string emailLambda(string patternEmail)
        {
            bool result = email(patternEmail);
            try
            {
                if (result == false)
                {

                    if (patternEmail.Equals(string.Empty))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_EMPTY, "Email should not be empty");
                    }
                    if (!patternEmail.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_SPECIAL_CHARACTER, "Email should contains special characters");
                    }

                }
            }

            catch (UserRegCustomException exception)
            {
                throw exception;
            }
            return "Email is not valid";
        }


        /// <summary>
        /// MobileNumber Custom Exception
        /// </summary>
 
        public string mobileNumberLambda(string patternMobileNumber)
        {
            bool result = mobileNumber(patternMobileNumber);
            try
            {
                if (result == false)
                {

                    if (patternMobileNumber.Equals(string.Empty))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_EMPTY, "MobileNumber should not be empty");
                    }


                    if (patternMobileNumber.Length < 13)
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "MobileNumber should contains thirteen characters");

                    }

                    if (patternMobileNumber.Any(char.IsLetter))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_NUMBER, "MobileNumber should not contains letters");
                    }

                    if (patternMobileNumber.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_SPECIAL_CHARACTER, "MobileNumber should not contains special characters");
                    }

                }
            }

            catch (UserRegCustomException exception)
            {
                throw exception;
            }
            return "MobileNumber is not valid";
        }

        /// <summary>
        /// Password Custom Exception
        /// </summary>

        public string passwordLambda(string patternPassword)
        {
            bool result = password(patternPassword);
            try
            {
                if (result == false)
                {

                    if (patternPassword.Equals(string.Empty))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_EMPTY, "Password should not be empty");
                    }


                    if (patternPassword.Length < 8)
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "Password should contains atleast eight characters");

                    }

                    if (!patternPassword.Any(char.IsDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_NUMBER, "Password should contains number");
                    }
                    if (!char.IsUpper(patternPassword[0]))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_LOWERCASE, "Password first letter should not be a lowercase");
                    }
                    if (!patternPassword.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegCustomException(UserRegCustomException.ExceptionType.ENTERED_SPECIAL_CHARACTER, "Password should contains special characters");
                    }

                }
            }

            catch (UserRegCustomException exception)
            {
                throw exception;
            }
            return "Password is not valid";
        }
    }
}