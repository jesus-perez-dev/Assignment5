/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem1
{
    /// <summary>
    /// The interface with all the properties to be implemented in a toy
    /// </summary>
    public interface IToy
    {
        /// <summary>
        /// Its cost
        /// </summary>
        double Cost { get; set; }
        /// <summary>
        /// Its description
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Its name
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Its manufacturing company
        /// </summary>
        string ManufacturingCompany { get; set; }
        /// <summary>
        /// Its year of manufacture
        /// </summary>
        int YearOfManufacture { get; set; }
        /// <summary>
        /// Its minimum age to play with
        /// </summary>
        int MinimumAgeLimit { get; set; }
        /// <summary>
        /// Its maximum age to play with
        /// </summary>
        int MaximumAgeLimit { get; set; }
        /// <summary>
        /// Whether it is a chocking hazard or not
        /// </summary>
        bool ChockingHazard { get; set; }
        /// <summary>
        /// Its weight
        /// </summary>
        double Weight { get; set; }
    }
}