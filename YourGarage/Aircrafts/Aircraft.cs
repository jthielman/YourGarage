using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Aircraft : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"You fly {Name}.  It's fun for you.");
        }

        public void Land()
        {
            Console.WriteLine("You land the plane roughly where you wanted to.");
        }

        public override void Stop()
        {
            Console.WriteLine($"You inexpertly dive landward and terrify all {PassengerOccupancy} passengers.");
        }
    }
}
