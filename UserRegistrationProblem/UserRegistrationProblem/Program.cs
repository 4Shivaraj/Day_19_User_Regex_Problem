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
                Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n4.Mobile Number\n5.Password Rule1\n6.Password Rule2" +
                    "\n7.Password Rule3\n8.Password Rule4\n9.Email Sample");
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
                    case 6:
                        PassWordRule2 passWordRule2 = new PassWordRule2();
                        bool valid6Test1 = passWordRule2.validatePassword2("A123abcd");
                        bool valid6Test2 = passWordRule2.validatePassword2("12345678");
                        bool valid6Test3 = passWordRule2.validatePassword2("abcd");
                        Console.WriteLine("{0} {1} {2}", (valid6Test1) ? "Valid" : "Invalid", (valid6Test2) ? "Valid" : "Invalid", (valid6Test3) ? "Valid" : "Invalid");
                        break;
                    case 7:
                        PassWordRule3 passWordRule3 = new PassWordRule3();
                        bool valid7Test1 = passWordRule3.validatePassword3("abcdfghihgE1");
                        bool valid7Test2 = passWordRule3.validatePassword3("15678");
                        bool valid7Test3 = passWordRule3.validatePassword3("Abccdabcd");
                        Console.WriteLine("{0} {1} {2}", (valid7Test1) ? "Valid" : "Invalid", (valid7Test2) ? "Valid" : "Invalid", (valid7Test3) ? "Valid" : "Invalid");
                        break;
                    case 8:
                        PassWordRule4 passWordRule4 = new PassWordRule4();
                        bool valid8Test1 = passWordRule4.validatePassword4("abc@12356");
                        bool valid8Test2 = passWordRule4.validatePassword4("abcdfghihgE1@");
                        bool valid8Test3 = passWordRule4.validatePassword4("123abcd");
                        Console.WriteLine("{0} {1} {2}", (valid8Test1) ? "Valid" : "Invalid", (valid8Test2) ? "Valid" : "Invalid", (valid8Test3) ? "Valid" : "Invalid");
                        break;
                    case 9:
                        EmailSample emailSample = new EmailSample();
                        List<string> validtests = new List<string>() {"abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,
                                                     "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};

                        foreach (var test in validtests)
                        {
                            bool result = emailSample.validateEmail(test);
                            if (result)
                            {
                                Console.WriteLine("\n{0} is a valid email address", test);
                            }
                            else
                            {
                                Console.WriteLine("\n{0} is an invalid email address", test);
                            }
                        }
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


//UC-9
//Should clear all email samples provided separately

//Result
//Welcome To User Registration Problems
//1.First Name
//2.Last Name
//3.Email
//4.Mobile Number
//5.Password Rule1
//6.Password Rule2
//7.Password Rule3
//8.Password Rule4
//9.Email Sample
//Enter Your Option
//9

//abc@yahoo.com is a valid email address

//abc-100@yahoo.com is a valid email address

//abc.100@yahoo.com is a valid email address

//abc111@abc.com is a valid email address

//abc-100@abc.net is a valid email address

//abc.100@abc.com.au is a valid email address

//abc@1.com is a valid email address

//abc@gmail.com.com is a valid email address

//abc+100@gmail.com is a valid email address

//abc is an invalid email address

//abc@.com.my is an invalid email address

//abc123@gmail.a is an invalid email address

//abc123@.com is an invalid email address

//abc123@.com.com is an invalid email address

//.abc@abc.com is an invalid email address

//abc()*@gmail.com is an invalid email address

//abc@%*.com is an invalid email address

//abc..2002@gmail.com is an invalid email address

//abc.@gmail.com is an invalid email address

//abc@abc@gmail.com is an invalid email address

//abc@gmail.com.1a is an invalid email address

//abc@gmail.com.aa.au is an invalid email address