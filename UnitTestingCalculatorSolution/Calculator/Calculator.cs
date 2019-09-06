﻿using System;

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
            if(b == 0)
            {
                throw new System.DivideByZeroException();
            }
            try
            {
                Accumulator = a / b;
            }
            catch (DivideByZeroException)
            {
                //Console.WriteLine("ERROR: Trying to divide {0}, by zero", a);
                return Accumulator = 0;
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
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

    }
}
