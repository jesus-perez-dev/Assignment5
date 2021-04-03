/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

using System;

namespace Problem1
{
    /// <summary>
    /// The factory to create toys
    /// </summary>
    public class ToyFactory
    {
        /// <summary>
        /// Creates a toy
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
        /// <typeparam name="T">The type of toy to create</typeparam>
        /// <returns>The created toy</returns>
        /// <exception cref="InvalidOperationException">Error if toy type not found</exception>
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