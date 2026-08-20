


List<Employee> employees = new List<Employee>();


employees.Add(new FullTimeEmployee("Yufei", 50000m));
employees.Add(new Contractor("Ian", 50m, 100m));

foreach (Employee employee in employees)
{
    decimal pay = employee.CalculatePay();
    decimal tax = pay / (1 - Employee.TaxRate) * Employee.TaxRate;

    Console.WriteLine($"{employee.Name}: Pay ${pay}, Tax ${tax}");
}