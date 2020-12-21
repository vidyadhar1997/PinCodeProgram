using System;

namespace PinCodeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pin code program");
            Console.WriteLine("Enter pin code =");
            String pinCode=Console.ReadLine();
            Console.WriteLine("Enter pin code for validating space =");
            String pinCode1 = Console.ReadLine();
            PinCodePattern pinCodePattern = new PinCodePattern();
            Console.WriteLine(pinCodePattern.validatePinCode(pinCode));
            Console.WriteLine(pinCodePattern.validatePinCode(pinCode1));
        }
    }
}
