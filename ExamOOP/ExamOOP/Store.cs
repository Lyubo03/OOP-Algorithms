using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamOOP
{
    public class Store
    {
        private string name;
        private List<Car> cars;
        public List<Car> Cars { get { return cars; } }
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
        public string Name { get { return name; } }
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
                    result += $"Car number {car.Number} costs {car.Price}\n";
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
            if (cars.Contains(car))
            {
                cars.Remove(car);
                return true;
            }
            else
            {
                return false;
            }
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
                foreach (var car in cars)
                {
                    cars.Remove(car);
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
//CreateStore MyStore
//StoreInfo MyStore
//TestInvalid
//AddCar 1 8000 MyStore
//AddCar 14 4000 MyStore
//StoreInfo MyStore
//SellCar 1 8000 MyStore
//StoreInfo MyStore
//AddCar 2 2800.50 MyStore
//AddCar 3 3500.50 MyStore
//AddCar 4 4000.50 MyStore
//StoreInfo MyStore
//CalculateTotalPrice MyStore
//SellAllCars MyStore
//CalculateTotalPrice MyStore
//StoreInfo MyStore
//RenameStore MyStore MyNewStore
//StoreInfo MyNewStore
//AddCar 6 12000.50 MyNewStore
//AddCar 7 22000.50 MyNewStore
//GetCarWithHighestPrice MyNewStore
//AddCar 8 1500.20 MyNewStore
//GetCarWithLowestPrice MyNewStore
//CreateStore NewestStore
//StoreInfo NewestStore
//STOP