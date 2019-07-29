using System;

namespace ForeachPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] {23, 45, 3, -1, 55, -100, 76, 4, 98, 1000};

            double sum = 0, average, min = numbers[0], current;

            foreach (double number in numbers)
            {
                current = number;

                sum += current;

                if ( current < min )
                    min = current;
            }

            average = sum / numbers.Length;

            Console.WriteLine($"The mininum value in numbers is: {min}");
            Console.WriteLine($"The average value in numbers is: {average}");
        }
    }
}
