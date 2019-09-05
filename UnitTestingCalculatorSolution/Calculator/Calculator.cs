using System;

namespace Calculator
{
    public class Calculator
    {
        private double lastResult = 0;
        public double Add(double a, double b)
        {
            lastResult = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            lastResult = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            lastResult = a * b;
            return a * b;
        }

        public double Power(double a, double b)
        {
            lastResult = Math.Pow(a,b);
            return Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {
            lastResult = a / b;
            Accumulator.set(lastResult);
            return Accumulator.get;
        }

        public double Accumulator {get; private set; }


    }
}
