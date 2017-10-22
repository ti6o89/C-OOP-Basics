using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mushrooms : Food
{
    private const int HappinessPoints = -10;
    public Mushrooms()
        : base(HappinessPoints)
    {
    }
}
