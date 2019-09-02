using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions fnc = new Functions();

            Console.WriteLine("*** Welcome to calculator! ***");

            fnc.Add(3, 4);

        }
    }
}
