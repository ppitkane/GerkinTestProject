using System;

namespace Calculator
{
    public class SimpleCalculator
    {
        public Decimal Add(Decimal num1, Decimal num2)
        {
            return num1 + num2;
        }
        
        public Decimal Subtract(Decimal num1, Decimal num2)
        {
            return num1 - num2;
        }
        
        public Decimal Multiply(Decimal num1, Decimal num2)
        {
            return num1 * num2;
        }
        
        public Decimal Divide(Decimal num1, Decimal num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Cannot divide by zero");
            return num1 / num2;
        }
    }
}