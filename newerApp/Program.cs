using System;

namespace newerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Console.WriteLine($"words before {c1.returnMessage()} extra words");
        }
    }
}
