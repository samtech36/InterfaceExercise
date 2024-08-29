using System;
using System.Runtime.CompilerServices;

namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
    //ICompany
    public string Logo { get; set; }
    public string CompanyName { get; set; }
    
    //IVehicle
    public int NumberOfWheels { get; set; }
    public int NumberofSeats { get; set; }
    public bool HasTrunk { get; set; }
    public int Size { get; set; }
    
    
    //SUV
    public bool HasFourWheelDrive { get; set; }
    public bool HasSunRoof { get; set; }
    
    
    
    
    public void VehicleProperties()
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"The SUV has {NumberOfWheels} wheels, {NumberofSeats} seats, and {Size} beds. It is {HasTrunk} that the SUV has a trunk.");
        Console.WriteLine($"It is {HasFourWheelDrive} that the SUV has an four wheel drive. It is {HasSunRoof} that the SUV has a sun roof.");
    }

    public void Company()
    {
        Console.WriteLine($"The SUV is manufactured by {CompanyName} and has a decent {Logo} logo.");
    }
}