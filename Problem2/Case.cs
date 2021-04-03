using System;

namespace Problem2
{
    public class Case
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int NumberOfFans { get; set; }
        public int NumberOfVents { get; set; }

        public Case(double length, double width, double height, int numberOfFans, int numberOfVents)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be greater than 0");
            
            if (width <= 0)
                throw new ArgumentException("Width must be greater than 0");
            
            if (height <= 0)
                throw new ArgumentException("Height must be greater than 0");
            
            if (numberOfFans <= 0)
                throw new ArgumentException("Number of fans must be greater than 0");
            
            if (numberOfVents <= 0)
                throw new ArgumentException("Number of vents must be greater than 0");
            
            Length = length;
            Width = width;
            Height = height;
            NumberOfFans = numberOfFans;
            NumberOfVents = numberOfVents;
        }
    }
}