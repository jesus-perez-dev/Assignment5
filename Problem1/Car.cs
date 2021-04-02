namespace Problem1
{
    public class Car : Toy
    {
        public Car(double cost, string description, string name, string manufacturingCompany, int yearOfManufacture,
            int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight) : base(cost,
            description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
            chockingHazard, weight)
        {
            Speed = 10.2;
            NumberOfWheels = 4;
            WheelType = "Round";
        }

        public double Speed { get; set; }
        public int NumberOfWheels { get; set; }
        public string WheelType { get; set; }

        public void IncreaseSpeed()
        {
            Speed++;
        }

        public void LoseAWheel()
        {
            if (NumberOfWheels > 0)
            {
                NumberOfWheels--;
            }
        }
    }
}