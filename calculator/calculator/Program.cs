using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions fnc = new Functions();

            Console.WriteLine("*** Welcome to calculator! ***");

            fnc.Add(5, 5);
            fnc.Subtract(1, 4);
            //tehth

            Console.ReadKey();
        }
    }
}
