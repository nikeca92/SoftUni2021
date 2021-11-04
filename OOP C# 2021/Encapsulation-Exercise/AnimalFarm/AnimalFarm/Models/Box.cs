using System;

namespace AnimalFarm.Models
{
    public class Box
    {
        private  int length;
        private int width;
        private int height;

        public int Length
        {
            get { return length; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                }
                else
                {
                    length = value;
                }
            }
        }

        public int Width
        {
            get { return width; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                }
                else
                {
                    width = value;
                }
            }
        }

        public int Height
        {
            get { return height; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                }
                else
                {
                    height = value;

                }
            }
        }

        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int GetSurfaceArea(int length,int width,int height)
        {
            //Surface Area = 2lw + 2lh + 2wh
            int area = (2 * height * width) + (2 * length * height) + (2 * width * height);
            return area;

        }

        public int GetLateralSurfaceArea(int length, int width, int height)
        {
            //Lateral Surface Area = 2lh + 2wh
            int area = (2 * length * height) + (2 * width * height);
            return area;
        }

        public int GetVolume(int length, int width, int height)
        {
            //Volume = lwh
            int volume = length * width * height;
            return volume;
        }

    }
}
