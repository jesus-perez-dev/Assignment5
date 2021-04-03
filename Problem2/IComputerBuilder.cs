namespace Problem2
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetHardDrive(double capacity, string type, double readSpeed, double writeSpeed);
        IComputerBuilder SetMotherBoard(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit);
        IComputerBuilder SetMotherBoardAdvanced(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit, Cpu cpu, Memory memory, GraphicsCard graphicsCard);
        IComputerBuilder SetCpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores);
        IComputerBuilder SetMemory(double readSpeed, double writeSpeed, string type, double amountInGb);
        IComputerBuilder SetGraphicsCard(int fanCount, double speed, double videoMemory, int amountOfCudaCores);
        IComputerBuilder SetCase(double length, double width, double height, int numberOfFans, int numberOfVents);
        Computer Build();
    }
}