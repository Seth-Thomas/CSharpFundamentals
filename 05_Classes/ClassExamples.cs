using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }
        public Cookie()
        {

        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour )
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }

    public enum vehicleType { Car, Truck, Van, Motorcyle, Plane, Boat}
    public class vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set; }
        public vehicleType TypeOfVehicle { get; set; }
        public vehicle()
        {

        }
        

    }
    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderProduct { get; set; }
        public decimal TotalCent { get; set; }
    }
}