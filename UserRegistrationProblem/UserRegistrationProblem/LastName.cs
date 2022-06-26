using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
	class validLastName
	{
		public static string Regex_LastName = "^[A-Z][a-z]{2,}$";

		public bool validateLastName(string lastName)
		{
			return Regex.IsMatch(lastName, Regex_LastName);
		}
	}
}
