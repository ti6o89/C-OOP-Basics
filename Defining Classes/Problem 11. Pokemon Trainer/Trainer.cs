﻿using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int numberOfBadges;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.name = name;
        this.numberOfBadges = 0;
        this.pokemons = new List<Pokemon>();
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }

    public int NumberOfBadges
    {
        get { return this.numberOfBadges; }
        set { this.numberOfBadges = value; }
    }

    public string Name
    {
        get { return this.name; }
    }
}

