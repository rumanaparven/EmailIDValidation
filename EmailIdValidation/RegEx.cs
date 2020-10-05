using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailIdValidation
{
    class RegEx
    {
        public void EmailIdValidation(string emailid)
        {
            Regex regx = new Regex("^([a-z\\d-\\.]+)@([a-z\\d-]+)\\.([a-z]+)(\\.[a-z])?");
            if (regx.IsMatch(emailid))
            {
                Console.WriteLine("Valid EmailId");
            }
            else
            {
                Console.WriteLine("Invalid EmailId");
            }
        }
    }
}
