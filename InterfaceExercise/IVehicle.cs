namespace InterfaceExercise;

public interface IVehicle
{ 
    
    //Create 3 classes called Car , Truck , & SUV
    
    //In your IVehicle:
            
    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
    
    public int NumberOfWheels { get; set; }
    public int NumberofSeats { get; set; }
    public bool HasTrunk { get; set; }
    public int Size { get; set; }

    public void VehicleProperties();
    public void Company();



}