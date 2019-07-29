using System;

namespace Rectangle
{
    class Rectangle
    {
        public int Height {get; private set;}
        public int Width {get; private set;}

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public void DoubleHeight()
        {
            this.Height *= 2;
        }

        public void DoubleWidth()
        {
            this.Width *= 2;
        }

        public void Rotate()
        {
            int numberHolder;

            numberHolder = this.Height;

            this.Height = this.Width;

            this.Width = numberHolder;
        }

        public bool CanContain(Rectangle rectangle)
        {
            if (this.Height >= rectangle.Height && this.Width >= rectangle.Width ||
                this.Height >= rectangle.Width && this.Width >= rectangle.Height)
            {
                return true;
            }

            return false;
        }

        public void GetDisplay()
        {
            for (int i = 0; i < this.Width; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < this.Height; i++)
            {
                Console.WriteLine();

                Console.Write("*");

                for(int n = 0; n < this.Width - 2; n++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
            }

            Console.WriteLine();

            for (int i = 0; i < this.Width; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


    }
}