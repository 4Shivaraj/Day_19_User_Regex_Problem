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
                Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n4.Mobile Number\n5.Password Rule1");
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
                    case 4:
                        ValidMobileNumber validMobileNumber = new ValidMobileNumber();
                        bool valid4Test1 = validMobileNumber.validateMobileNumber("91 9919819801");
                        bool valid4Test2 = validMobileNumber.validateMobileNumber("12345678");
                        bool valid4Test3 = validMobileNumber.validateMobileNumber("123abcd");
                        Console.WriteLine("{0} {1} {2}", (valid4Test1) ? "Valid" : "Invalid", (valid4Test2) ? "Valid" : "Invalid", (valid4Test3) ? "Valid" : "Invalid");
                        break;
                    case 5:
                        PassWordRule1 passWordRule1 = new PassWordRule1();
                        bool valid5Test1 = passWordRule1.validatePassword("1234pass");
                        bool valid5Test2 = passWordRule1.validatePassword("123ab");
                        bool valid5Test3 = passWordRule1.validatePassword("123abced12");
                        Console.WriteLine("{0} {1} {2}", (valid5Test1) ? "Valid" : "Invalid", (valid5Test2) ? "Valid" : "Invalid", (valid5Test3) ? "Valid" : "Invalid");
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


//UC-5
//As a User need to follow pre-defined Password rules.
//Rule1
//– minimum 8 Characters 
//- NOTE – All rules must be passed

//Result
//Welcome To User Registration Problems
//1.First Name
//2.Last Name
//3.Email
//4.Mobile Number
//5.Password Rule1
//Enter Your Option
//5
//Valid Invalid Valid