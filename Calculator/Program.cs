using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new SimpleCalculator();

            var num1 = 1;
            var num2 = 3;
            Console.WriteLine("Numbers {0} and {1} added together is {2}", num1, num2, calc.Add(num1, num2));
            Console.WriteLine("Numbers {0} and {1} subtracted gives {2}", num1, num2, calc.Subtract(num1, num2));
            Console.WriteLine("Numbers {0} and {1} multiplied gives {2}", num1, num2, calc.Multiply(num1, num2));
        }
    }
}