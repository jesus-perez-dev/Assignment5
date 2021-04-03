using System;
using System.ComponentModel;
using NUnit.Framework;
using Problem2;

namespace TestProblem2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldBuildEmptyComputer()
        {
            IComputerBuilder builder = new ComputerBuilder();
            var computer = builder.Build();

            Assert.Null(computer.HardDrive);
            Assert.Null(computer.Motherboard);
            Assert.Null(computer.Cpu);
            Assert.Null(computer.Memory);
            Assert.Null(computer.GraphicsCard);
            Assert.Null(computer.Case);
        }
        
        [Test]
        public void ShouldBuildFullComputerWithBuilder()
        {
            IComputerBuilder builder = new ComputerBuilder();
            builder.SetHardDrive(12.3, "SSD", 15, 22);
            builder.SetMotherBoard(4, 500, 3, "ATX", 4);
            builder.SetCpu(1200, "AMD", "AM4", 500, 6);
            builder.SetMemory(2000, 2000, "DDR4", 16);
            builder.SetGraphicsCard(2, 2000, 1400, 4);
            builder.SetCase(100, 30, 100, 4, 4);
            var computer = builder.Build();

            Assert.NotNull(computer.HardDrive);
            Assert.NotNull(computer.Motherboard);
            Assert.NotNull(computer.Cpu);
            Assert.NotNull(computer.Memory);
            Assert.NotNull(computer.GraphicsCard);
            Assert.NotNull(computer.Case);
        }

        [Test]
        public void ShouldBuildFullComputerUsingDirector()
        {
            ComputerDirector computerDirector = new ComputerDirector();
            IComputerBuilder builder = new ComputerBuilder();
            builder.SetHardDrive(12.3, "SSD", 15, 22);
            builder.SetMotherBoard(4, 500, 3, "ATX", 4);
            builder.SetCpu(1200, "AMD", "AM4", 500, 6);
            builder.SetMemory(2000, 2000, "DDR4", 16);
            builder.SetGraphicsCard(2, 2000, 1400, 4);
            builder.SetCase(100, 30, 100, 4, 4);
            var computer = computerDirector.Construct(builder);
            
            Assert.NotNull(computer.HardDrive);
            Assert.NotNull(computer.Motherboard);
            Assert.NotNull(computer.Cpu);
            Assert.NotNull(computer.Memory);
            Assert.NotNull(computer.GraphicsCard);
            Assert.NotNull(computer.Case);
        }

        [Test]
        public void ShouldBuildFullComputerWithBuilderChainedMethods()
        {
            var computer = new ComputerBuilder().SetHardDrive(12.3, "SSD", 15, 22)
                .SetMotherBoard(4, 500, 3, "ATX", 4)
                .SetCpu(1200, "AMD", "AM4", 500, 6)
                .SetMemory(2000, 2000, "DDR4", 16)
                .SetGraphicsCard(2, 2000, 1400, 4)
                .SetCase(100, 30, 100, 4, 4)
                .Build();

            Assert.NotNull(computer.HardDrive);
            Assert.NotNull(computer.Motherboard);
            Assert.NotNull(computer.Cpu);
            Assert.NotNull(computer.Memory);
            Assert.NotNull(computer.GraphicsCard);
            Assert.NotNull(computer.Case);
        }
        
        [Test]
        public void ShouldThrowErrorOnInvalidNumberArgument()
        {
            IComputerBuilder builder = new ComputerBuilder();

            var exception = Assert.Throws<ArgumentException>(() => builder.SetHardDrive(-10, "SSD", 15, 22));
            Assert.AreEqual("Capacity must be greater than 0",exception.Message);
        }
        
        [Test]
        public void ShouldThrowErrorOnInvalidStringArgument()
        {
            IComputerBuilder builder = new ComputerBuilder();

            var exception = Assert.Throws<ArgumentException>(() => builder.SetHardDrive(12.3, "invalid", 15, 22));
            Assert.AreEqual("Type must be either SSD or HDD",exception.Message);
        }
    }
}