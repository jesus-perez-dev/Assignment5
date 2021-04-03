/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem1
{
    /// <summary>
    /// A stuffed animal toy
    /// </summary>
    public class StuffedAnimal : Toy
    {
        /// <summary>
        /// Full constructor of a stuffed animal 
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
        public StuffedAnimal(double cost, string description, string name, string manufacturingCompany,
            int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight) : base(
            cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
            chockingHazard, weight)
        {
            BowtieColour = "Red";
            IsCute = true;
            HasBeenHugged = false;
        }

        /// <summary>
        /// The colour of its bowtie
        /// </summary>
        public string BowtieColour { get; set; }
        /// <summary>
        /// Whether it is cute or not
        /// </summary>
        public bool IsCute { get; set; }
        /// <summary>
        /// Whether it has been hugged yet or not
        /// </summary>
        public bool HasBeenHugged { get; set; }

        /// <summary>
        /// Renames the stuffed animal
        /// </summary>
        /// <param name="name">Its new name</param>
        public void Rename(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Hugs the stuffed animal
        /// </summary>
        public void Hug()
        {
            HasBeenHugged = true;
        }
    }
}