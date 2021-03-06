﻿using System;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;

    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        if (tires.Length != 4)
        {
            throw new InvalidOperationException("Car must have exactly 4 tires!");
        }

        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
    }

    public Tire[] Tire
    {
        get { return this.tires; }
    }

    public string Model
    {
        get { return this.model; }
    }

    public Engine Engine
    {
        get { return this.engine; }
    }
}
