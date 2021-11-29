using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regex_Programs
{
    class RegexSample
    {
        string pattern = "^[A-Za-z]{2,}$";
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
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating the First Name");
        }
    }
}
