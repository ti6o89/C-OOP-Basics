﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Melon : Food
{
    private const int HappinessPoints = 1;
    public Melon()
        : base(HappinessPoints)
    {
    }
}
