
using System.Collections.Generic;
using System.Linq;

public class Gandalf
{
    private List<Food> foods;

    public Gandalf()
    {
        this.foods = new List<Food>();
    }

    public void Eat(Food food)
    {
        this.foods.Add(food);
    }

    public int GetHappinessPoints()
    {
        return foods.Sum(p => p.GetHappinessPoints());
    }
}
