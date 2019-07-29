using System;

namespace PrintOddity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another number: ");

            int number2 = Convert.ToInt32(Console.ReadLine());

            int sumOfNumbers = number1 + number2;

            if (sumOfNumbers % 2 == 0)
            {
                if (number1 % 2 == 0)
                {
                    Console.WriteLine($"Two evens make an even and the number is: {sumOfNumbers}");
                }
                else
                {
                    Console.WriteLine($"Two odds make an even and the number is: {sumOfNumbers}");
                }
            }
            else if (number1 % 2 == 0)
            {
                Console.WriteLine($"The odd number is: {number2} \nThe even number is: {number1}");
            }
            else
            {
                Console.WriteLine($"The odd number is: {number1} \nThe even number is: {number2}");
            }
        }
    }
}
