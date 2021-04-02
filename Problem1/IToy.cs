namespace Problem1
{
    public interface IToy
    {
        double Cost { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        string ManufacturingCompany { get; set; }
        int YearOfManufacture { get; set; }
        int MinimumAgeLimit { get; set; }
        int MaximumAgeLimit { get; set; }
        bool ChockingHazard { get; set; }
        double Weight { get; set; }
    }
}