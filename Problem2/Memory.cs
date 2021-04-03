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
    /// Computer memory
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Its read speed
        /// </summary>
        public double ReadSpeed { get; set; }
        /// <summary>
        /// Its write speed
        /// </summary>
        public double WriteSpeed { get; set; }
        /// <summary>
        /// Its type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Its amount in GB
        /// </summary>
        public double AmountInGb { get; set; }

        /// <summary>
        /// Full constructor for memory
        /// </summary>
        /// <param name="readSpeed">Its read speed</param>
        /// <param name="writeSpeed">Its write speed</param>
        /// <param name="type">Its type</param>
        /// <param name="amountInGb">Its amount in GB</param>
        /// <exception cref="ArgumentException">Exception if an argument is invalid</exception>
        public Memory(double readSpeed, double writeSpeed, string type, double amountInGb)
        {
            if (readSpeed <= 0)
                throw new ArgumentException("Read speed must be greater than 0");
            
            if (writeSpeed <= 0)
                throw new ArgumentException("Read speed must be greater than 0");
            
            if (!(type.ToLower() == "ddr1" || type.ToLower() == "ddr2" || type.ToLower() == "ddr3" || type.ToLower() == "ddr4"))
                throw new ArgumentException("Type must be either DDR1, DDR2, DDR3 or DDR4");
            
            if (amountInGb <= 0)
                throw new ArgumentException("Amount in GB must be greater than 0");
            
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            Type = type;
            AmountInGb = amountInGb;
        }
    }
}