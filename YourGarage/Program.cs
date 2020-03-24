using System;
using System.Collections.Generic;
using YourGarage.Aircrafts;
using YourGarage.Cars;
using YourGarage.Watercrafts;

namespace YourGarage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var myPlane = new Cessna172
            {
                Name = "my plane",
                FuelCapacity = 100,
                PaintJob = Color.Green,
                PassengerOccupancy = 5,
                RegistrationNumber = "D12332132B",
                Year = 1959
            };
            var yourPlane = new Cessna172()
            { 
                Name = "your plane",
                FuelCapacity = 102,
                PaintJob = Color.Purple,
                PassengerOccupancy = 5,
                RegistrationNumber = "D12332442B",
                Year = 1970
            };
            var spiritOfNashville = new Cessna172()
            {
                Name = "the Spirit of Nashville",
                FuelCapacity = 110,
                PaintJob = Color.Silver,
                PassengerOccupancy = 1,
                RegistrationNumber = "D97983741B",
                Year = 1971
            };

            var planes = new List<Cessna172> { myPlane, yourPlane, spiritOfNashville };

            foreach (var plane in planes)
            {
                plane.Drive();
            };

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var myCar = new TeslaModelS()
            {
                Name = "my car",
                FuelCapacity = 1234567,
                PaintJob = Color.Green,
                PassengerOccupancy = 4
            };

            var yourCar = new TeslaModelS()
            {
                Name = "your car",
                FuelCapacity = 1234563,
                PaintJob = Color.Red,
                PassengerOccupancy = 4
            };

            var elonsCar = new TeslaModelS()
            {
                Name = "Elon's car",
                FuelCapacity = 1234547,
                PaintJob = Color.White,
                PassengerOccupancy = 400
            };

            var cars = new List<TeslaModelS> { myCar, yourCar, elonsCar };

            foreach (var car in cars)
            {
                car.Drive();
                car.Vroom();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var hmsVictory = new ShipOfTheLine(104)
            {
                Name = "HMS Victory",
                FuelCapacity = 0,
                PaintJob = Color.Yellow,
                PassengerOccupancy = 821,
                Rating = Rate.FirstRate
            };
            var hmsEuryalus = new ShipOfTheLine(36)
            {
                Name = "HMS Euryalus",
                FuelCapacity = 0,
                PaintJob = Color.Black,
                PassengerOccupancy = 515,
                Rating = Rate.FifthRate
            };
            var hmsTemeraire = new ShipOfTheLine(98)
            {
                Name = "HMS Temeraire",
                FuelCapacity = 0,
                PaintJob = Color.Yellow,
                PassengerOccupancy = 738,
                Rating = Rate.SecondRate
            };

            var ships = new List<ShipOfTheLine> { hmsVictory, hmsEuryalus, hmsTemeraire };

            foreach (var ship in ships)
            {
                ship.Drive();
            }
            Console.ReadKey();
        }
    }
}
