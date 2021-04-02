namespace Problem1
{
    public class StuffedAnimal : Toy
    {
        public StuffedAnimal(double cost, string description, string name, string manufacturingCompany,
            int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight) : base(
            cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
            chockingHazard, weight)
        {
            BowtieColour = "Red";
            IsCute = true;
            HasBeenHugged = false;
        }

        public string BowtieColour { get; set; }
        public bool IsCute { get; set; }
        public bool HasBeenHugged { get; set; }

        public void Rename(string name)
        {
            Name = name;
        }

        public void Hug()
        {
            HasBeenHugged = true;
        }
    }
}