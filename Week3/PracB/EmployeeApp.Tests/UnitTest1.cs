
public class UnitTest1
{
    [Fact]
    public void FullTimeEmployeePayTest()
    {
        FullTimeEmployee employee = new FullTimeEmployee("Yufei", 50000m);

        decimal pay = employee.CalculatePay();

        Assert.Equal(40000m, pay);
    }

    [Fact]
    public void ContractorPayTest()
    {
        Contractor employee = new Contractor("IAN", 50m, 100m);

        decimal pay = employee.CalculatePay();

        Assert.Equal(4000m, pay);
    }
}