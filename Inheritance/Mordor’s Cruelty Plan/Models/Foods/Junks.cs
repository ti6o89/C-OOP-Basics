using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Junks : Food
{
    private const int HappinessPoints = -1;
    public Junks()
        : base(HappinessPoints)
    {
    }
}

