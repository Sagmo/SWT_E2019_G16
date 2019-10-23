using System;

namespace calculator
{
    class Functions
    {
        public double Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("Adding: " + a + " + " + b + " = " + c);

            return c;
        }

        public double Subtract(double a, double b)
        {
            double c = a - b;
            Console.WriteLine("Subtracting: " + a + " - " + b + " = " + c);

            return c;
        }

        public double Multiply(double a, double b)
        {
            double c = a * b;
            Console.WriteLine("Multiplying: " + a + " * " + b + " = " + c);

            return c;
        }

        public double Power(double x, double exp)
        {
            double c = Math.Pow(x, exp);

            Console.WriteLine("Power: " + x + " ^ " + exp + " = " + c);

            return c;
        }
    }
}
