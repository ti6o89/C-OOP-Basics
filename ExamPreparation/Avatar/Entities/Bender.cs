public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public abstract double GetPower();

    public override string ToString()
    {
        var benderType = this.GetType().Name;
        var benderEnd = benderType.IndexOf("Bender");
        benderType = benderType.Insert(benderEnd, " ");

        return $"{benderType}: {this.name}, Power: {this.power}";
    }
}
