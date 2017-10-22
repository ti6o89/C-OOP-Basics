
public class Company
{
    private string companyName;
    private string department;
    private decimal salary;

    public Company(string companyName, string department, decimal salary)
    {
        this.companyName = companyName;
        this.department = department;
        this.salary = salary;
    }

    public string Name
    {
        get { return this.companyName; }
    }

    public string Department
    {
        get { return this.department; }
    }

    public decimal Salary
    {
        get { return this.salary; }
    }


}
