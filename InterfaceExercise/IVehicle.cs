using System.Dynamic;

namespace InterfaceExercise;

public interface IVehicle
{
    //4 members that Car, Truck, and SUV all have in common
    public int NumberOfWheels { get; set; }
    public double GroundClearanceInches { get; set; }
    public int NumberOfSeats { get; set; }
    public int MilesPerGallonAvg { get; set; }
}