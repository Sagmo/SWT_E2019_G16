using System;

namespace Calculator
{
    public class Calculator
    {
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
            try
            {
                Accumulator = a / b;
            }
            catch (DivideByZeroException)
            {
                //Console.WriteLine("ERROR: Trying to divide {0}, by zero", a);
                Accumulator = 0;
            }
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Accumulator {get; private set; } = 0;

        public double Add(double addend)
        {

        }

        public double Subtract(double subtractor)
        {

        }

        public double Multiply(double multiplier)
        {

        }

        public double Divide(double divisor)
        {

        }

        public double Power(double exponent)
        {

        }

    }
}
