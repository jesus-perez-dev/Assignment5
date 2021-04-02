namespace Problem1
{
    public class ToyFactory
    {
        public static IToy CreateToy(ToyType type, double cost, string description, string name,
            string manufacturingCompany, int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit,
            bool chockingHazard, double weight)
        {
            switch (type)
            {
                case ToyType.Car:
                    return new Car(cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit,
                        maximumAgeLimit, chockingHazard, weight);
                case ToyType.Dollhouse:
                    return new Dollhouse(cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit,
                        maximumAgeLimit, chockingHazard, weight);
                case ToyType.StuffedAnimal:
                    return new StuffedAnimal(cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit,
                        maximumAgeLimit, chockingHazard, weight);
                case ToyType.RainbowStacker:
                    return new RainbowStacker(cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit,
                        maximumAgeLimit, chockingHazard, weight);
                default:
                    return null;
            }
        }
    }
}