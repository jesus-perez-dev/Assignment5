/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

using NUnit.Framework;
using Problem1;

namespace TestProblem1
{
    /// <summary>
    /// Tests for problem 1
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Setup for tests
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Tests if a car is built
        /// </summary>
        [Test]
        public void ShouldCreateSpecificToy()
        {
            var car = ToyFactory.CreateToy<Car>(10.15, "A toy car", "Vroom vroom car",
                "ACME", 2021, 5, 20, true, 2.3);
            // var car = ToyFactory.CreateToy(ToyType.Car, 10.15, "A toy car", "Vroom vroom car", 
            //     "ACME", 2021, 5, 20, true, 2.3);
            Assert.NotNull(car);
        }
        
        /// <summary>
        /// Tests if a car is built and it has a specific property only its type has
        /// </summary>
        [Test]
        public void ShouldCreateSpecificToyAndGetSpecificProperty()
        {
            var car = ToyFactory.CreateToy<Car>(10.15, "A toy car", "Vroom vroom car", 
                "ACME", 2021, 5, 20, true, 2.3);
            var speed = car.Speed;
            Assert.NotNull(speed);
        }
        
        /// <summary>
        /// Tests if a car is built and it has a specific method used only its type has
        /// </summary>
        [Test]
        public void ShouldCreateSpecificToyAndCheckSpecificMethodWorks()
        {
            var car = ToyFactory.CreateToy<Car>(10.15, "A toy car", "Vroom vroom car", 
                "ACME", 2021, 5, 20, true, 2.3);
            var initialSpeed = car.Speed;
            Assert.NotNull(initialSpeed);
            
            car.IncreaseSpeed();
            var newSpeed = car.Speed;
            Assert.Greater(newSpeed, initialSpeed);
        }
        
        /// <summary>
        /// Tests if a rainbow stacker is built and some of its methods
        /// </summary>
        [Test]
        public void ShouldCreateRainbowStackerThenRemoveRing()
        {
            var rainbowStacker = ToyFactory.CreateToy<RainbowStacker>(30.33, "Rainbow rings stacked", "Rainbow Stacker", 
                "ACME", 2021, 1, 5, true, 5);
            Assert.NotNull(rainbowStacker);
            var initialRings = rainbowStacker.RingCount;
            Assert.AreEqual(true,rainbowStacker.InOrderAndComplete);
            
            rainbowStacker.RemoveRing();
            var newRings = rainbowStacker.RingCount;
            Assert.Greater(initialRings, newRings);
            Assert.AreEqual(false, rainbowStacker.InOrderAndComplete);
        }
    }
}