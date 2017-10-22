public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public abstract int GetAffinity();

    public override string ToString()
    {
        var type = this.GetType().Name;
        var typeEnd = type.IndexOf("Monument");
        type = type.Insert(typeEnd, " ");

        return $"{type}: {this.name}";
    }
}
