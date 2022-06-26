using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class PassWordRule1
    {
        public static string Regex_Password = "^[a-zA-z0-9]{8,16}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
