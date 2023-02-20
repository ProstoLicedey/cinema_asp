using System.Collections.Generic;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
//using PEPESIX.Models;
using pitpm_pr1.Controllers;
using pitpm_pr1.Models;

namespace pitpm_pr1.Controllers
{
    public class Car
    {

        public string Name;
        public string Mileage;
        public string Year;
        public Car(string Name, string Mileage, string Year)
        {
            this.Name = Name;
            this.Mileage = Mileage;
            this.Year = Year;
        }
    }
    public class Cars
    {
        public static List<Car> All_cars = new List<Car>();
        public Cars()
        {

        }
        public static void AddCar(string Name, string Mileage, string Year)
        {
            All_cars.Add(new Car(Name, Mileage, Year));

        }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public int _counter = 0;
        public IActionResult Nissan_Silvia()
        {
            return View();
        }
        public IActionResult Mazda_RX_7()
        {
            return View();
        }

        public IActionResult Toyota_Mark_II()
        {
            return View();
        }

        public IActionResult Find()
        {
            return View();
        }
        [HttpPost]


        public IActionResult Mazda_RX_7(string Predlozhenie)
        {

            return View();
        }
        [HttpPost]
        public IActionResult Find(string Nazvanie, string Mileage, string Year, string fn, string fa, string fy)
        {
            Cars.AddCar(Nazvanie, Mileage, Year);
            for (int i = 0; i < Cars.All_cars.Count; i++)
            {
                if (fn == Cars.All_cars[i].Name)
                {
                    ViewBag.N = Cars.All_cars[i].Name + ", ";
                    ViewBag.A = Cars.All_cars[i].Mileage + ", ";
                    ViewBag.Y = Cars.All_cars[i].Year + " ";
                }
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}