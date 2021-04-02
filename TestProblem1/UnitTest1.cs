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
            var car = ToyFactory.CreateToy(ToyType.Car, 10.15, "A toy car", "Vroom vroom car", 
                "ACME", 2021, 5, 20, true, 2.3);
            Assert.NotNull(car as Car);
        }
        
        [Test]
        public void ShouldCreateSpecificToyAndGetSpecificProperty()
        {
            var car = ToyFactory.CreateToy(ToyType.Car, 10.15, "A toy car", "Vroom vroom car", 
                "ACME", 2021, 5, 20, true, 2.3) as Car;
            var speed = car.Speed;
            Assert.NotNull(speed);
        }
        
        [Test]
        public void ShouldCreateSpecificToyAndCheckSpecificMethodWorks()
        {
            var car = ToyFactory.CreateToy(ToyType.Car, 10.15, "A toy car", "Vroom vroom car", 
                "ACME", 2021, 5, 20, true, 2.3) as Car;
            var initialSpeed = car.Speed;
            Assert.NotNull(initialSpeed);
            
            car.IncreaseSpeed();
            var newSpeed = car.Speed;
            Assert.Greater(newSpeed, initialSpeed);
        }
        
        [Test]
        public void ShouldCreateRainbowStackerThenRemoveRing()
        {
            var rs = ToyFactory.CreateToy(ToyType.RainbowStacker, 30.33, "Rainbow rings stacked", "Rainbow Stacker", 
                "ACME", 2021, 1, 5, true, 5) as RainbowStacker;
            Assert.NotNull(rs);
            var initialRings = rs.RingCount;
            Assert.AreEqual(true,rs.InOrderAndComplete);
            
            rs.RemoveRing();
            var newRings = rs.RingCount;
            Assert.Greater(initialRings, newRings);
            Assert.AreEqual(false, rs.InOrderAndComplete);
        }
    }
}