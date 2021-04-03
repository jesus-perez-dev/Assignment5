using System;

namespace Problem2
{
    public class Cpu
    {
        public double Speed { get; set; }
        public string Manufacturer { get; set; }
        public string SocketType { get; set; }
        public double CacheSize { get; set; }
        public int NumberOfCores { get; set; }

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