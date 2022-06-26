// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("Welcome To User Registration Problems");
                Console.WriteLine("1.First Name\n2.Last Name");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        ValidFirstName validFirstName = new ValidFirstName();
                        bool validTest1 = validFirstName.validateFirstName("Shivaraj");
                        bool validTest2 = validFirstName.validateFirstName("4Shivaraj");
                        bool validTest3 = validFirstName.validateFirstName("shivaraj");
                        Console.WriteLine("{0} {1} {2}", (validTest1) ? "Valid" : "Invalid", (validTest2) ? "Valid" : "Invalid", (validTest3) ? "Valid" : "Invalid");
                        break;
                    case 2:
                        validLastName validLastName = new validLastName();
                        bool valid2Test1 = validLastName.validateLastName("Gowda");
                        bool valid2Test2 = validLastName.validateLastName("4Gowda");
                        bool valid2Test3 = validLastName.validateLastName("gowda");
                        Console.WriteLine("{0} {1} {2}", (valid2Test1) ? "Valid" : "Invalid", (valid2Test2) ? "Valid" : "Invalid", (valid2Test3) ? "Valid" : "Invalid");
                        break;
                    default:
                        Console.WriteLine("-------Enter the valid option---");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}


//UC-2
//As a User need to enter a valid Last Name 
//- Last name starts with Cap and has minimum 3 characters

//Result
//Welcome To User Registration Problems
//1.First Name
//2.Last Name
//Enter Your Option
//2
//Valid Invalid Invalid