
public abstract class Food
{

    protected Food(int happinessPoints)
    {
        this.HappinesPoints = happinessPoints;
    }

    public int HappinesPoints { get; set; }

    public int GetHappinessPoints()
    {
        return this.HappinesPoints;
    }
}

