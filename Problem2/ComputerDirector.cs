/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem2
{
    /// <summary>
    /// Director to construct a computer
    /// </summary>
    public class ComputerDirector
    {
        /// <summary>
        /// Constructs a computer using a builder
        /// </summary>
        /// <param name="builder">The builder</param>
        /// <returns>The constructed computer</returns>
        public Computer Construct(IComputerBuilder builder)
        {
            return builder.Build();
        }
    }
}