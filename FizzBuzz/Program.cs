using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz! Press ENTER to continue!");
            Console.ReadLine();
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i);
                }

                if ( i % 3 == 0 )
                {
                    Console.Write("Fizz");
                }
                    
                if ( i % 5 == 0 )
                {
                    Console.Write("Buzz");
                }

                Console.WriteLine();
            }
        }
    }
}
