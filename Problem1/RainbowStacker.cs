using System.Collections.Generic;

namespace Problem1
{
    public class RainbowStacker : Toy
    {
        public RainbowStacker(double cost, string description, string name, string manufacturingCompany,
            int yearOfManufacture, int minimumAgeLimit, int maximumAgeLimit, bool chockingHazard, double weight) : base(
            cost, description, name, manufacturingCompany, yearOfManufacture, minimumAgeLimit, maximumAgeLimit,
            chockingHazard, weight)
        {
            RingCount = 6;
            InOrderAndComplete = true;
            InitializeRingOrder();
            RingOrder = _correctRingOrder;
        }

        private Stack<string> _correctRingOrder;
        public int RingCount { get; set; }
        public bool InOrderAndComplete { get; set; }
        public Stack<string> RingOrder { get; set; }

        private void InitializeRingOrder()
        {
            _correctRingOrder = new Stack<string>();
            _correctRingOrder.Push("Purple");
            _correctRingOrder.Push("Blue");
            _correctRingOrder.Push("Green");
            _correctRingOrder.Push("Yellow");
            _correctRingOrder.Push("Orange");
            _correctRingOrder.Push("Red");
        }

        public string RemoveRing()
        {
            if (RingCount > 0)
            {
                var removedRing = RingOrder.Pop();
                InOrderAndComplete = false;
                RingCount = RingOrder.Count;
                return removedRing;
            }
            return null;
        }
        
        public void AddRing(string colourOfRing)
        {
            RingOrder.Push(colourOfRing);
            RingCount = RingOrder.Count;
            if (RingCount == 6)
            {
                InOrderAndComplete = CheckIfInOrder();
            }
        }

        private bool CheckIfInOrder()
        {
            return RingOrder.Equals(_correctRingOrder);
        }
    }
}