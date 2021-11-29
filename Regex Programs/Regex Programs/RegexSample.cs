using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Programs
{
    class RegexSample
    {
        string pattern = "^[A-Za-z]{2,}$";
        string patternEmail = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public void Validating(string input)
        {
            Regex regex = new Regex(patternEmail);
            Console.WriteLine("Validating the Email Addr.");
            ValidatingEmail(input);
        }
        public void ValidatingFirstName(string input)
        {
            Regex regex = new Regex(pattern);

            bool res = regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
        public void ValidatingLastName(string inputLast)
        {
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(inputLast);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatingEmail(string inputMail)
        {
            Regex regex = new Regex(patternEmail);
            bool res = regex.IsMatch(inputMail);
            if (res)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}