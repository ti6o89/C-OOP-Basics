
using System;

public class Car : Vehicle
{
    private const double CarACFuelConsumation = 0.9;

    public Car(double fuelQuantity, double litersPerkm, double tankCapacity)
        : base(fuelQuantity, litersPerkm + CarACFuelConsumation, tankCapacity)
    {
    }

    protected override double FuelQuantity
    {
        set
        {
            if (value > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }

            base.FuelQuantity = value;
        }
    }
}
