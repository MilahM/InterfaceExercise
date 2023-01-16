using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool UsesFuel { get; set; }
        public int Price { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public bool HasBed { get; set; }
        public int NumberOfRows { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
