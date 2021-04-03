namespace Problem2
{
    public class ComputerDirector
    {
        public Computer Construct(IComputerBuilder builder)
        {
            return builder.Build();
        }
    }
}