using System;

namespace Problem2
{
    public class Motherboard
    {
        public int NumberOfMemorySlots { get; set; }
        public double PowerConsumption { get; set; }
        public int NumberOfPciSlots { get; set; }
        public string FormFactor { get; set; }
        public int HardDriveLimit { get; set; }
        public Cpu Cpu { get; set; }
        public Memory Memory { get; set; }
        public GraphicsCard GraphicsCard { get; set; }

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