
public class AnimalFactory
{
    public Animal GetAnimal(string[] tokens)
    {
        var type = tokens[0];
        var name = tokens[1];
        var weight = double.Parse(tokens[2]);
        var livingRegion = tokens[3];

        switch (type)
        {
            case "Zebra":
                return new Zebra(name, type, weight, livingRegion);
            case "Mouse":
                return new Mouse(name, type, weight, livingRegion);
            case "Tiger":
                return new Tiger(name, type, weight, livingRegion);
            case "Cat":
                return new Cat(name, type, weight, livingRegion, tokens[4]);
            default:
                return null;
        }
    }
}
