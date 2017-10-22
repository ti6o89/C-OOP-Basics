using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private const int MinFNumLength = 5;
    private const int MaxFNumLength = 10;

    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    private string FacultyNumber
    {
        set
        {
            if (MinFNumLength > value.Length || value.Length > MaxFNumLength || !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString()).AppendLine($"Faculty number: {this.facultyNumber}");

        return sb.ToString();
    }
}
