using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Watercrafts
{
    class ShipOfTheLine : Watercraft
    {
        public int Guns { get; set; }
        public Rate Rating { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"Weigh anchor! Hoist the topsail! Bowse the topgallant! The {Name} is underway!");
        }
    }
}
