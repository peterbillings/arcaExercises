using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle equilateralTriangle = new Triangle(4, 4, 4);

            Triangle scaleneTriangle = new Triangle(4, 5, 8);

            Triangle isocelesTriangle = new Triangle(5, 5, 1);

            Triangle rightTriangle = new Triangle(3, 4, 5);

            Triangle acuteTriangle = new Triangle(8, 15, 13);

            Triangle obtuseTriangle = new Triangle(5, 8 , 7);

            Triangle invalidTriangle = new Triangle(3, 4, 10);

            printTriangleSummary(equilateralTriangle);

            printTriangleSummary(scaleneTriangle);

            printTriangleSummary(isocelesTriangle);

            printTriangleSummary(rightTriangle);

            printTriangleSummary(acuteTriangle);

            printTriangleSummary(obtuseTriangle);

            printTriangleSummary(invalidTriangle);
        }

        public static void printTriangleSummary(Triangle triangle)
        {
            bool isValidTriangle = triangle.isValid();

            bool isRightTriangle = triangle.isRightAngle();

            bool isEquilateral = triangle.isEquilateral();

            bool isIsoceles = triangle.isIsoceles();

            bool isScalene = triangle.isScalene();

            bool isAcute = triangle.isAcute();

            bool isObtuse = triangle.isObtuse();

            if (!isValidTriangle)
            {
                Console.WriteLine("The sides do not create a valid triangle!");
                return;
            }

            Console.WriteLine($"Side A: {triangle.SideA} \nSide B: {triangle.SideB} \nSide C: {triangle.SideC}");

            Console.WriteLine($"The perimeter is: {triangle.getPerimeter()}");

            if (isRightTriangle)
            {
                Console.WriteLine("This is a right triangle.");
            }
            else
            {
                Console.WriteLine("This is not a right triangle.");
            }

            if (isEquilateral)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else
            {
                Console.WriteLine("The triangle is not equilateral.");
            }

            if (isIsoceles)
            {
                Console.WriteLine("The triangle is isoceles.");
            }
            else
            {
                Console.WriteLine("The triangle is not isoceles.");
            }

            if (isScalene)
            {
                Console.WriteLine("The triangle is scalene.");
            }
            else
            {
                Console.WriteLine("The triangle is not scalene.");
            }

            if (isAcute)
            {
                Console.WriteLine("The triangle is acute.");
            }
            else
            {
                Console.WriteLine("The triangle is not acute.");
            }

            if (isObtuse)
            {
                Console.WriteLine("The triangle is obtuse.");
            }
            else
            {
                Console.WriteLine("The triangle is not obtuse.");
            }

            Console.WriteLine();
            
        }
    }
}
