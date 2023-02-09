using System;
using System.Collections.Generic;
using System.Reflection;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE - Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*DONE - Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /* DONE - Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Done - Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

           

            var myCar = new Car();

            myCar.Year = 2009;
            myCar.Make = "Infiniti";
            myCar.Model = "G37";
            myCar.Driveable = true;
            myCar.CompanyName = "Nissan";
            myCar.Logo = "I";
            myCar.NumberOfPassengers = 4;
            myCar.HasWindShieldWipers = true;

            Console.WriteLine($"Year:{myCar.Year} Make: {myCar.Make} Model: {myCar.Model} Driveable: {myCar.Driveable} Company Name: {myCar.CompanyName} Logo: {myCar.Logo}");
            Console.WriteLine($"My {myCar.Year} {myCar.Make} has {myCar.NumberOfPassengers} passenger seats and it is {myCar.HasWindShieldWipers} that this car has working wind shield wipers.");
            Console.WriteLine($"");
           



            var hisTruck = new Truck();


            hisTruck.Year = 2019;
            hisTruck.Make = "Dodge";
            hisTruck.Model = "Ram";
            hisTruck.Driveable = true;
            hisTruck.CompanyName = "Dodge";
            hisTruck.Logo = "Ram Animal";
            hisTruck.NumberOfWheels = 4;
            hisTruck.StorageBed = true;

            Console.WriteLine($"Year:{hisTruck.Year} Make: {hisTruck.Make} Model: {hisTruck.Model} Driveable: {hisTruck.Driveable} Company Name: {hisTruck.CompanyName} Logo: {hisTruck.Logo}");
            Console.WriteLine($"It is {hisTruck.StorageBed} that his {hisTruck.Year} {hisTruck.CompanyName} truck has a large storage bed for transporting and has {hisTruck.NumberOfWheels} wheels.");
            Console.WriteLine($"");


            var herSUV = new SUV();

            herSUV.Year = 2020;
            herSUV.Make = "Tesla";
            herSUV.Model = "Model X";
            herSUV.Driveable = true;
            herSUV.CompanyName = "Tesla";
            herSUV.Logo = "T";
            herSUV.HasCruiseControl = true;
            herSUV.FourWheelDrive = true;

            Console.WriteLine($"Year:{herSUV.Year} Make: {herSUV.Make} Model: {herSUV.Model} Driveable: {herSUV.Driveable} Company Name: {herSUV.CompanyName} Logo: {herSUV.Logo}");
            Console.WriteLine($"It is {herSUV.HasCruiseControl} that her {herSUV.Model} {herSUV.CompanyName} has cruise control and {herSUV.FourWheelDrive} that her car has four wheel drive.");
            Console.WriteLine($"");


        }
    }
}
