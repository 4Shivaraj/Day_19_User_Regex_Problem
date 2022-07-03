// See https://aka.ms/new-console-template for more information
using System;


namespace UserRegistrationNunitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To N unit testing and Exception handling For User Registration Problem");
            //char ch;
            //do
            //{

            //Console.Write("\nPlease enter user details\n");*/
            //    UserRegistrationDetails user = new UserRegistrationDetails();
            //    menu(user);
            //    Console.Write("\nDo you want to continue?(y/n)    ");
            //    ch = Convert.ToChar(Console.ReadLine());
            //    Console.Clear();
            //} while (ch == 'y');

            //Console.ReadKey();
        }

        //private static void menu(UserRegistrationDetails user)
        //{

        //    Console.Write("\nFirst Name:     ");
        //    string firstName = Console.ReadLine();

        //    Console.Write("Last Name:     ");
        //    string lastName = Console.ReadLine();

        //    Console.Write("Email:     ");
        //    string email = Console.ReadLine();

        //    Console.Write("Mobile Number:     ");
        //    string mobile = Console.ReadLine();
        //    Console.Write("Password:     ");
        //    string password = Console.ReadLine();

        //    Console.Write("\n=====Result======\n");
        //    bool checkFirstName = user.ValidateFirstName(firstName);
        //    bool checkLastName = user.ValidateLastName(lastName);
        //    bool checkEmail = user.ValidateEmail(email);
        //    bool checkMobileNumber = user.ValidateMobileNumber(mobile);
        //    bool checkPassword = user.ValidatePassword(password);

        //    Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4} ",
        //                      (checkFirstName) ? "First name is valid" : "First name is invalid",
        //                      (checkLastName) ? "Last name is valid" : "Last name is invalid",
        //                      (checkEmail) ? "Email address is valid" : "Email address is invalid",
        //                      (checkMobileNumber) ? "Mobile number is valid" : "Mobile number is invalid",
        //                      (checkPassword) ? "Password is valid" : "Password is invalid");

        //    string EMail1 = "abc@gamil.com";
        //    string EMail2 = "abc.bcd@gmail.com";
        //    string EMail3 = "abc.bdc100@gmail.com";
        //    string EMail4 = "abc.ghj111@gmail.com";
        //    string EMail5 = "abc.efgh@gmail.com";

        //    user.CheckMultipleEmail(EMail1, EMail2, EMail3, EMail4, EMail5);

        
    }
}

//UC-12
//Refactor the Code to throw custom exceptions in case of Invalid User Details 
//    - Rewrite all Test Cases to take in Custom Exception for Invalid First Name, Last Name, Email, Mobile, and Password

//RESULT
//UserRegNunitTesting
//  Tests in group: 30

//  Total Duration: 26 ms

//Outcomes
//   30 Passed

