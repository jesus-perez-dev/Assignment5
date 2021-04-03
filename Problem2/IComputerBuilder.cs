/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem2
{
    public interface IComputerBuilder
    {
        /// <summary>
        /// Sets a hard drive to the computer
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="type"></param>
        /// <param name="readSpeed"></param>
        /// <param name="writeSpeed"></param>
        /// <returns>The computer builder</returns>
        IComputerBuilder SetHardDrive(double capacity, string type, double readSpeed, double writeSpeed);
        /// <summary>
        /// Sets a motherboard without cpu, memory, and graphics card to the computer
        /// </summary>
        /// <param name="numberOfMemorySlots"></param>
        /// <param name="powerConsumption"></param>
        /// <param name="numberOfPciSlots"></param>
        /// <param name="formFactor"></param>
        /// <param name="hardDriveLimit"></param>
        /// <returns>The computer builder</returns>
        IComputerBuilder SetMotherBoard(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit);
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
        IComputerBuilder SetMotherBoardAdvanced(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit, Cpu cpu, Memory memory, GraphicsCard graphicsCard);
        /// <summary>
        /// Sets a CPU to the computer and motherboard
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="manufacturer"></param>
        /// <param name="socketType"></param>
        /// <param name="cacheSize"></param>
        /// <param name="numberOfCores"></param>
        /// <returns>The computer builder</returns>
        IComputerBuilder SetCpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores);
        /// <summary>
        /// Sets memory to the computer and motherboard
        /// </summary>
        /// <param name="readSpeed"></param>
        /// <param name="writeSpeed"></param>
        /// <param name="type"></param>
        /// <param name="amountInGb"></param>
        /// <returns>The computer builder</returns>
        IComputerBuilder SetMemory(double readSpeed, double writeSpeed, string type, double amountInGb);
        /// <summary>
        /// Sets a graphics card to the computer and motherboard
        /// </summary>
        /// <param name="fanCount"></param>
        /// <param name="speed"></param>
        /// <param name="videoMemory"></param>
        /// <param name="amountOfCudaCores"></param>
        /// <returns>The computer builder</returns>
        IComputerBuilder SetGraphicsCard(int fanCount, double speed, double videoMemory, int amountOfCudaCores);
        /// <summary>
        /// Sets a case to the computer and motherboard
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="numberOfFans"></param>
        /// <param name="numberOfVents"></param>
        /// <returns>The computer builder</returns>
        IComputerBuilder SetCase(double length, double width, double height, int numberOfFans, int numberOfVents);
        /// <summary>
        /// Builds a computer
        /// </summary>
        /// <returns>The built computer</returns>
        Computer Build();
    }
}