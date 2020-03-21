using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Watercraft : Vehicle
    {
        public void Dock()
        {
            Console.WriteLine("Back to the harbor with you!");
        }

        public override void Drive()
        {
            Console.WriteLine($"You drive {Name} around the lake.  It's fun for you.");
        }
    }
}
