using System;

public class Bus : Vehicle
{
    private const double CarACFuelConsumation = 1.4;

    public Bus(double fuelQuantity, double litersPerkm, double tankCapacity)
        : base(fuelQuantity, litersPerkm, tankCapacity  )
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

    public override string FuelConsumation(double distance, bool IsAcOn)
    {
        if (IsAcOn)
        {
            this.LitersPerKm += CarACFuelConsumation;
        }
        return base.FuelConsumation(distance, IsAcOn);

    }
}
