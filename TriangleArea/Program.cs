using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleBase, triangleHeight, triangleArea;
            
            Console.WriteLine("Let's determine the area of a right triangle!\n\nPress ENTER to proceed!");

            Console.ReadKey();

            Console.Write("\nPlease enter the value for the triangle's base (b): ");

            triangleBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter the value for the triangle's height (h): ");

            triangleHeight = Convert.ToDouble(Console.ReadLine());

            triangleArea = (triangleBase * triangleHeight) / 2;

            Console.WriteLine($"\nThe area of your triangle is: {triangleArea}\n");
        }
    }
}
