
public class FoodFActory
{
    public Food GetFood(string[] tokens)
    {
        string foodType = tokens[0];
        int quantity = int.Parse(tokens[1]);

        if (foodType == "Meat")
        {
            return new Meat(quantity);
        }

        return new Vegetable(quantity);
    }
}
