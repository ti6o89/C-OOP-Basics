
using System;

public class Vehicle
{
    public Vehicle(double fuelQuantity, double litersPerkm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = litersPerkm;
    }

    protected double TankCapacity { get; set; }

    protected virtual double FuelQuantity { get; set; }

    protected double LitersPerKm { get; set; }

    public virtual string FuelConsumation(double distance, bool IsAcOn)
    {
        var neededFuel = this.LitersPerKm * distance;
        if (neededFuel > this.FuelQuantity)
        {
            return $"{this.GetType().Name} needs refueling";
        }
        this.FuelQuantity -= neededFuel;
        return $"{this.GetType().Name} travelled {distance} km";
    }

    public virtual string FuelConsumation(double distance)
    {
        return this.FuelConsumation(distance, true);
    }

    public virtual void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
