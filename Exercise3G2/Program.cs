using System;

namespace Exercise3G2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the width of the floor: ");

            double floorWidth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the length of the floor: ");

            double floorLength = Convert.ToDouble(Console.ReadLine());

            double floorArea = floorWidth * floorLength;

            double tileWastage = Math.Floor(floorArea * 0.10);

            double totalTiles = floorArea + tileWastage;

            double totalBoxes = Math.Ceiling(totalTiles / 8.0);

            Console.WriteLine($"The total number of boxes of tiles needed is: {totalBoxes}");

            // double totalBoxes = calcTotalBoxes(calcTotalTiles(calcFloorArea(floorWidth, floorLength), calcTileWastage(calcFloorArea(floorWidth, floorLength))));

            // Console.WriteLine($"The total number of boxes of tiles needed is: {totalBoxes}");
        }

        public static double calcFloorArea(double width, double length)
        {
             return width * length;
        }

        public static double calcTileWastage(double area)
        {
            return Math.Floor(area * 0.10);
        }

        public static double calcTotalTiles(double area, double wastage)
        {
            return area + wastage;
        }

        public static double calcTotalBoxes(double totalTiles)
        {
            return Math.Ceiling(totalTiles / 8.0);
        }
    }
}
