/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

namespace Problem1
{
    /// <summary>
    /// A toy car
    /// </summary>
    public class Car : Toy
    {
        /// <summary>
        /// Full constructor for a toy car
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
        public Car(double cost, string description, string name, string manufacturingCompany, int yearOfManufacture,
            int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight) : base(cost,
            description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
            chockingHazard, weight)
        {
            Speed = 10.2;
            NumberOfWheels = 4;
            WheelType = "Round";
        }

        /// <summary>
        /// Its speed
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// Number of wheels it has
        /// </summary>
        public int NumberOfWheels { get; set; }
        /// <summary>
        /// What kind of wheels it has
        /// </summary>
        public string WheelType { get; set; }

        /// <summary>
        /// Increases the speed of the car
        /// </summary>
        public void IncreaseSpeed()
        {
            Speed++;
        }

        /// <summary>
        /// Lose a wheel    
        /// </summary>
        public void LoseAWheel()
        {
            if (NumberOfWheels > 0)
            {
                NumberOfWheels--;
            }
        }
    }
}