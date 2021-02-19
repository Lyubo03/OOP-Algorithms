using System;
using System.Collections.Generic;
using System.Linq;

namespace ITCareer_OOP_Exam_1
{
    public class Store
    {
        private string name;
        private List<Car> cars;

        public Store(string name)
        {
            if (name.Length < 5)
            {
                throw new ArgumentException("Invalid store name!");
            }
            else
            {
                this.name = name;
            }
            cars = new List<Car>();
        }
        public List<Car> Cars 
        { 
            get { return cars; }
            set { this.cars = value; }
        }
        public string Name 
        { 
            get { return name; }
            set { this.name = value; }
        }
        public override string ToString()
        {
            if (!cars.Any())
            {
                return $"Store {name} has no available cars.";
            }
            else
            {
                string result = string.Empty;
                result += $"Store {name} has {cars.Count} car/s:\n";
                foreach (var car in cars)
                {
                    result += $"{car.ToString()}\n";
                }
                return result;
            }
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public bool SellCar(Car car)
        {
            bool wheather = false;
            int carNumber = car.Number;
            for (int i = 0; i < cars.Count; i++)
            {
                if (carNumber == cars[i].Price)
                {
                    cars.RemoveAt(i);
                    return true;
                }
            }
            return wheather;
        }
        public double CalculateTotalPrice()
        {
            double sumOfPrices = 0;
            foreach (var car in cars)
            {
                sumOfPrices += car.Price;
            }
            return sumOfPrices;
        }
        public void RenameStore(string newName)
        {
            if (newName.Length < 5)
            {
                throw new ArgumentException("Invalid store name!");
            }
            else
            {
                this.name = newName;
            }
        }
        public void SellAllCars()
        {
            if (cars.Any())
            {
                while (true)
                {
                    cars.RemoveAt(0);
                    if (!cars.Any())
                    {
                        break;
                    }
                }
            }
        }
        public Car GetCarWithHighestPrice()
        {
            cars = cars.OrderByDescending(x => x.Price).ToList();
            return cars[0];
        }
        public Car GetCarWithLowestPrice()
        {
            cars = cars.OrderBy(x => x.Price).ToList();
            return cars[0];
        }
    }
}