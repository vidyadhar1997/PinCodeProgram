using System;

namespace PinCodeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to pin code program");
            Console.WriteLine("Enter the pin code =");
            String pinCode=Console.ReadLine();
            PinCodePattern pinCodePattern = new PinCodePattern();
            Console.WriteLine(pinCodePattern.validatePinCode(pinCode));
        }
    }
}
