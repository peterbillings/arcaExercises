using System;

namespace PropertiesPractice
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color (byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public Color ()
        {
            red = 0;
            blue = 0;
            green = 0;
            alpha = 255;
        }

        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                if (value < 0)
                {
                    red = 0;
                }
                if (value > 255)
                {
                    red = 255;
                }
                else
                {
                    red = value;
                }
            }
        }

        public byte Blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (value < 0)
                {
                    blue = 0;
                }
                if (value > 255)
                {
                    blue = 255;
                }
                else
                {
                    blue = value;
                }
            }
        }

        public byte Green
        {
            get
            {
                return green;
            }
            set
            {
                if (value < 0)
                {
                    green = 0;
                }
                if (value > 255)
                {
                    green = 255;
                }
                else
                {
                    green = value;
                }
            }
        }
        
        public byte Alpha
        {
            get
            {
                return alpha;
            }

            set
            {
                if (value < 0)
                {
                    alpha = 0;
                }
                if (value > 255)
                {
                    alpha = 255;
                }
                else
                {
                    alpha = value;
                }
            }
        }

        public double calculateGrayscale()
        {
            return ((double)red + (double)blue + (double)green)/3;
        }
    }
}
