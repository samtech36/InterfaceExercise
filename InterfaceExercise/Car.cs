using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    //ivehicle
    public int NumberOfWheels { get; set; }
    public int NumberofSeats { get; set; }
    public bool HasTrunk { get; set; }
    public int Size { get; set; }
    
    //icompany
    public string Logo { get; set; }
    public string CompanyName { get; set; }
    
    
    //car
    public bool HasEngine {get; set;}
    public string EngineNoise { get; set; }


    public void VehicleProperties()
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"The Car has {NumberOfWheels} wheels, {NumberofSeats} seats, and {Size} beds. It is {HasTrunk} that the car has a trunk.");
        Console.WriteLine($"It is {HasEngine} that the car has an engine. The engine noise is {EngineNoise}.");
        
    }

    public void Company()
    {
        Console.WriteLine($"The car is manufactured by {CompanyName} and has a decent {Logo} logo.");
    }
}