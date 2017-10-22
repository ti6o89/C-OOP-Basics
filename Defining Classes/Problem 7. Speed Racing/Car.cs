using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumation;
    private int distanceTraveled;

    public Car(string model, int fuelAmount, double fuelConsumation)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumation = fuelConsumation;
    }

    public string Model
    {
        get { return this.model; }
    }
    public double FuelAmount
    {
        get { return this.fuelAmount; }
    }
    public double FuelConsumation
    {
        get { return this.fuelConsumation; }
    }
    public int DistanceTraveled
    {
        get { return this.distanceTraveled; }
    }


    public void DistanceCalculator(double fuelAmount, double fuelConsumation, int distance)
    {
        if (fuelAmount >= fuelConsumation * distance)
        {
            this.fuelAmount -= (fuelConsumation * distance);
            this.distanceTraveled += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
