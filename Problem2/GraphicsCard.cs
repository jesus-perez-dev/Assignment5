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
    /// A computer graphics card
    /// </summary>
    public class GraphicsCard
    {
        /// <summary>
        /// Its fan count
        /// </summary>
        public int FanCount { get; set; }
        /// <summary>
        /// Its speed
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// Its video memory
        /// </summary>
        public double VideoMemory { get; set; }
        /// <summary>
        /// Its amount of CUDA cores
        /// </summary>
        public int AmountOfCudaCores { get; set; }

        /// <summary>
        /// Full constructor for a graphics card
        /// </summary>
        /// <param name="fanCount">Its fan count</param>
        /// <param name="speed">Its speed</param>
        /// <param name="videoMemory">Its video memory</param>
        /// <param name="amountOfCudaCores">Its amount of CUDA cores</param>
        /// <exception cref="ArgumentException">Exception if an argument is invalid</exception>
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