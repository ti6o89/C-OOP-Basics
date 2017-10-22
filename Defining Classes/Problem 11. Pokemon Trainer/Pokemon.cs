
public class Pokemon
{
    private string name;
    private string element;
    private int helth;

    public Pokemon(string name, string element, int helth)
    {
        this.name = name;
        this.element = element;
        this.helth = helth;
    }

    public string Element
    {
        get { return this.element; }
    }

    public int Helth
    {
        get { return this.helth; }
        set { this.helth = value; }
    }
}
