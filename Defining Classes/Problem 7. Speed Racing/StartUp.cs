using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7.Speed_Racing
{
    class StartUp
    {
        static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuelAmount = int.Parse(carInfo[1]);
                var fuelConsumation = double.Parse(carInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumation);
                cars.Add(car);               
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var command = input.Split().ToArray();
                var model = command[1];
                var distance = int.Parse(command[2]);
                var carModel = cars.Where(m => m.Model == model).FirstOrDefault();

                carModel.DistanceCalculator(carModel.FuelAmount, carModel.FuelConsumation, distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}
