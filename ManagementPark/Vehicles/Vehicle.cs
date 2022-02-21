using System.Transactions;
using ManagementPark.Parts;

namespace ManagementPark.Vehicles
{
    abstract class Vehicle
    {
        protected string VehicleType { get; set;}

        protected string VehicleModel { get; set;}

        protected Frame Frame { get; set;}

        protected Engine Engine { get; set;}

        protected Transmission Transmission { get; set;}

        protected Vehicle(string vehicleModel, Frame frame, Engine engine, Transmission transmission)
        {
            this.VehicleModel = vehicleModel;
            this.Frame = frame;
            this.Engine = engine;
            this.Transmission = transmission;
        }

        public override string ToString()
        {
            return VehicleType + ": \n\tModel = \"" + VehicleModel + "\", \n\tEngine \t\t"
            + Engine + ", \n\tFrame \t\t" + Frame + ", \n\tTransmission \t" + Transmission;
        }
    }
}