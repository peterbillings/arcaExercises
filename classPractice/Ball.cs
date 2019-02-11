using System;

namespace classPractice
{
    class Ball
    {
        private int size;
        private int throws;
        public Color ballColor = new Color();
        public Ball(int size, byte red, byte blue, byte green, byte alpha)
        {
            throws = 0;
            this.size = size;
            ballColor.setRed(red);
            ballColor.setBlue(blue);
            ballColor.setGreen(green);
            ballColor.setAlpha(alpha);
        }

        public Ball()
        {
            size = 1;
        }

        public void pop()
        {
            size = 0;
        }

        public void throwBall()
        {
            if (size > 0)
            {
                throws++;
            }
            else
            {
                Console.WriteLine("You can't throw a popped ball!");
            }
        }

        public int getSize()
        {
            return size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public int getThrows()
        {
            return throws;
        }
    }
}