using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Apple : Food
{
    private const int HappinessPoints = 1;
    public Apple()
        : base(HappinessPoints)
    {
    }
}
