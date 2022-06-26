using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class PassWordRule3
    {
        public static string Regex_Password = (@"^[A-Za-z]{8,}[A-Z]{1,}[0-9]{1,}$");

        public bool validatePassword3(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
