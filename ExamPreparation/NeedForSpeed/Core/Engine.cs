using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private CarManager carMenager;

    public Engine()
    {
        this.carMenager = new CarManager();
    }

    public void Run()
    {
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "Cops Are Here")
        {
            var commandParameters = inputLine.Split().ToList();
            this.DistributeCommand(commandParameters);
        }
    }

    private void DistributeCommand(List<string> commandParameters)
    {
        string command = commandParameters[0];
        commandParameters.Remove(command);

        switch (command)
        {
            case "register":
                var id = int.Parse(commandParameters[0]);
                var type = commandParameters[1];
                var brand = commandParameters[2];
                var model = commandParameters[3];
                var year = int.Parse(commandParameters[4]);
                var horsepower = int.Parse(commandParameters[5]);
                var acceleration = int.Parse(commandParameters[6]);
                var suspension = int.Parse(commandParameters[7]);
                var durability = int.Parse(commandParameters[8]);

                carMenager.Register(id, type, brand, model, year, horsepower, acceleration, suspension, durability);
                break;

            case "check":
                var car = carMenager.Check(int.Parse(commandParameters[0]));
                Console.WriteLine(car);
                break;

            case "open":
                var raceId = int.Parse(commandParameters[0]);
                var raceType = commandParameters[1];
                var length = int.Parse(commandParameters[2]);
                var route = commandParameters[3];
                var prizePool = int.Parse(commandParameters[4]);

                carMenager.Open(raceId, raceType, length, route, prizePool);
                break;

            case "participate":
                carMenager.Participate(int.Parse(commandParameters[0]), int.Parse(commandParameters[1]));
                break;

            case "start":
                Console.WriteLine(carMenager.Start(int.Parse(commandParameters[0])));
                break;

            case "park":
                carMenager.Park(int.Parse(commandParameters[0]));
                break;

            case "unpark":
                carMenager.Unpark(int.Parse(commandParameters[0]));
                break;

            case "tune":
                var tuneIndex = int.Parse(commandParameters[0]);
                var addOn = commandParameters[1];
                carMenager.Tune(tuneIndex, addOn);
                break;
        }
    }
}
