
using System.Collections.Generic;

public class Person
{
    private string name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Childern> children;
    private Car car;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Company Company { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    public List<Parent> Parents { get; set; }

    public List<Childern> Children { get; set; }

    public Car Car { get; set; }

    public Person(string name)
    {
        this.Name = name;
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Parent>();
        this.Children = new List<Childern>();
    }
}
