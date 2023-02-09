using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{

          
        }

        
        public int Year { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public bool Driveable { get; set; }

        public string CompanyName { get; set; }

        public string Logo { get; set; }


        public int NumberOfWheels { get; set; }
        
		public bool StorageBed { get; set; }
        

    }
}

