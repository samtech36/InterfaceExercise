using System;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    //ivehicle
    public int NumberOfWheels { get; set; }
    public int NumberofSeats { get; set; }
    public bool HasTrunk { get; set; }
    public int Size { get; set; }
    
    
    
    //icompany
    public string Logo { get; set; }
    public string CompanyName { get; set; }
    
    
    //truck
    public bool TruckEngine { get; set; }
    public string TruckType { get; set; }
    
    
    
    
    
    public void VehicleProperties()
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"The truck has {NumberOfWheels} wheels, {NumberofSeats} seats, and {Size} beds. It is {HasTrunk} that the truck has a trunk.");
        Console.WriteLine($"It is {TruckEngine} that the truck has an engine. The truck type is {TruckType}.");
    }

    public void Company()
    {
        Console.WriteLine($"The truck is manufactured by {CompanyName} and has a decent {Logo} logo.");
    }
    
    
}