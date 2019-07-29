using System;

namespace CatLives
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat garfield = new Cat();

            Cat sam = garfield;

            Console.WriteLine($"Before killing Sam, Garfield has {garfield.Lives} lives");

            sam.Kill();

            Console.WriteLine($"After killing Sam, Garfield has {garfield.Lives} lives");

            garfield.Kill();

            Console.WriteLine($"After killing Garfield, Sam now has {sam.Lives} lives");

        }
    }
}
