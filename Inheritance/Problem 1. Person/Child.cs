using System;

public class Child : Person
{
    private const int MaxAge = 15;

    public Child(string name, int age)
        : base(name, age)
    {
    }

    public override int Age
    {
        set
        {
            if (value >= MaxAge)
            {
                throw new ArgumentException("Child's age must be less than 15!");
            }
            base.Age = value;
        }
    }
}
