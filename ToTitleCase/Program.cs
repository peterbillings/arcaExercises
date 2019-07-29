using System;

namespace ToTitleCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Please enter the string you wish to convert to Title Case\n\n>> ");

            input = Console.ReadLine();

            titleCase tC = new titleCase(input);

            Console.WriteLine(tC.InputString);

            Console.WriteLine(tC.makeTitleCase());
        }
    }
}
