using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);

            Circle circle2 = new Circle(4);

            Console.WriteLine(circle.Radius);

            Console.WriteLine(circle.getDiameter());

            Console.WriteLine(circle.getArea());

            Console.WriteLine(circle2.Radius);

            Console.WriteLine(circle2.getDiameter());

            Console.WriteLine(circle2.getArea());
        }
    }
}
