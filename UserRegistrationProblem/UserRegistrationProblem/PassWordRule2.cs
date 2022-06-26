﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class PassWordRule2
    {
        public static string Regex_Password = "(?=.*[0-9])(?=.[A-Za-z]{7,})";

        public bool validatePassword2(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
