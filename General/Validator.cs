using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace General
{
    public class Validator
    {
        public static bool ValidateEmail(string emailAddress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            foreach (string i in emailAddress.Split(';'))
            {
                if (!regex.Match(i).Success)
                    return false;
            }

            return true;

            //Match match = regex.Match(emailAddress);
            //if (match.Success)
            //    return true;
            //else
            //    return false;
        }


    }
}
