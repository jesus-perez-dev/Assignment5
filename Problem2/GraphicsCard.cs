using System;

namespace Problem2
{
    public class GraphicsCard
    {
        public int FanCount { get; set; }
        public double Speed { get; set; }
        public double VideoMemory { get; set; }
        public int AmountOfCudaCores { get; set; }

        public GraphicsCard(int fanCount, double speed, double videoMemory, int amountOfCudaCores)
        {
            if (fanCount <= 0)
                throw new ArgumentException("Fan count must be greater than 0");
            
            if (speed <= 0)
                throw new ArgumentException("Speed must be greater than 0");
            
            if (videoMemory <= 0)
                throw new ArgumentException("Video memory must be greater than 0");
            
            if (amountOfCudaCores <= 0)
                throw new ArgumentException("Amount of CUDA cores must be greater than 0");
            
            FanCount = fanCount;
            Speed = speed;
            VideoMemory = videoMemory;
            AmountOfCudaCores = amountOfCudaCores;
        }
    }
}