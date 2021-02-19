using System;
using System.Collections.Generic;
using System.Text;

namespace ITCareer_OOP_Exam_1
{
    public class Car
    {
        private int number;
        private double price;
        public Car(int number, double price)
        {
            this.number = number;
            if (price < 1000)
            {
                throw new ArgumentException("Invalid car price!");
            }
            else
            {
                this.price = price;
            }
        }
        public int Number
        { 
            get { return this.number; }
            set { this.number = value; }
        }
        public double Price 
        {
            get { return this.price; }
            set 
            {
                if (value<1000)
                {
                    throw new ArgumentException("Invalid car price!");
                }
                this.price = value; 
            }
        }
        public override string ToString()
        {
            return $"Car number {number} costs {price:F2}"; 
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