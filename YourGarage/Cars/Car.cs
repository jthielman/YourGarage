using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Car : Vehicle
    {
        public void Park()
        {
            Console.WriteLine("PARK IT!");
        }

        public override void Stop()
        {
            Console.WriteLine($"You slam the brakes and terrify all {PassengerOccupancy} passengers.");
        }
    }
}
