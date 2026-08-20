
public class FullTimeEmployee : Employee, IReportable
{
    public decimal Salary { get; set; }


    public FullTimeEmployee(string name, decimal salary) : base(name)
    {
        Salary = salary;
    }


    public override decimal CalculatePay()
    {
        return Salary * (1 - TaxRate);
    }


    public string GenerateReport()
    {
        return $"Full-time Employee: {Name}, Pay: {CalculatePay()}";
    }
}