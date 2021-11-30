using System;

namespace Regex_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            RegexSample regexSample = new RegexSample();
            while (flag)
            {
                Console.WriteLine("User Registration Validating Using Regular Expression!");
                Console.WriteLine("Enter your Choice Number to Execute the Regex Program Press- 1-Validate First Name, 2-Validate Last Name, 3-Validate Mobile Number,4-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:                        
                        Console.WriteLine("Enter the First Name to Check Validation:");
                        string input = Console.ReadLine();
                        regexSample.ValidatingFirstName(input);
                        regexSample.Validating(input);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Last Name to Check Validation:");
                        string inputLast = Console.ReadLine();
                        regexSample.ValidatingLastName(inputLast);
                        regexSample.Validating(inputLast);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Email to Check Validation:");
                        string inputMail = Console.ReadLine();
                        regexSample.ValidatingEmail(inputMail);
                        regexSample.Validating(inputMail);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Mobile Number to Check Validation:");
                        string inputMob = Console.ReadLine();
                        regexSample.ValidatingMob(inputMob);
                        regexSample.Validating(inputMob);
                        break;                      
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}