using System;

namespace LargeOrSmall
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter an integer number: ");

            number = Convert.ToInt32(Console.ReadLine());

            if (number > 99)
            {
                Console.WriteLine("The number is large");
            }
            else if (number < 10)
            {
                Console.WriteLine("The number is small");
            }
            else
            {
                Console.WriteLine("The number is neither large nor small");
            }
        }
    }
}
