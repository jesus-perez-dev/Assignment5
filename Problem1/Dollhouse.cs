namespace Problem1
{
    public class Dollhouse : Toy
    {
        public Dollhouse(double cost, string description, string name, string manufacturingCompany,
            int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight) : base(
            cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
            chockingHazard, weight)
        {
            NumberOfRooms = 3;
            HasFurniture = true;
            RoofColour = "White";
        }
        
        public int NumberOfRooms { get; set; }
        public bool HasFurniture { get; set; }
        public string RoofColour { get; set; }

        public void ExpandHouse()
        {
            NumberOfRooms++;
        }

        public void ChangeRoofColour(string colour)
        {
            RoofColour = colour;
        }
    }
}