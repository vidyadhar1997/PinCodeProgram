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

        /// <summary>
        /// Validates the pin code.
        /// </summary>
        /// <param name="pinCode">The pin code.</param>
        /// <returns></returns>
        public bool validatePinCode(string pinCode)
        {
            return Regex.IsMatch(pinCode, PINCODEPATTERN);
        }

        /// <summary>
        /// Validates the pin code foe space.
        /// </summary>
        /// <param name="pinCode1">The pin code1.</param>
        /// <returns></returns>
        public bool validatePinCodeFoeSpace(string pinCode1)
        {
            return Regex.IsMatch(pinCode1, PINCODEPATTERN1);
        }
    }
}
