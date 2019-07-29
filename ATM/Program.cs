using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int withdrawal = 137;

            int twenties = withdrawal / 20;

            int tens = (withdrawal % 20) / 10;

            int fives = (withdrawal % 10) / 5;

            int ones = (withdrawal % 5);

            int totalBills = twenties + tens + fives + ones;

            double convenienceFee = 1.00 + (double)totalBills * 0.10;

            Console.WriteLine($"Withdrawal: {withdrawal}");

            Console.WriteLine($"$20 ({twenties}) \n$10 ({tens})");

            Console.WriteLine($"$5 ({fives}) \n$1 ({ones})");

            Console.WriteLine($"Your fee is: ${convenienceFee} ($1.00 + $0.10 times {totalBills} bills.)");
        }
    }
}
