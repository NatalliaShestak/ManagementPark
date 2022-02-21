using ManagementPark.Parts;

namespace ManagementPark.Vehicles
{
    class Truck : Vehicle
    {
        public Truck(string vehicleModel, Frame frame, Engine engine, Transmission transmission)
        : base(vehicleModel, frame, engine, transmission)
        {
            VehicleType = "Truck";
        }
    }
}