using System;

namespace Regex_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Regex Program Press- 1-Validate Name, 2-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("User Registration Validating using Regular Expression!");
                        RegexSample regexSample = new RegexSample();
                        Console.WriteLine("Enter the First Name to Check Validation:");
                        string input = Console.ReadLine();
                        regexSample.ValidatingFirstName(input);
                        regexSample.Validating();
                        break;
                }
            }
        }
    }
}
