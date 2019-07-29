using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(4, 5);

            Rectangle rectangle2 = new Rectangle(5, 20);

            Console.WriteLine($"The height is: {rectangle1.Height}");

            Console.WriteLine($"The width is: {rectangle1.Width}");

            rectangle1.DoubleHeight();

            rectangle1.DoubleWidth();

            Console.WriteLine($"The height is now: {rectangle1.Height}");

            Console.WriteLine($"The width is now: {rectangle1.Width}");

            rectangle1.Rotate();

            Console.WriteLine($"The height is now: {rectangle1.Height}");

            Console.WriteLine($"The width is now: {rectangle1.Width}");

            if(rectangle2.CanContain(rectangle1))
            {
                Console.WriteLine("Rectangle2 can contain Rectangle1");
            }
            else
            {
                Console.WriteLine("Rectangle2 cannot contain Rectangle1");
            }

            rectangle1.GetDisplay();

            rectangle2.GetDisplay();
        }
    }
}
