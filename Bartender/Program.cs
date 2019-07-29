using System;

namespace Bartender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please select a drink from the menu: ");
            Console.WriteLine("(1) Water \n(2) Cola \n(3) Glen Rio Ale");

            int drinkChoice = Convert.ToInt32(Console.ReadLine());

            bool checkAge = false;

            int age;

            switch (drinkChoice)
            {
                case 1:
                    Console.WriteLine("Here is your water!");
                    break;
                case 2:
                    Console.WriteLine("Here is your cola!");
                    break;
                case 3:
                    checkAge = true;
                    break;
                default:
                    Console.WriteLine("Invalid menu choice!");
                    break;
            }

            if (checkAge)
            {
                Console.Write("Please enter your age: ");

                age = Convert.ToInt32(Console.ReadLine());

                if (age >= 21)
                {
                    Console.WriteLine("Here is your Ale!");
                }
                else
                {
                    Console.Write($"No drink for you! Come back in {21 - age} year");

                    if (21 - age > 1)
                    {
                        Console.Write("s");
                    }

                    Console.WriteLine("!");
                }
            }
        }
    }
}
