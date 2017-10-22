using System;
using System.Collections.Generic;

public class Pizza
{
    private static int NameMaxLength = 15;
    private static int MaxToppings = 10;
    private static int MinToppings = 0;

    private string name;
    private Dough dough;
    private int toppingsCount;
    private List<Topping> toppings;

    public Pizza(string name, int toppingsCount)
    {
        this.Name = name;
        this.ToppingsCount = toppingsCount;
        this.toppings = new List<Topping>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) && value.Length > NameMaxLength)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }

    public int ToppingsCount
    {
        get { return this.toppingsCount; }
        set
        {
            if (MinToppings > value || value > MaxToppings)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppingsCount = value;
        }
    }

    public Dough Dough
    {
        set { this.dough = value; }
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
    }

    public double GetTotalCalories()
    {
        double result = this.dough.CalculateCalories();
        this.toppings.ForEach(t => result += t.CalculateCalories());

        return result;
    }

    public override string ToString()
    {
        return $"{this.name} - {this.GetTotalCalories():f2} Calories.";
    }
}
