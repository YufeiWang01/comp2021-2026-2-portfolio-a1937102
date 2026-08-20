
public class Contractor : Employee, IReportable
{
    public decimal Rate { get; set; }
    public decimal Hours { get; set; }


    public Contractor(string name, decimal rate, decimal hours): base(name)
    {
        Rate = rate;
        Hours = hours;
    }


    public override decimal CalculatePay()
    
    {
        return (Rate * Hours) * (1 - TaxRate);
    }


    public string GenerateReport()
    {
        return $"Contractor: {Name}, Pay: {CalculatePay()}";
    }
}