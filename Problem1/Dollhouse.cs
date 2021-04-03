/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem1
{
    /// <summary>
    /// A dollhouse toy
    /// </summary>
    public class Dollhouse : Toy
    {
        /// <summary>
        /// Full constructor of a dollhouse 
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
        public Dollhouse(double cost, string description, string name, string manufacturingCompany,
            int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight) : base(
            cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
            chockingHazard, weight)
        {
            NumberOfRooms = 3;
            HasFurniture = true;
            RoofColour = "White";
        }
        
        /// <summary>
        /// Number of rooms in the dollhouse
        /// </summary>
        public int NumberOfRooms { get; set; }
        /// <summary>
        /// Whether it has furniture or not
        /// </summary>
        public bool HasFurniture { get; set; }
        /// <summary>
        /// The colour of the roof
        /// </summary>
        public string RoofColour { get; set; }

        /// <summary>
        /// Adds a new room to the dollhouse
        /// </summary>
        public void ExpandHouse()
        {
            NumberOfRooms++;
        }

        /// <summary>
        /// Changes the colour of the roof
        /// </summary>
        /// <param name="colour">The new roof colour</param>
        public void ChangeRoofColour(string colour)
        {
            RoofColour = colour;
        }
    }
}