﻿
public abstract class Mamal : Animal
{
    public Mamal(string name, string type, double weight, string livingRegion)
        : base(name, type, weight)
    {
        this.LivingRegion = livingRegion;
    }

    protected string LivingRegion { get; set; }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
