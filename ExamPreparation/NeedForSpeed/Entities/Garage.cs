using System.Collections.Generic;

public class Garage
{
    private Dictionary<int, Car> parkedCars;

    public Garage()
    {
        this.ParkedCars = new Dictionary<int, Car>();
    }

    public Dictionary<int, Car> ParkedCars
    {
        get { return this.parkedCars; }
        set { this.parkedCars = value; }
    }

    public void AddCar(int id, Car car)
    {
        parkedCars.Add(id, car);
    }

    public void Unpark(int id)
    {
        this.parkedCars.Remove(id);
    }
}
