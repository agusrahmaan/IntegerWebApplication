using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class CarController : Controller
    {
        
        public IActionResult Index()
        {
            /*var cars = new List<Car>();
            //IEnumerable

            cars.Add(new Car()
            {
                IDRegistration = 1,
                Type = "Sedan",
                Brand = "Tesla",
                Varian = "Grey"
            });

            cars.Add(new Car()
            {
                IDRegistration = 2,
                Type = "Sedan",
                Brand = "BMW",
                Varian = "Black"
            });

            cars.Add(new Car()
            {
                IDRegistration = 3,
                Type = "SUV",
                Brand = "Tesla",
                Varian = "Gold"
            });*/


            //Array
            /*var cars = new Car[]
            {
                new Car {IDRegistration = 1, Type = "Sedan", Varian = "GT88 Silver", Brand = "BMW"},
                new Car {IDRegistration = 2, Type = "SUV", Varian = "Accord", Brand = "BMW"},
                new Car {IDRegistration = 3, Type = "Sedan", Varian = "FT76 Gold", Brand = "Tesla"},
                new Car {IDRegistration = 4, Type = "Sedan", Varian = "RAV4", Brand = "Chevrolet"},
                new Car {IDRegistration = 5, Type = "Jeep", Varian = "AT88", Brand = "BMW"},
                new Car {IDRegistration = 6, Type = "SUV", Varian = "Accord", Brand = "BMW"},
                new Car {IDRegistration = 7, Type = "Sedan", Varian = "FT76 Gold", Brand = "Tesla"},
                new Car {IDRegistration = 8, Type = "Sedan", Varian = "RAV4", Brand = "Chevrolet"}
            };*/

            var cars = new Car[]{
                new Car{IDRegistration = 0001, Type= "Sedan", Brand = "Toyota", Varian = "FT86"},
                new Car{IDRegistration = 0002, Type = "SUV", Brand = "Toyota", Varian = "RAV4"},
                new Car{IDRegistration = 0003, Type = "Sedan", Brand = "Honda", Varian = "Accord"},
                new Car{IDRegistration = 0004, Type = "SUV", Brand = "Honda", Varian = "CRV"},
                new Car{IDRegistration = 0005, Type = "Sedan", Brand = "Honda", Varian = "City"},
            };


            //ViewBag.Cars = cars;

            //var search = cars.Single(x => x.IDRegistration == 2);
            //cars.Remove(search);

            //var car = cars.Where(x => x.Brand == "Tesla");
            //ViewBag.Cars = car;

            //var car = cars.Where(x => x.Type == "Sedan").FirstOrDefault();
            //ViewBag.Cars = new List<Car>() {car};

            //latihan 1
            //var no1 = cars.Where(x => x.Brand == "Honda").FirstOrDefault();
            //ViewBag.Cars = new List<Car>() { no1 };

            //Latihan 2
            //var no2 = cars.Where(x => x.Brand == "Honda" && x.Type == "Sedan");
            //ViewBag.Cars = no2;

            //Latihan 3
            //var no3 = cars.Where(x => x.Brand == "Honda" && x.Varian == "City").FirstOrDefault();
            //ViewBag.Cars = new List<Car>() { no3 };

            //latihan 4
            //var no4 = cars.Where(x => x.Brand == "Toyota");
            //ViewBag.Cars = no4;

            //Latihan 5
            //var no5 = cars.Where(x => x.Varian == "City");
            //ViewBag.Cars = no5;

            //Latihan 6
            var no6 = cars.Where(x => x.Type == "SUV" && x.Varian == "Accord");
            ViewBag.Cars = no6;
            return View();
        }
    }
}
