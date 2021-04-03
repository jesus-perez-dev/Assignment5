/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem2
{
    /// <summary>
    /// Builder which implements the computer builder interface
    /// </summary>
    public class ComputerBuilder : IComputerBuilder
    {
        /// <summary>
        /// The computer
        /// </summary>
        private readonly Computer _computer;

        /// <summary>
        /// Creates a new builder and computer
        /// </summary>
        public ComputerBuilder()
        {
            _computer = new Computer();
        }
        
        /// <summary>
        /// Sets a hard drive to the computer
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="type"></param>
        /// <param name="readSpeed"></param>
        /// <param name="writeSpeed"></param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder SetHardDrive(double capacity, string type, double readSpeed, double writeSpeed)
        {
            var hardDrive = new HardDrive(capacity, type, readSpeed, writeSpeed);
            _computer.HardDrive = hardDrive;
            return this;
        }

        /// <summary>
        /// Sets a motherboard without cpu, memory, and graphics card to the computer
        /// </summary>
        /// <param name="numberOfMemorySlots"></param>
        /// <param name="powerConsumption"></param>
        /// <param name="numberOfPciSlots"></param>
        /// <param name="formFactor"></param>
        /// <param name="hardDriveLimit"></param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder SetMotherBoard(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit)
        {
            var motherboard = new Motherboard(numberOfMemorySlots, powerConsumption, numberOfPciSlots, formFactor,
                hardDriveLimit);
            _computer.Motherboard = motherboard;
            return this;
        }
        
        /// <summary>
        /// Sets a motherboard with cpu, memory, and graphics card to the computer
        /// </summary>
        /// <param name="numberOfMemorySlots"></param>
        /// <param name="powerConsumption"></param>
        /// <param name="numberOfPciSlots"></param>
        /// <param name="formFactor"></param>
        /// <param name="hardDriveLimit"></param>
        /// <param name="cpu"></param>
        /// <param name="memory"></param>
        /// <param name="graphicsCard"></param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder SetMotherBoardAdvanced(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit, Cpu cpu, Memory memory, GraphicsCard graphicsCard)
        {
            var motherboard = new Motherboard(numberOfMemorySlots, powerConsumption, numberOfPciSlots, formFactor,
                hardDriveLimit, cpu, memory, graphicsCard);
            _computer.Motherboard = motherboard;
            return this;
        }

        /// <summary>
        /// Sets a CPU to the computer and motherboard
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="manufacturer"></param>
        /// <param name="socketType"></param>
        /// <param name="cacheSize"></param>
        /// <param name="numberOfCores"></param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder SetCpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores)
        {
            var cpu = new Cpu(speed, manufacturer, socketType, cacheSize, numberOfCores);
            _computer.Cpu = cpu;
            if (_computer.Motherboard != null)
                _computer.Motherboard.Cpu = cpu;
            return this;
        }

        /// <summary>
        /// Sets memory to the computer and motherboard
        /// </summary>
        /// <param name="readSpeed"></param>
        /// <param name="writeSpeed"></param>
        /// <param name="type"></param>
        /// <param name="amountInGb"></param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder SetMemory(double readSpeed, double writeSpeed, string type, double amountInGb)
        {
            var memory = new Memory(readSpeed, writeSpeed, type, amountInGb);
            _computer.Memory = memory;
            if (_computer.Motherboard != null)
                _computer.Motherboard.Memory = memory;
            return this;
        }

        /// <summary>
        /// Sets a graphics card to the computer and motherboard
        /// </summary>
        /// <param name="fanCount"></param>
        /// <param name="speed"></param>
        /// <param name="videoMemory"></param>
        /// <param name="amountOfCudaCores"></param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder SetGraphicsCard(int fanCount, double speed, double videoMemory, int amountOfCudaCores)
        {
            var graphicsCard = new GraphicsCard(fanCount, speed, videoMemory, amountOfCudaCores);
            _computer.GraphicsCard = graphicsCard;
            if (_computer.Motherboard != null)
                _computer.Motherboard.GraphicsCard = graphicsCard;
            return this;
        }

        /// <summary>
        /// Sets a case to the computer and motherboard
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="numberOfFans"></param>
        /// <param name="numberOfVents"></param>
        /// <returns>The computer builder</returns>
        public IComputerBuilder SetCase(double length, double width, double height, int numberOfFans, int numberOfVents)
        {
            var cCase = new Case(length, width, height, numberOfFans, numberOfVents);
            _computer.Case = cCase;
            return this;
        }

        /// <summary>
        /// Builds a computer
        /// </summary>
        /// <returns>The built computer</returns>
        public Computer Build()
        {
            return _computer;
        }
    }
}