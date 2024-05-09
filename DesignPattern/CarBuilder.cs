using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    public class Director
    {
        public void MakeArtCar(IBuilder carBuiler)
        {
            carBuiler.SetName("BMW");
            carBuiler.SetColor("Black");
            carBuiler.SetYear(2023);
        }
        public void MakeModernCar(IBuilder carBuiler)
        {
            carBuiler.SetName("Sport");
            carBuiler.SetColor("Red");
            carBuiler.SetYear(2024);
        }
    }

    public class Bike
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    public class BikeBuilder : IBuilder
    {
        private Bike _car = new Bike();
        public void SetName(string name)
        {
            _car.Name = name;
        }
        public void SetColor(string color)
        {
            _car.Color = color;
        }
        public void SetModel(string model)
        {
            _car.Model = model;
        }
        public void SetYear(int year)
        {
            _car.Year = year;
        }
        public Bike Build()
        {
            return _car;
        }
    public interface IBuilder
    {
        public void SetName(string name);

        public void SetModel(string model);

        public void SetYear(int year);

        public void SetColor(string color);

        public Car Build();

    }
    public class CarBuiler : IBuilder 
    {
        private Car _car = new Car();
        public void SetName(string name)
        {
            _car.Name = name;
        }
        public void SetModel(string model)
        {
            _car.Model = model;
        }
        public void SetYear(int year)
        {
            _car.Year = year;
        }
        public void SetColor(string color)
        {
            _car.Color = color;
        }
        public Car Build()
        {
            return _car;
        }
    }
}
