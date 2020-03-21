using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Cars
{
    class TeslaModelS : Car
    {
        public override void Refuel()
        {
            Console.WriteLine("Plug in that Tesla car and charge 'er up.");
        }

        public void Vroom()
        {
            Console.WriteLine($"{Name} is too quiet, so you make the vroom sounds yourself.");                        
        }
    }
}
