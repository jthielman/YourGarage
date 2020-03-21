using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Vehicle
    {
        public string Name { get; set; }
        public int FuelCapacity { get; set; }
        public Color PaintJob { get; set; }
        public int PassengerOccupancy { get; set; }

        public virtual void Refuel()
        {
            Console.WriteLine($"{Name} has been refueled to its capacity of {FuelCapacity}.");
        }

        public virtual void Drive()
        {
            Console.WriteLine($"You drive {Name}.  It's fun for you.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"You slow your {Name} down because you just want to, that's why.");
        }
    }
}
