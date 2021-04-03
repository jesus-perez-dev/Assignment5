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
    /// A computer hard drive
    /// </summary>
    public class HardDrive
    {
        /// <summary>
        /// Its capacity
        /// </summary>
        public double Capacity { get; set; }
        /// <summary>
        /// Its type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Its read speed
        /// </summary>
        public double ReadSpeed { get; set; }
        /// <summary>
        /// Its write speed
        /// </summary>
        public double WriteSpeed { get; set; }

        /// <summary>
        /// Full constructor for a hard drive
        /// </summary>
        /// <param name="capacity">Its capacity</param>
        /// <param name="type">Its type</param>
        /// <param name="readSpeed">Its read speed</param>
        /// <param name="writeSpeed">Its write speed</param>
        /// <exception cref="ArgumentException">Exception if an argument is invalid</exception>
        public HardDrive(double capacity, string type, double readSpeed, double writeSpeed)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0");

            if (!(type.ToLower() == "ssd" || type.ToLower() == "hdd"))
                throw new ArgumentException("Type must be either SSD or HDD");
            
            if (readSpeed <= 0)
                throw new ArgumentException("Read speed must be greater than 0");
            
            if (writeSpeed <= 0)
                throw new ArgumentException("Write speed must be greater than 0");
            
            Capacity = capacity;
            Type = type;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
        }
    }
}