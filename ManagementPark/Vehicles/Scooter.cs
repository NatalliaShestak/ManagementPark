using ManagementPark.Parts;

namespace ManagementPark.Vehicles
{
    class Scooter : Vehicle
    {
        public Scooter(string vehicleModel, Frame frame, Engine engine, Transmission transmission)
        : base(vehicleModel, frame, engine, transmission)
        {
            VehicleType = "Scooter";
        }
    }
}