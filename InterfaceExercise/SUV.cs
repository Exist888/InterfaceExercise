namespace InterfaceExercise;

public class SUV: IVehicle, ICompany
{
    //2 members that are specific to SUV
    public bool AutomaticRearGateAvailable { get; set; }
    public bool PowerSeatsAvailable { get; set; }
    
    //Implemented members from IVehicle interface
    public int NumberOfWheels { get; set; }
    public double GroundClearanceInches { get; set; }
    public int NumberOfSeats { get; set; }
    public int MilesPerGallonAvg { get; set; }
    
    //Implemented members from ICompany interface
    public string Name { get; set; }
    public string Logo { get; set; }
    
    //Automatic Rear Gate - Method below converts Bool answer to string for later WriteLine output
    public string DisplayRearGateBool()
    {
        if (AutomaticRearGateAvailable == true)
        {
            return "Automatic Rear Gate available at Onyx and higher trim levels";
        }
        else
        {
            return "Automatic Rear Gate not available";
        }
    }
    
    //Power Seats - Method below converts Bool answer to string for later WriteLine output
    public string DisplayPowerSeatsBool()
    {
        if (PowerSeatsAvailable == true)
        {
            return "Power Seats available at Premium and higher trim levels";
        }
        else
        {
            return "Power Seats not available";
        }
    }
}