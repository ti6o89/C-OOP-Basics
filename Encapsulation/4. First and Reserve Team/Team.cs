﻿using System.Collections.Generic;

class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reverseTeam;

    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reverseTeam = new List<Person>();
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reverseTeam.Add(person);
        }
    }

    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return this.firstTeam.AsReadOnly(); }
    }

    public IReadOnlyCollection<Person> ReverseTeam
    {
        get { return this.reverseTeam.AsReadOnly(); }
    }
}
