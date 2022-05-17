using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> cars = Car.GetAllCars();
            return View(cars);
        }

        [HttpGet("/cars/form")]
        public ActionResult CarsForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Cars(string name , string model , string price , string color , string miles)
        {
            Car carModel = new Car(name , model , int.Parse(price) , color , int.Parse(miles));
            return RedirectToAction("Index");
        }
    }
}