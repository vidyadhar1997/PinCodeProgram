using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeProblem
{
    class PinCodePattern
    {
        public static string PINCODEPATTERN="^[1-9][0-9]{5}$";
        public static string PINCODEPATTERN1 = "^[1-9]{1}[0-9]{2}[ ][0-9]{3}$";
        public bool validatePinCode(string pinCode)
        {
            return Regex.IsMatch(pinCode, PINCODEPATTERN);
        }
        public bool validatePinCodeFoeSpace(string pinCode1)
        {
            return Regex.IsMatch(pinCode1, PINCODEPATTERN1);
        }
    }
}
