﻿using System;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;

            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;

            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;


            }
        }

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public string GetSurfaceArea(double length, double width, double height)
        {
            //Surface Area = 2lw + 2lh + 2wh
            double area = (2 * length * width) + (2 * length * height) + (2 * width * height);
            return $"Surface Area - {area:F2}";

        }

        public string GetLateralSurfaceArea(double length, double width, double height)
        {
            //Lateral Surface Area = 2lh + 2wh
            double area = (2 * length * height) + (2 * width * height);
            return $"Lateral Surface Area - {area:F2}";
        }

        public string GetVolume(double length, double width, double height)
        {
            //Volume = lwh
            double volume = length * width * height;
            return $"Volume - {volume:F2}";
        }

    }
}
