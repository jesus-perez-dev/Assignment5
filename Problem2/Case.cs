/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

using System;

namespace Problem2
{
    /// <summary>
    /// A computer case
    /// </summary>
    public class Case
    {
        /// <summary>
        /// Its length
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// Its width
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Its height
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Its number of fans
        /// </summary>
        public int NumberOfFans { get; set; }
        /// <summary>
        /// Its number of vents
        /// </summary>
        public int NumberOfVents { get; set; }

        /// <summary>
        /// Full constructor for a case
        /// </summary>
        /// <param name="length">Its length</param>
        /// <param name="width">Its width</param>
        /// <param name="height">Its height</param>
        /// <param name="numberOfFans">Its number of fans</param>
        /// <param name="numberOfVents">Its number of vents</param>
        /// <exception cref="ArgumentException">Exception if an argument is invalid</exception>
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