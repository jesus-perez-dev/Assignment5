namespace Problem2
{
    public class Computer
    {
        public HardDrive HardDrive { get; set; }
        public Motherboard Motherboard { get; set; }
        public Cpu Cpu { get; set; }
        public Memory Memory { get; set; }
        public GraphicsCard GraphicsCard { get; set; }
        public Case Case { get; set; }

        public Computer()
        {
        }

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