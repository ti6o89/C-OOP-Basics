
public class Childern
{
    private string childrenName;
    private string childrenBirthday;

    public Childern(string childrenName, string childrenBirthday)
    {
        this.childrenName = childrenName;
        this.childrenBirthday = childrenBirthday;
    }

    public string Name
    {
        get { return this.childrenName; }
    }

    public string Birthday
    {
        get { return this.childrenBirthday; }
    }
}

