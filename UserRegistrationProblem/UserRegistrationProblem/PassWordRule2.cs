using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class PassWordRule2
    {
        public static string Regex_Password = "([A-Z]{1}[0-9a-z]{7,})";

        public bool validatePassword2(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
