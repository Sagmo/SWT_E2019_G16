using System;
using CalculatorException;


namespace Calculator
{
    public class Calculator
    {
        NewDivideByZeroException dt = new NewDivideByZeroException();

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a,b);
            return Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new NewDivideByZeroException();
            }

            Accumulator = a / b;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Accumulator {get; private set; } = 0;

    }
}
