using System;

namespace RefsDeux
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString, secondString, thirdString;

            firstString = "UP";

            secondString = "low";

            thirdString = "cOnfUSed";

            Console.WriteLine(firstString.ToUpper() + " " + secondString.ToUpper() + " " + thirdString.ToUpper());

        }
    }
}
