using System;
using InterfaceExercise;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. - DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company - DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class - DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values; - DONE
            //Creatively display and organize their values - DONE


            Console.WriteLine("List of available cars based on your search:");
            Console.WriteLine();

            var honda = new Car()
            {
                Logo = "true",
                Name = "Auto Nation Honda",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                UsesFuel = true,
                Price = 30000,
                Year = 2020,
                Make = "Honda",
                Model = "Civic"
            };

            Console.WriteLine($"Location: {honda.Name}\n Year: {honda.Year}\n Make: {honda.Make}\n Model: {honda.Model}");
            Console.WriteLine($"More details:\n Number of doors: {honda.NumberOfDoors}\n Number of wheels: {honda.NumberOfWheels}\n " +
                $"Fuel: {honda.UsesFuel}\n Price: {honda.Price}");

            Console.WriteLine();

            var dodge = new Truck() 
            { 
                Logo = "true",
                Name = "Crysler Dodge Jeep Ram",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                UsesFuel = true,
                Price = 37000,
                Year = 2022,
                Make = "Dodge",
                Model = "Ram",
                HasBed = true,
                NumberOfRows = 2,

            };

            Console.WriteLine($"Location: {dodge.Name}\n Year: {dodge.Year}\n Make: {dodge.Make}\n Model: {dodge.Model}");
            Console.WriteLine($"More details:\n Number of doors: {dodge.NumberOfDoors}\n Number of wheels: {dodge.NumberOfWheels}\n " +
                $"Fuel: {dodge.UsesFuel}\n Price: {dodge.Price}\n Truck bed: {dodge.HasBed}\n Number of rows: {dodge.NumberOfRows}");

            Console.WriteLine();

            var gmc = new Suv()
            {
                Logo = "true",
                Name = "Sunrise Buick GMC",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                UsesFuel = true,
                Price = 71000,
                Year = 2022,
                Make = "GMC",
                Model = "Yukon Denali",
                HasThirdRow = true,
                CargoSize = "large",

            };

            Console.WriteLine($"Location: {gmc.Name}\n Year: {gmc.Year}\n Make: {gmc.Make}\n Model: {gmc.Model}");
            Console.WriteLine($"More details:\n Number of doors: {gmc.NumberOfDoors}\n Number of wheels: {gmc.NumberOfWheels}\n " +
                $"Fuel: {gmc.UsesFuel}\n Price: {gmc.Price}\n Third row: {gmc.HasThirdRow}\n Cargo size: {gmc.CargoSize}");

        }
    }
}
