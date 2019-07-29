using System;

namespace RandomDicePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Please enter the number of 6 sided dice you wish to roll (0 to quit): ");

            int numberOfDice = Convert.ToInt32(Console.ReadLine());

            while (numberOfDice != 0)
            {
                int sum = 0;

                for (int i = 1; i <= numberOfDice; i++)
                {
                    sum += random.Next(6) + 1;
                }

                Console.WriteLine($"You rolled {numberOfDice} dice and your total was {sum}!");

                Console.WriteLine();

                Console.WriteLine("Please enter the number of 6 sided dice you wish to roll (0 to quit): ");

                numberOfDice = Convert.ToInt32(Console.ReadLine());   
            }

        }
    }
}
