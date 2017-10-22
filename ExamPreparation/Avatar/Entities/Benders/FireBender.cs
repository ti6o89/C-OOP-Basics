public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.heatAggression;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Heat Aggression: {this.heatAggression:f2}";
    }
}
