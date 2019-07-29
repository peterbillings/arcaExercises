using System;

namespace PrintLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another number: ");

            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"The largest number is {number1}.");
            }
            else if (number2 > number1)
            {
                Console.WriteLine($"The largest number is {number2}.");
            }
            else
            {
                Console.WriteLine("The numbers are equal.");
            }
        }
    }
}
