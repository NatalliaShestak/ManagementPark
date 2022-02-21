
using ManagementPark.Types;

namespace ManagementPark.Parts
{
    class Engine
    {
        protected EngineType EngineType {get; set;}

        protected string EngineSerialNumber {get; set;}

        protected double EnginePower {get; set;}

        protected double EngineVolume {get; set;}

        public Engine(EngineType engineType, string engineSerialNumber, double enginePower, double engineVolume)
        {
            this.EngineType = engineType;
            this.EngineSerialNumber = engineSerialNumber;
            this.EnginePower = enginePower;
            this.EngineVolume = engineVolume;
        }

        public override string ToString()
        {
            return "[type = " + EngineType + ", serial number = " + EngineSerialNumber + 
            ", power = " + EnginePower + "hp., volume = " + EngineVolume + "cm3.]";
        }
        
    }
}