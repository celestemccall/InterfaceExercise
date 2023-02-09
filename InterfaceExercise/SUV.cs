using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{

           
        }

       

        public int Year { get; set; } 

        public string Model { get; set; } 

        public string Make { get; set; } 

        public bool Driveable { get; set; }

        public string CompanyName { get; set; } 

        public string Logo { get; set; } 


        public bool HasCruiseControl { get; set; }
        
		public bool FourWheelDrive { get; set; }
        
    }
}

