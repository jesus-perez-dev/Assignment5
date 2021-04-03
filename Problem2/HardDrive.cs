using System;

namespace Problem2
{
    public class HardDrive
    {
        public double Capacity { get; set; }
        public string Type { get; set; }
        public double ReadSpeed { get; set; }
        public double WriteSpeed { get; set; }

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