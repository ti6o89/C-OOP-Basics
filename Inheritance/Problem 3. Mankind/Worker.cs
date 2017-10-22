using System;
using System.Text;

public class Worker : Human
{
    private const int MinSalaryValue = 10;
    private const int MinWorkingHours = 1;
    private const int MaxWorkingHours = 12;

    private decimal weekSalary;
    private double workingHours;

    public Worker(string firstName, string lastName, decimal weekSalary, double workingHours)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkingHours = workingHours;
    }

    private decimal WeekSalary
    {
        set
        {
            if (value <= MinSalaryValue)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    private double WorkingHours
    {
        set
        {
            if (MinWorkingHours > value || value > MaxWorkingHours)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workingHours = value;
        }
    }
    private decimal GetSalaryPrtHour()
    {
        var salaryPerDay = this.weekSalary / 5;
        return salaryPerDay / (decimal)workingHours;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString()).AppendLine($"Week Salary: {this.weekSalary:f2}")
            .AppendLine($"Hours per day: {this.workingHours:f2}")
            .AppendLine($"Salary per hour: {this.GetSalaryPrtHour():f2}");

        return sb.ToString();
    }
}
