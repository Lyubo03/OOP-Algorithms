namespace NeedForSpeed
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            SportCar spCar = new SportCar(180, 79);
            spCar.Drive(10);
            Car car = new Car(180, 79);
            car.Drive(10);
            RaceMotorcycle race = new RaceMotorcycle(180, 79);
            race.Drive(10);
            Console.WriteLine(spCar.Fuel);
            Console.WriteLine(car.Fuel);
            Console.WriteLine(race.Fuel);
        }
    }
}