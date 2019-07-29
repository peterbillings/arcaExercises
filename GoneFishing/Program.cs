using System;

namespace GoneFishing
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat();

            boat.CaughtSmallFish();

            Console.WriteLine("The weight should be 1 and it is: " + boat.GetTotalWeight());

            boat.CaughtMediumFish();

            Console.WriteLine("The weight should be 6 and it is: " + boat.GetTotalWeight());

            boat.CaughtBigFish();

            Console.WriteLine("The weight should be 16 and it is: " + boat.GetTotalWeight());

            boat.CaughtSmallFish(185);

            Console.WriteLine("The weight should be 201 and it is: " + boat.GetTotalWeight());

            if(boat.IsCloseToSinking())
            {
                Console.WriteLine("Danger! Your boat is about to sink!");
            }

            boat.CaughtBigFish();

            Console.WriteLine("The weight should be 211 and it is: " + boat.GetTotalWeight());

            if(boat.IsSunk())
            {
                Console.WriteLine("If your weren't aware, your boat has sunk! Look out for vengeful fish!");
            }
        }
    }
}
