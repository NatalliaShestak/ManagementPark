
namespace ManagementPark.Parts
{
    public class Frame{
    protected int WheelsCount{ get; set;}

    protected string FrameNumber { get; set;}

    protected double FrameSafeLoad { get; set;}

    public Frame (int wheelsCount, string frameNumber, double frameSafeLoad)
    {
        this.WheelsCount = wheelsCount;
        this.FrameNumber = frameNumber;
        this.FrameSafeLoad = frameSafeLoad;
    }
    public override string ToString()
    {
        return "[wheels = " + WheelsCount + ", serial number = " + FrameNumber + ", safe load = " + FrameSafeLoad + "kg";         
    }
    }
}