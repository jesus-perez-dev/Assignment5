/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem1
{
    /// <summary>
    /// The implementation of the toy interface
    /// </summary>
    public abstract class Toy : IToy
    {
        /// <summary>
        /// Full constructor of a toy
        /// </summary>
        /// <param name="cost">Its cost</param>
        /// <param name="description">Its description</param>
        /// <param name="name">Its name</param>
        /// <param name="manufacturingCompany">Its manufacturing company</param>
        /// <param name="yearOfManufacture">Its year of manufacture</param>
        /// <param name="minimumAgeLimit">Its minimum age to play with</param>
        /// <param name="maximumAgeLimit">Its maximum age to play with</param>
        /// <param name="chockingHazard">Whether it is a chocking hazard or not</param>
        /// <param name="weight">Its weight</param>
        protected Toy(double cost, string description, string name, string manufacturingCompany, int yearOfManufacture,
            int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight)
        {
            Cost = cost;
            Description = description;
            Name = name;
            ManufacturingCompany = manufacturingCompany;
            YearOfManufacture = yearOfManufacture;
            MinimumAgeLimit = minimumAgeLimit;
            MaximumAgeLimit = maximumAgeLimit;
            ChockingHazard = chockingHazard;
            Weight = weight;
        }

        /// <summary>
        /// Its cost
        /// </summary>
        public double Cost { get; set; }
        /// <summary>
        /// Its description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Its name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Its manufacturing company
        /// </summary>
        public string ManufacturingCompany { get; set; }
        /// <summary>
        /// Its year of manufacture
        /// </summary>
        public int YearOfManufacture { get; set; }
        /// <summary>
        /// Its minimum age to play with
        /// </summary>
        public int MinimumAgeLimit { get; set; }
        /// <summary>
        /// Its maximum age to play with
        /// </summary>
        public int MaximumAgeLimit { get; set; }
        /// <summary>
        /// Whether it is a chocking hazard or not
        /// </summary>
        public bool ChockingHazard { get; set; }
        /// <summary>
        /// Its weight
        /// </summary>
        public double Weight { get; set; }
    }
}