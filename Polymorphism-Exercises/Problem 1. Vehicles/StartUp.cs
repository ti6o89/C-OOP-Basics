using System;

namespace Problem_1.Vehicles
{
    class StartUp
    {
        static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truckInfo = Console.ReadLine().Split();
            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var busInfo = Console.ReadLine().Split();
            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                try
                {
                    var tokens = Console.ReadLine().Split();
                    var type = tokens[1];

                    if (type == "Car")
                    {
                        ExecuteAction(car, tokens[0], double.Parse(tokens[2]));
                    }
                    else if (type == "Truck")
                    {
                        ExecuteAction(truck, tokens[0], double.Parse(tokens[2]));
                    }
                    else if (type == "Bus")
                    {
                        ExecuteAction(bus, tokens[0], double.Parse(tokens[2]));
                    }
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
        {
            switch (command)
            {
                case "Drive":
                    var result = vehicle.FuelConsumation(parameter);
                    Console.WriteLine(result);
                    break;
                case "DriveEmpty":
                    Console.WriteLine(vehicle.FuelConsumation(parameter, false));
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);
                    break;
            }
        }
    }
}
