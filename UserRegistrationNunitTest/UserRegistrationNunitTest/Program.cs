// See https://aka.ms/new-console-template for more information
using System;

namespace UserRegistrationNunitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Welcome To N unit testing and Exception handling For User Registration Problem");
                Console.Write("\nPlease enter user details\n");
                UserRegistrationDetails user = new UserRegistrationDetails();
                menu(user);
                Console.Write("\nDo you want to continue?(y/n)    ");
                ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            } while (ch == 'y');

            Console.ReadKey();
        }

        private static void menu(UserRegistrationDetails user)
        {

            Console.Write("\nFirst Name:     ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name:     ");
            string lastName = Console.ReadLine();

            Console.Write("Email:     ");
            string email = Console.ReadLine();

            Console.Write("Mobile Number:     ");
            string mobile = Console.ReadLine();
            Console.Write("Password:     ");
            string password = Console.ReadLine();

            Console.Write("\n=====Result======\n");
            bool checkFirstName = user.ValidateFirstName(firstName);
            bool checkLastName = user.ValidateLastName(lastName);
            bool checkEmail = user.ValidateEmail(email);
            bool checkMobileNumber = user.ValidateMobileNumber(mobile);
            bool checkPassword = user.ValidatePassword(password);

            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4} ",
                              (checkFirstName) ? "First name is valid" : "First name is invalid",
                              (checkLastName) ? "Last name is valid" : "Last name is invalid",
                              (checkEmail) ? "Email address is valid" : "Email address is invalid",
                              (checkMobileNumber) ? "Mobile number is valid" : "Mobile number is invalid",
                              (checkPassword) ? "Password is valid" : "Password is invalid");

        }
    }
}

//User Registration Problem

// Exception Handling Results

//Welcome To N unit testing and Exception handling For User Registration Problem

//Please enter user details

//First Name:     Shivaraj
//Last Name:     Gowda
//Email:     4shivaraj.gowda @gmail.com
//Mobile Number:     91 8618199771
//Password:     abcdfghihgE1@

//=====Result======

//First name is valid
//Last name is valid
//Email address is valid
//Mobile number is valid
//Password is valid

//========================================//

//N Unit Test Results

//UserRegistrationNunitTest
//  Tests in group: 5

//  Total Duration: 54 ms

//Outcomes
//   5 Passed

//========================================//