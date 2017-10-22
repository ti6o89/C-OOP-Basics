using System;

public class Topping
{
    private static int MinWeight = 1;
    private static int MaxWeight = 50;

    private string type;
    private int weight;

    public Topping(string type, int weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public string Type
    {
        set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.type = value;
        }
    }

    public int Weight
    {
        set
        {
            if (MinWeight < value && value > MaxWeight)
            {
                throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
            }
            this.weight = value;
        }
    }

    public double CalculateCalories()
    {
        double modifier = 0;

        switch (this.type.ToLower())
        {
            case "meat":
                modifier = 1.2;
                break;
            case "veggies":
                modifier = 0.8;
                break;
            case "cheese":
                modifier = 1.1;
                break;
            case "sauce":
                modifier = 0.9;
                break;
        }

        return 2 * this.weight * modifier;
    }

}
