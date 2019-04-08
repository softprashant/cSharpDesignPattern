using System;

namespace Solid_Principles
{
    public class OpenClosedPrinciple
    {
        // The class should open for extension but closed for modifications

        public static void Work()
        {
            var calculator = new Calculator();
            calculator.Add(15, 1);
            Console.WriteLine($"Added  : {calculator.Result}");
            calculator.Subtract(calculator.Result, 3);
            Console.WriteLine($"Subtracted  : {calculator.Result}");
            Console.ReadLine();
        }
    }

    // A basic calculator , should Add and subtract
    public class Calculator
    {
        public int Result { get; internal set; } // here we could have used 
        // private but we may want the class to open so that the child can also operate
        // so made it internal

        public void Add(int currentNumber, int howMuchToAdd)
        {
            Result = currentNumber + howMuchToAdd;
        }

        public void Subtract(int currentNumber, int howMuchToSubstract)
        {
            Result = currentNumber - howMuchToSubstract;
        }
    }

    public class AdvanceCalculator : Calculator
    {
        public void Multiply(int currentNumber, int howMuchToMulitply)
        {
            Result = currentNumber * howMuchToMulitply;
        }
    }
}
