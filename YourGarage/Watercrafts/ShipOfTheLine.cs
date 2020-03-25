using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Watercrafts
{
    class ShipOfTheLine : Watercraft
    {
        public int Guns { get; }
        public Rate Rating { get; set; }

        public ShipOfTheLine(int numberOfGuns)
        {
            Guns = numberOfGuns;
        }

        public override void Drive()
        {
            Console.WriteLine($"Weigh anchor! Hoist the topsail! Bowse the topgallant! The {Name} is underway!");
        }
    }
}
