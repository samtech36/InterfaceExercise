using System;
using System.Text;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //My car
            var myCar = new Car();
            myCar.NumberOfWheels = 4;
            myCar. NumberofSeats = 4;
            myCar.Size = 1;
            myCar.HasTrunk = true;
            myCar.HasEngine = true;
            myCar.EngineNoise = "Medium";
            myCar.CompanyName = "Nissan";
            myCar.Logo = "cicle shaped";
            
            myCar.VehicleProperties();
            myCar.Company();
            
            
            //My truck
            Truck myTruck = new Truck()
            {
                NumberOfWheels = 10,
                NumberofSeats = 2,
                Size = 1,
                HasTrunk = false,
                TruckEngine = true,
                TruckType = "18 wheeler",
                CompanyName = "JB Hunt",
                Logo = "Bold"

            };
            myTruck.VehicleProperties();
            myTruck.Company();
            
            
            //My SUV
            SUV mySUV = new SUV()
            {
                NumberOfWheels = 4,
                NumberofSeats = 6,
                Size = 2,
                HasTrunk = true,
                HasFourWheelDrive = true,
                HasSunRoof = true,
                CompanyName = "Audi",
                Logo = "olympic"

            };
            
            mySUV.VehicleProperties();
            mySUV.Company();




        }
    }
}
