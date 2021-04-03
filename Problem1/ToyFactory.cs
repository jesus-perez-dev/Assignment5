using System;
using System.Linq;

namespace Problem1
{
    public class ToyFactory
    {
        public static T CreateToy<T>(double cost, string description, string name, string manufacturingCompany,
            int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight)
            where T : Toy
        {
            var type = typeof(T);
            // var type = typeof(Toy).Assembly
            //     .DefinedTypes
            //     .FirstOrDefault(c => typeof(Toy).IsAssignableFrom(typeof(T)));

            if (type == null)
            {
                throw new InvalidOperationException($"Unable to locate type: {typeof(T).AssemblyQualifiedName}");
            }

            var constructor = type.GetConstructor(new Type[] {typeof(double), typeof(string), typeof(string), 
                typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(double)
            });

            if (constructor == null)
            {
                throw new InvalidOperationException(
                    $"Type {typeof(T).AssemblyQualifiedName} does not have a constructor matching the given parameters");
            }

            // invoke the parameterized constructor on the given object, using the provided parameters
            return (T) constructor.Invoke(new object[]
            {
                cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
                chockingHazard, weight
            });
        }

        // public static IToy CreateToy(ToyType type, double cost, string description, string name,
        //     string manufacturingCompany, int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit,
        //     bool chockingHazard, double weight)
        // {
        //     switch (type)
        //     {
        //         case ToyType.Car:
        //             return new Car(cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit,
        //                 maximumAgeLimit, chockingHazard, weight);
        //         case ToyType.Dollhouse:
        //             return new Dollhouse(cost, description, name, manufacturingCompany, yearOfManufacture,
        //                 minimumAgeLimit,
        //                 maximumAgeLimit, chockingHazard, weight);
        //         case ToyType.StuffedAnimal:
        //             return new StuffedAnimal(cost, description, name, manufacturingCompany, yearOfManufacture,
        //                 minimumAgeLimit,
        //                 maximumAgeLimit, chockingHazard, weight);
        //         case ToyType.RainbowStacker:
        //             return new RainbowStacker(cost, description, name, manufacturingCompany, yearOfManufacture,
        //                 minimumAgeLimit,
        //                 maximumAgeLimit, chockingHazard, weight);
        //         default:
        //             return null;
        //     }
        // }
    }
}