namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    //2 members that are specific to Truck
    public int TowingCapacityInPounds { get; set; }
    public int EngineCylinders { get; set; }
    
    //Implemented members from IVehicle interface
    public int NumberOfWheels { get; set; }
    public double GroundClearanceInches { get; set; }
    public int NumberOfSeats { get; set; }
    public int MilesPerGallonAvg { get; set; }
    
    //Implemented members from ICompany interface
    public string Name { get; set; }
    public string Logo { get; set; }
}