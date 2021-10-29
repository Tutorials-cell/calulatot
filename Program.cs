using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator objcalculator = new calculator();
            Console.WriteLine("total values="+ objcalculator.issum(30,20));
            Console.ReadKey();
        }
    }
}
