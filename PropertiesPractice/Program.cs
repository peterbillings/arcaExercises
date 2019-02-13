using System;

namespace PropertiesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(255, 255, 255);

            Console.WriteLine($"{color.Red}, {color.Red}, {color.Green}, {color.Alpha}");

            color.Red = 150;

            color.Blue = 54;

            color.Green = 125;

            color.Alpha = 10;

            Console.WriteLine($"{color.Red}, {color.Blue}, {color.Green}, {color.Alpha}");

            Console.WriteLine(Math.Floor(color.calculateGrayscale()));

            Ball ball = new Ball(1, 255, 150, 100, 50);

            Ball ball2 = new Ball();

            ball2.throwBall();
            Console.WriteLine(ball2.getThrows());
            ball2.throwBall();
            Console.WriteLine(ball2.getThrows());
            ball2.throwBall();
            Console.WriteLine(ball2.getThrows());
            ball2.throwBall();
            Console.WriteLine(ball2.getThrows());

            Console.WriteLine($"{ball.ballColor.Red}, {ball.ballColor.Blue}, {ball.ballColor.Green}");

            Console.WriteLine(ball.getSize());
            ball.setSize(100);
            Console.WriteLine(ball.getSize());
            ball.pop();
            Console.WriteLine(ball.getSize());
            ball.throwBall();
        }
    }
}
