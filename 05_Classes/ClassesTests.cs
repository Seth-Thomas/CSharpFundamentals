using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {                        //Constructor
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anothercookie = new Cookie();
            anothercookie.Name = "Chocolate Chip";
            anothercookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11);
            Cookie newCookie = new Cookie("Peanut Butter", true, 15);
        }
        [TestMethod]
        public void VehicleTests()
        {
            vehicle car = new vehicle();
            car.TypeOfVehicle = vehicleType.Car;

            vehicle myCar = new vehicle
            {
                TypeOfVehicle = vehicleType.Car,
                Make = "Ford",
                Model = "Mustang"
            };
        }
    }
}
