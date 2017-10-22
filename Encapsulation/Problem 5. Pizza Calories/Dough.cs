using System;

public class Dough
{
    private const int MinDoughWeight = 0;
    private const int MaxDoughWeight = 200;

    private string flourType;
    private string bakingTechnique;
    private int weight;

    public Dough(string flourType, string bakingTechnique, int weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }


    public int Weight
    {
        set
        {
            if (MinDoughWeight > value || value > MaxDoughWeight)
            {
                throw new ArgumentException("Dough weight should be in the range[1..200].");
            }
            this.weight = value;
        }
    }

    public double CalculateCalories()
    {
        double flourModifier = 0;
        double bakingModifier = 0;

        switch (this.flourType.ToLower())
        {
            case "white":
                flourModifier = 1.5;
                break;
            case "wholegrain":
                flourModifier = 1.0;
                break;
        }

        switch (this.bakingTechnique.ToLower())
        {
            case "crispy":
                bakingModifier = 0.9;
                break;
            case "chewy":
                bakingModifier = 1.1;
                break;
            case "homemade":
                bakingModifier = 1.0;
                break;
        }

        return (2 * this.weight) * flourModifier * bakingModifier;
    }
}
