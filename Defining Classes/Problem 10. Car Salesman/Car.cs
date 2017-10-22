public class Car
{
    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = 0;
        this.color = "n/a";
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        set
        {
            this.engine = value;
        }
    }

    public string Color
    {
        get
        {
            return this.color;
        }
        set
        {
            this.color = value;
        }
    }

    public int Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            this.weight = value;
        }
    }
}
