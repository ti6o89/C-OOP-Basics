
partial class Cat : Felime
{
    public Cat(string name, string type, double weight, string livingRegion, string bread)
        : base(name, type, weight, livingRegion)
    {
        this.Bread = bread;
    }

    public string Bread { get; set; }

    public override string MakeSound()
    {
        return "Meowwww";
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Bread}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
