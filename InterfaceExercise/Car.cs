using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
           

        }

        public int Year { get; set; } 

        public string Model { get; set; } 

        public string Make { get; set; }

        public bool Driveable { get; set; } 

        public string CompanyName { get; set; } 

        public string Logo { get; set; }



        public int NumberOfPassengers { get; set; }


        public bool HasWindShieldWipers { get; set; }
    }
}
 

