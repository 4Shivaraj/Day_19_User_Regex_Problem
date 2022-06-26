// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problems");

            //UC-1
            ValidFirstName validFirstName = new ValidFirstName();
            bool validTest1 = validFirstName.validateFirstName("Shivaraj");
            bool validTest2 = validFirstName.validateFirstName("4Shivaraj");
            bool validTest3 = validFirstName.validateFirstName("shivaraj");
            Console.WriteLine("{0} {1} {2}", (validTest1) ? "Valid" : "Invalid", (validTest2) ? "Valid" : "Invalid", (validTest3) ? "Valid" : "Invalid");
            Console.ReadKey();
        }
    }
}
//UC-1
//As a User need to enter a valid First Name
//- First name starts with Cap and has minimum 3 characters

//Result
//Welcome To User Registration Problems
//Valid Invalid Invalid