using ManagementPark.Parts;

namespace ManagementPark.Vehicles
{
    class Bus : Vehicle
    {
        public Bus(string vehicleModel, Frame frame, Engine engine, Transmission transmission)
        : base(vehicleModel, frame, engine, transmission)
        {
            VehicleType = "Bus";
        }
    }
}