using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace RegExPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");
            Patterns patterns = new Patterns();
        RegStart1:
            Console.WriteLine("Enter First Name(should start with capital letter and contain minimum 3 characters");
            string fName = Console.ReadLine();
            bool check = patterns.ValidateFirstName(fName);
            if (check == false)
            {
                Console.WriteLine("Enter Valid First Name");
                goto RegStart1;
            }
            else
            {
                Console.WriteLine("First Name: " + fName);
            }
        RegStart2:
            Console.WriteLine("Enter Last Name(should start with capital letter and contain minimum 3 characters");
            string lName = Console.ReadLine();
            check = patterns.ValidateLastName(lName);
            if (check == false)
            {
                Console.WriteLine("Enter Valid First Name");
                goto RegStart2;
            }
            else
            {
                Console.WriteLine("Last Name: " + lName);
            }
        RegStart3:
            Console.WriteLine("Enter Email Address(should be in the format abc.xyz@bl.co.in where xyz and in are optional)");
            string email = Console.ReadLine();
            check = patterns.ValidateEmail(email);
            if (check == false)
            {
                Console.WriteLine("Enter Valid email address");
                goto RegStart3;
            }
            else
            {
                Console.WriteLine("Email Address: " + email);
            }
        RegStart4:
            Console.WriteLine("Enter Mobile Number(should start with country pincode and contain 10 numbers)");
            string number = Console.ReadLine();
            check = patterns.ValidatePhone(number);
            if (check == false)
            {
                Console.WriteLine("Enter Valid phone number");
                goto RegStart4;
            }
            else
            {
                Console.WriteLine("Phone Number: " + number);
            }
        RegStart5:
            Console.WriteLine("Enter Password(should contain minimum 8 characters");
            string password = Console.ReadLine();
            check = patterns.ValidatePassword(password);
            if (check == false)
            {
                Console.WriteLine("Enter Valid password");
                goto RegStart5;
            }
            else
            {
                Console.WriteLine("Password: " + password);
            }
        }
    }
}

//UC-12

// Refactor the Code to throw custom exceptions in case of Invalid User Details 
//   - Rewrite all Test Cases to take in Custom Exception for Invalid First Name, Last Name, Email, Mobile, and Password

//Result
//Welcome to User Registration!
//Enter First Name(should start with capital letter and contain minimum 3 characters
//Shivaraj
//First Name: Shivaraj
//Enter Last Name(should start with capital letter and contain minimum 3 characters
//Gowda
//Last Name: Gowda
//Enter Email Address(should be in the format abc.xyz@bl.co.in where xyz and in are optional)
//4shivayash @gmail.com
//Email Address: 4shivayash @gmail.com
//Enter Mobile Number(should start with country pincode and contain 10 numbers)
//91 8618199771
//Phone Number: 91 8618199771
//Enter Password(should contain minimum 8 characters
//Shiva123@!
//Password: Shiva123@!

//N Unit Test Result
//UserRegNunitTesting
//  Tests in group: 8

//  Total Duration: 24 ms

//Outcomes
//   8 Passed