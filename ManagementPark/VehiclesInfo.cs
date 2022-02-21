using System.Data;
using ManagementPark.Vehicles;
using ManagementPark.Parts;
using ManagementPark.Types;
using System;
using System.Collections.Generic;

namespace ManagementPark
{
    class VehiclesInfo
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehiclesList = new List<Vehicle>();
            vehiclesList.Add(new Bus("Skoda", new Frame(4, "SD 123145", 2000.00),
            new Engine(EngineType.FourCylinder, "MSSB 111111", 450.00, 9000),
            new Transmission(TransmissionType.Manual, "Skoda", 4)));

            vehiclesList.Add(new Truck("Skania", new Frame(5, "ISD 987654", 5000.00),
            new Engine(EngineType.ThreeCylinder, "SSS 222222", 550.00, 12000),
            new Transmission(TransmissionType.Automatic, "Skania", 5)));

            vehiclesList.Add(new Car("Kia", new Frame(3, "S120", 500),
            new Engine(EngineType.TwoCylinder, "MBB 333333", 150.00, 2000),
            new Transmission(TransmissionType.SemiAutomatic, "KiaRio", 3)));

            vehiclesList.Add(new Scooter("Honda", new Frame(2, "H 523", 50.00),
            new Engine(EngineType.TwoCylinder, "H 155", 70, 1000),
            new Transmission(TransmissionType.Manual, "Honda", 2)));

            foreach (Vehicle vehicle in vehiclesList)
            {
                Console.WriteLine(vehicle.ToString());
            }

            Console.ReadKey();
        }
    }
}