using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pyramidBase;

            Console.Write("Enter the base of the pyramid (int): ");

            pyramidBase = Convert.ToInt32(Console.ReadLine());

            int totalStars = 1;

            int totalSpaces = (pyramidBase - 1)/2;

            for (int row = 1; row <= (pyramidBase + 1)/2; row++)
            {
                for (int spaces = 1; spaces <= totalSpaces; spaces++)
                {
                    Console.Write(" ");
                }

                for (int stars = 1; stars <= totalStars; stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                totalStars += 2;

                totalSpaces -= 1;
            }    
        }
    }
}
