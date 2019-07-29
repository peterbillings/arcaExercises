using System;

namespace Exercise3S1
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalNumber;
            double fractionalPart; 
            double wholePart;

            Console.Write("Enter a number (double): ");

            totalNumber = Convert.ToDouble(Console.ReadLine());
            
            fractionalPart = totalNumber % 1.0;

            wholePart = Math.Truncate(totalNumber);

            // fractionalPart = totalNumber - wholePart;

            Console.WriteLine($"Whole part: {wholePart}\nFractional part: {fractionalPart}");
        }
    }
}
