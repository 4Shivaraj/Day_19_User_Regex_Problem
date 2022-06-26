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
                Console.WriteLine("1.First Name\n2.Last Name\n3.Email");
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
                    case 3:
                        ValidEmail validEmail = new ValidEmail();
                        bool valid3Test1 = validEmail.validateEmail("abc.xyz@bl.co.in");
                        bool valid3Test2 = validEmail.validateEmail("abc.xyz@in");
                        bool valid3Test3 = validEmail.validateEmail("abc.@bl.co.in");
                        Console.WriteLine("{0} {1} {2}", (valid3Test1) ? "Valid" : "Invalid", (valid3Test2) ? "Valid" : "Invalid", (valid3Test3) ? "Valid" : "Invalid");
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


//UC-3
/// As a User need to enter a valid email
//- E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl& co) and 
//2 optional (xyz & in) with precise @ and . positions

//Result
//Welcome To User Registration Problems
//1.First Name
//2.Last Name
//3.Email
//Enter Your Option
//3
//Valid Invalid Invalid