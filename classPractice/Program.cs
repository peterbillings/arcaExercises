using System;

namespace classPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color color = new Color(255, 255, 255);

            // Console.WriteLine($"{color.getRed()}, {color.getBlue()}, {color.getGreen()}, {color.getAlpha()}");

            // color.setRed(150);

            // color.setBlue(54);

            // color.setGreen(234);

            // color.setAlpha(10);

            // Console.WriteLine($"{color.getRed()}, {color.getBlue()}, {color.getGreen()}, {color.getAlpha()}");

            // Console.WriteLine(color.calculateGrayscale());

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

            Console.WriteLine($"{ball.ballColor.getRed()}, {ball.ballColor.getBlue()}, {ball.ballColor.getGreen()}");

            Console.WriteLine(ball.getSize());
            ball.setSize(100);
            Console.WriteLine(ball.getSize());
            ball.pop();
            Console.WriteLine(ball.getSize());
            ball.throwBall();

        }
    }
}
