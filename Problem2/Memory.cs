using System;

namespace Problem2
{
    public class Memory
    {
        public double ReadSpeed { get; set; }
        public double WriteSpeed { get; set; }
        public string Type { get; set; }
        public double AmountInGb { get; set; }

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