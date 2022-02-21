using ManagementPark.Parts;

namespace ManagementPark.Vehicles
{
    class Car : Vehicle
    {
        public Car(string vehicleModel, Frame frame, Engine engine, Transmission transmission)
        : base(vehicleModel, frame, engine, transmission)
        {
            VehicleType = "Car";
        }
    }
}