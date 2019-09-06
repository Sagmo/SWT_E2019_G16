using System;
using CalculatorException;


namespace Calculator
{
    public class Calculator
    {
        NewDivideByZeroException dt = new NewDivideByZeroException();
        PowerImaginaryException ie = new PowerImaginaryException();

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
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

        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            Accumulator /= divisor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            bool ifInt = unchecked(exponent == (int) exponent);
            if(Accumulator < 0 && !ifInt)
            {
                throw new PowerImaginaryException();
            }
            
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

    }
}
