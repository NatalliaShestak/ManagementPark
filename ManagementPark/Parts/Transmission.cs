using ManagementPark.Types;

namespace ManagementPark.Parts
{
    class Transmission
    {
        protected TransmissionType TransmissionType { get; set; }

        protected string TransmissionManufacturer { get; set;}

        protected int GearsCount { get; set;}

        public Transmission(TransmissionType transmissionType, string manufacturer, int gearsCount)
        {
            this.TransmissionType = transmissionType;
            this.TransmissionManufacturer = TransmissionManufacturer;
            this.GearsCount = gearsCount;
        }

        public override string ToString()
        {
            return "[type = " + TransmissionType + ", manufacturer: " + 
            TransmissionManufacturer + ", gears = " + GearsCount + "j";
        }
    }
}