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
        string patternMob = @"/^(\+\d{1,3}[- ]?)?\d{10}$/";
        string patternPass = @"[a-z,A-Z,0-9]{8,}$";
        public void Validating(string input)
        {
            Regex regex = new Regex(patternPass);
            Console.WriteLine("Validating the Password");
            ValidatingMob(input);
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
        public void ValidatingMob(string inputMob)
        {
            Regex regex = new Regex(patternMob);
            bool res = regex.IsMatch(inputMob);
            if (res)
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
        }
        public void ValidatingPass(string inputPass)
        {
            Regex regex = new Regex(patternPass);
            bool res = regex.IsMatch(inputPass);
            if (res)
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}