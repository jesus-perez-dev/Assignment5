/*
 * Jesus Perez Santiago
 * 000772575
 * I, Jesus Perez Santiago, student number 000772575, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */

using System.Collections.Generic;

namespace Problem1
{
    /// <summary>
    /// A rainbow stacker toy
    /// </summary>
    public class RainbowStacker : Toy
    {
        /// <summary>
        /// Full constructor of a rainbow stacker 
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

        /// <summary>
        /// The ring order it should be
        /// </summary>
        private Stack<string> _correctRingOrder;
        /// <summary>
        /// How many rings are on
        /// </summary>
        public int RingCount { get; set; }
        /// <summary>
        /// Whether it is in order and complete
        /// </summary>
        public bool InOrderAndComplete { get; set; }
        /// <summary>
        /// The ring order it is currently in
        /// </summary>
        private Stack<string> RingOrder { get; set; }

        /// <summary>
        /// Sets the correct ring order
        /// </summary>
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

        /// <summary>
        /// Removes a ring
        /// </summary>
        /// <returns>The ring that was removed</returns>
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
        
        /// <summary>
        /// Adds a ring
        /// </summary>
        /// <param name="colourOfRing">The colour of the ring added</param>
        public void AddRing(string colourOfRing)
        {
            RingOrder.Push(colourOfRing);
            RingCount = RingOrder.Count;
            if (RingCount == 6)
            {
                InOrderAndComplete = CheckIfInOrder();
            }
        }

        /// <summary>
        /// Checks if the rainbow stacker is in order
        /// </summary>
        /// <returns>Whether it is in order or not</returns>
        private bool CheckIfInOrder()
        {
            return RingOrder.Equals(_correctRingOrder);
        }
    }
}