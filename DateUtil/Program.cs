using System;

namespace DateUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            Date singleDigitDate = new Date(1, 2, 2019);

            Date doubleDigitDate = new Date(01, 02, 2019);

            Console.WriteLine($"{singleDigitDate.Day}, {singleDigitDate.Month}, {singleDigitDate.Year}");

            Console.WriteLine($"{doubleDigitDate.Day}, {doubleDigitDate.Month}, {doubleDigitDate.Year}");

            Console.WriteLine(singleDigitDate.GetFormattedDate());

            Console.WriteLine(doubleDigitDate.GetFormattedDate());
        }
    }
}
