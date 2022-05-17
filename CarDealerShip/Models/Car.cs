using System.Collections.Generic;
namespace CarDealership.Models
{
    public class Car
    {
        private static List<Car> _cars = new List<Car>{};
        public string Name{get; set;}
        public string Model{get; set;}
        public int Price{get; set;}
        public string Colour{get; set;}
        public int Miles{get; set;}

        public Car(string name , string model , int price , string colour , int miles)
        {
            Name = name;
            Model = model;
            Price = price;
            Colour = colour;
            Miles = miles;
        }

        public static List<Car> GetAllCars()
        {
            return _cars;
        }

    }
}