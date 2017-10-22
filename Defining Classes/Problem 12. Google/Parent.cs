
public class Parent
{
    private string parentName;
    private string parentBirthday;

    public Parent(string parentName, string parentBirthday)
    {
        this.parentName = parentName;
        this.parentBirthday = parentBirthday;
    }

    public string Name
    {
        get { return this.parentName; }
    }

    public string Birthday
    {
        get { return this.parentBirthday; }
    }
}
