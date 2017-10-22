using System.Collections.Generic;
using System.Linq;;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    private List<int> ClosedRaces;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
        this.ClosedRaces = new List<int>();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        if (type == "Performance")
        {
            var car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            cars.Add(id, car);
        }
        else
        {
            var car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            this.cars.Add(id, car);
        }
    }
    public string Check(int id)
    {
        var currentCar = this.cars[id];
        return currentCar.ToString();
    }
    public void Open(int id, string type, int length, string route, int prizePool)
    {
        var currentRace = this.GetRace(type, length, route, prizePool);
        this.races.Add(id, currentRace);
    }

    public void Participate(int carId, int raceId)
    {
        if (!this.garage.ParkedCars.ContainsKey(carId) && !ClosedRaces.Contains(raceId))
        {
            this.races[raceId].AddParticipants(carId, this.cars[carId]);
        }        
    }

    public string Start(int id)
    {
        var currentRace = races[id];
        if (currentRace.Participants.Count() != 0)
        {
            var result = currentRace.PrintWinners();
            ClosedRaces.Add(id);
            return result;           
        }
        return "Cannot start the race with zero participants.";
    }

    public void Park(int id)
    {
        foreach (var race in this.races.Where(r => !ClosedRaces.Contains(r.Key)))
        {
            if (race.Value.Participants.ContainsKey(id))
            {
                return;
            }
        }
        this.garage.AddCar(id, this.cars[id]);
    }

    public void Unpark(int id)
    {
        this.garage.Unpark(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in this.garage.ParkedCars)
        {
            car.Value.Tune(tuneIndex, addOn);
        }
    }

    private Race GetRace(string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                return new CasualRace(length, route, prizePool);
            case "Drag":
                return new DragRace(length, route, prizePool);
            case "Drift":
                return new DragRace(length, route, prizePool);
            default:
                return null;
        }
    }

}
