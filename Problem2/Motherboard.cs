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
    /// A computer motherboard
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// Its number of memory slots
        /// </summary>
        public int NumberOfMemorySlots { get; set; }
        /// <summary>
        /// Its power consumption
        /// </summary>
        public double PowerConsumption { get; set; }
        /// <summary>
        /// Its number of PCI slots
        /// </summary>
        public int NumberOfPciSlots { get; set; }
        /// <summary>
        /// Its form factor
        /// </summary>
        public string FormFactor { get; set; }
        /// <summary>
        /// Its hard drive limit
        /// </summary>
        public int HardDriveLimit { get; set; }
        /// <summary>
        /// Its CPU
        /// </summary>
        public Cpu Cpu { get; set; }
        /// <summary>
        /// Its memory
        /// </summary>
        public Memory Memory { get; set; }
        /// <summary>
        /// Its graphics card
        /// </summary>
        public GraphicsCard GraphicsCard { get; set; }

        /// <summary>
        /// Constructor for a motherboard without CPU, memory, and graphics card
        /// </summary>
        /// <param name="numberOfMemorySlots">Its number of memory slots</param>
        /// <param name="powerConsumption">Its power consumption</param>
        /// <param name="numberOfPciSlots">Its number of PCI slots</param>
        /// <param name="formFactor">Its form factor</param>
        /// <param name="hardDriveLimit">Its hard drive limit</param>
        /// <exception cref="ArgumentException">Exception if an argument is invalid</exception>
        public Motherboard(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor, int hardDriveLimit)
        {
            if (numberOfMemorySlots <= 0)
                throw new ArgumentException("Number of memory slots must be greater than 0");

            if (powerConsumption <= 0)
                throw new ArgumentException("Power consumption must be greater than 0");
            
            if (numberOfPciSlots <= 0)
                throw new ArgumentException("Number of PCI slots must be greater than 0");
            
            if (hardDriveLimit <= 0)
                throw new ArgumentException("Hard drive limit must be greater than 0");
            
            NumberOfMemorySlots = numberOfMemorySlots;
            PowerConsumption = powerConsumption;
            NumberOfPciSlots = numberOfPciSlots;
            FormFactor = formFactor;
            HardDriveLimit = hardDriveLimit;
        }

        /// <summary>
        /// Full constructor for a motherboard with CPU, memory, and graphics card
        /// </summary>
        /// <param name="numberOfMemorySlots">Its number of memory slots</param>
        /// <param name="powerConsumption">Its power consumption</param>
        /// <param name="numberOfPciSlots">Its number of PCI slots</param>
        /// <param name="formFactor">Its form factor</param>
        /// <param name="hardDriveLimit">Its hard drive limit</param>
        /// <param name="cpu">Its CPU</param>
        /// <param name="memory">Its memory</param>
        /// <param name="graphicsCard">Its graphics card</param>
        /// <exception cref="ArgumentException">Exception if an argument is invalid</exception>
        public Motherboard(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit, Cpu cpu, Memory memory, GraphicsCard graphicsCard)
        {
            if (numberOfMemorySlots <= 0)
                throw new ArgumentException("Number of memory slots must be greater than 0");

            if (powerConsumption <= 0)
                throw new ArgumentException("Power consumption must be greater than 0");
            
            if (numberOfPciSlots <= 0)
                throw new ArgumentException("Number of PCI slots must be greater than 0");
            
            if (hardDriveLimit <= 0)
                throw new ArgumentException("Hard drive limit must be greater than 0");
            
            NumberOfMemorySlots = numberOfMemorySlots;
            PowerConsumption = powerConsumption;
            NumberOfPciSlots = numberOfPciSlots;
            FormFactor = formFactor;
            HardDriveLimit = hardDriveLimit;
            Cpu = cpu;
            Memory = memory;
            GraphicsCard = graphicsCard;
        }
    }
}