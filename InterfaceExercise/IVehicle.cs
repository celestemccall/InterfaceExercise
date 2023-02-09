using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Year { get; set; }

		public  string Model { get; set;}

		public string Make  { get; set; }

		public bool Driveable { get; set; }
    }
}

