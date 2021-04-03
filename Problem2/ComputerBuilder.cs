namespace Problem2
{
    public class ComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }
        
        public IComputerBuilder SetHardDrive(double capacity, string type, double readSpeed, double writeSpeed)
        {
            var hardDrive = new HardDrive(capacity, type, readSpeed, writeSpeed);
            _computer.HardDrive = hardDrive;
            return this;
        }

        public IComputerBuilder SetMotherBoard(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit)
        {
            var motherboard = new Motherboard(numberOfMemorySlots, powerConsumption, numberOfPciSlots, formFactor,
                hardDriveLimit);
            _computer.Motherboard = motherboard;
            return this;
        }
        
        public IComputerBuilder SetMotherBoardAdvanced(int numberOfMemorySlots, double powerConsumption, int numberOfPciSlots, string formFactor,
            int hardDriveLimit, Cpu cpu, Memory memory, GraphicsCard graphicsCard)
        {
            var motherboard = new Motherboard(numberOfMemorySlots, powerConsumption, numberOfPciSlots, formFactor,
                hardDriveLimit, cpu, memory, graphicsCard);
            _computer.Motherboard = motherboard;
            return this;
        }

        public IComputerBuilder SetCpu(double speed, string manufacturer, string socketType, double cacheSize, int numberOfCores)
        {
            var cpu = new Cpu(speed, manufacturer, socketType, cacheSize, numberOfCores);
            _computer.Cpu = cpu;
            _computer.Motherboard.Cpu = cpu;
            return this;
        }

        public IComputerBuilder SetMemory(double readSpeed, double writeSpeed, string type, double amountInGb)
        {
            var memory = new Memory(readSpeed, writeSpeed, type, amountInGb);
            _computer.Memory = memory;
            _computer.Motherboard.Memory = memory;
            return this;
        }

        public IComputerBuilder SetGraphicsCard(int fanCount, double speed, double videoMemory, int amountOfCudaCores)
        {
            var graphicsCard = new GraphicsCard(fanCount, speed, videoMemory, amountOfCudaCores);
            _computer.GraphicsCard = graphicsCard;
            _computer.Motherboard.GraphicsCard = graphicsCard;
            return this;
        }

        public IComputerBuilder SetCase(double length, double width, double height, int numberOfFans, int numberOfVents)
        {
            var cCase = new Case(length, width, height, numberOfFans, numberOfVents);
            _computer.Case = cCase;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}