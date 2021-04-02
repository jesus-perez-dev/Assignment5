using System;

namespace Problem1
{
    public abstract class Toy : IToy
    {
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

        public double Cost { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ManufacturingCompany { get; set; }
        public int YearOfManufacture { get; set; }
        public int MinimumAgeLimit { get; set; }
        public int MaximumAgeLimit { get; set; }
        public bool ChockingHazard { get; set; }
        public double Weight { get; set; }
    }
}