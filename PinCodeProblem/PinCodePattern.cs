using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeProblem
{
    class PinCodePattern
    {
        public static string PINCODEPATTERN="^[1-9][0-9]{5}$";
        public bool validatePinCode(string pinCode)
        {
            return Regex.IsMatch(pinCode, PINCODEPATTERN);
        }
    }
}
