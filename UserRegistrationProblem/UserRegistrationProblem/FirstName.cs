using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
	class ValidFirstName
	{
		// first name should start with a capital alphabet and has minimum 3 characters(including capital alphabet)
		public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";

		public bool validateFirstName(string firstName)
		{
			return Regex.IsMatch(firstName, Regex_FirstName);
		}
	}
}

