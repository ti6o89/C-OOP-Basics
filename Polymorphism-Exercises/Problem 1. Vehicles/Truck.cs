
public class Truck : Vehicle
{
    private const double TruckACFuelConsumation = 1.6;

    public Truck(double fuelQuantity, double litersPerkm, double tankCapacity)
        : base(fuelQuantity, litersPerkm + TruckACFuelConsumation, tankCapacity)
    {
    }

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * 0.95);
    }
}
