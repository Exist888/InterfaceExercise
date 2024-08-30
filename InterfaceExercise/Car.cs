namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    //2 members that are specific to Car
    public bool ManualTrans { get; set; }
    public bool AllWheelDrive { get; set; }
    
    //Implemented members from IVehicle interface
    public int NumberOfWheels { get; set; }
    public double GroundClearanceInches { get; set; }
    public int NumberOfSeats { get; set; }
    public int MilesPerGallonAvg { get; set; }
    
    //Implemented members from ICompany interface
    public string Name { get; set; }
    public string Logo { get; set; }
    
    //Manual Transmission - Method below converts Bool answer to string for later WriteLine output
    public string DisplayTransmissionBool()
    {
        if (ManualTrans == true)
        {
            return "manual";
        }
        else
        {
            return "automatic";
        }
    }
    
    //All Wheel Drive - Method below converts Bool answer to string for later WriteLine output
    public string Display4WDBoolOrNo()
    {
        if (AllWheelDrive == true)
        {
            return "All Wheel Drive";
        }
        else
        {
            return "Front Wheel Drive";
        }
    }
}