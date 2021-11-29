using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Programs
{
    class RegexSample
    {
        string pattern = "^[A-Za-z]{2,}$";
        public void Validating(string input)
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating the First Name");
            ValidatingFirstName(input);
            Console.WriteLine("Validating the Last Name");
            ValidatingLastName(input);
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
    }
}