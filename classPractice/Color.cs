using System;

namespace classPractice
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

        public byte getRed()
        {
            return red;
        }

        public void setRed(byte red)
        {
            this.red = red;
        }

        public byte getBlue()
        {
            return blue;
        }

        public void setBlue(byte blue)
        {
            this.blue = blue;
        }

        public byte getGreen()
        {
            return green;
        }

        public void setGreen(byte green)
        {
            this.green = green;
        }

        public byte getAlpha()
        {
            return alpha;
        }

        public void setAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public double calculateGrayscale()
        {
            return ((double)red + (double)blue + (double)green)/3;
        }

    }
}

