/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem2
{
    /// <summary>
    /// A computer built out of multiple parts
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// Its hard drive
        /// </summary>
        public HardDrive HardDrive { get; set; }
        /// <summary>
        /// Its motherboard
        /// </summary>
        public Motherboard Motherboard { get; set; }
        /// <summary>
        /// Its CPU
        /// </summary>
        public Cpu Cpu { get; set; }
        /// <summary>
        /// Its memory
        /// </summary>
        public Memory Memory { get; set; }
        /// <summary>
        /// Its graphic card
        /// </summary>
        public GraphicsCard GraphicsCard { get; set; }
        /// <summary>
        /// Its case
        /// </summary>
        public Case Case { get; set; }
        
        /// <summary>
        /// Empty computer constructor
        /// </summary>
        public Computer()
        {
        }

        /// <summary>
        /// Full computer constructor
        /// </summary>
        /// <param name="hardDrive">Its hard drive</param>
        /// <param name="motherboard">Its motherboard</param>
        /// <param name="cpu">Its CPU</param>
        /// <param name="memory">Its memory</param>
        /// <param name="graphicsCard">Its graphic card</param>
        /// <param name="case">Its case</param>
        public Computer(HardDrive hardDrive, Motherboard motherboard, Cpu cpu, Memory memory, GraphicsCard graphicsCard, Case @case)
        {
            HardDrive = hardDrive;
            Motherboard = motherboard;
            Cpu = cpu;
            Memory = memory;
            GraphicsCard = graphicsCard;
            Case = @case;
        }
    }
}