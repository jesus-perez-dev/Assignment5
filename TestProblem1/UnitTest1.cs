using NUnit.Framework;
using Problem1;

namespace TestProblem1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateSpecificToy()
        {
            var car = ToyFactory.CreateToy<Car>(10.15, "A toy car", "Vroom vroom car",
                "ACME", 2021, 5, 20, true, 2.3);
            // var car = ToyFactory.CreateToy(ToyType.Car, 10.15, "A toy car", "Vroom vroom car", 
            //     "ACME", 2021, 5, 20, true, 2.3);
            Assert.NotNull(car);
        }
        
        [Test]
        public void ShouldCreateSpecificToyAndGetSpecificProperty()
        {
            var car = ToyFactory.CreateToy<Car>(10.15, "A toy car", "Vroom vroom car", 
                "ACME", 2021, 5, 20, true, 2.3);
            var speed = car.Speed;
            Assert.NotNull(speed);
        }
        
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