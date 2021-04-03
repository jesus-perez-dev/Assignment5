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
    /// A computer CPU
    /// </summary>
    public class Cpu
    {
        /// <summary>
        /// Its speed
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// Its manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Its socket type
        /// </summary>
        public string SocketType { get; set; }
        /// <summary>
        /// Its cache size
        /// </summary>
        public double CacheSize { get; set; }
        /// <summary>
        /// Its number of cores
        /// </summary>
        public int NumberOfCores { get; set; }
        
        /// <summary>
        /// Full constructor for a CPU
        /// </summary>
        /// <param name="speed">Its speed</param>
        /// <param name="manufacturer">Its manufacturer</param>
        /// <param name="socketType">Its socket type</param>
        /// <param name="cacheSize">Its cache size</param>
        /// <param name="numberOfCores">Its number of cores</param>
        /// <exception cref="ArgumentException">Exception if an argument is invalid</exception>
        public Cpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores)
        {
            if (speed <= 0)
                throw new ArgumentException("CPU speed must be greater than 0");
            
            if (!(manufacturer.ToLower() == "intel" || manufacturer.ToLower() == "amd"))
                throw new ArgumentException("Type must be either Intel or AMD");

            if (cacheSize <= 0)
                throw new ArgumentException("Cache size must be greater than 0");
            
            if (numberOfCores <= 0)
                throw new ArgumentException("Number of cores must be greater than 0");
            
            Speed = speed;
            Manufacturer = manufacturer;
            SocketType = socketType;
            CacheSize = cacheSize;
            NumberOfCores = numberOfCores;
        }
    }
}