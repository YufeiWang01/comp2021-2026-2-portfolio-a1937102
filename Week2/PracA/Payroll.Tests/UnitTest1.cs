
public class UnitTest1
{
    [Fact]
    public void CaluculateNetPay()
    {
        Payroll payroll = new Payroll(40, 25m, 0.2m);

        decimal result = payroll.CalculateNetpay();

        Assert.Equal(800m, result);
    }

    [Fact]
    public void HoursNotNegative()
    {
        Payroll payroll = new Payroll(40, 25m, 0.2m);

        Assert. Throws<ArgumentException>(()=> payroll.Hours = -1);
    }

    [Fact]
    public void RateNotNegative()
    {
        Payroll payroll = new Payroll(40, 25m, 0.2m);

        Assert. Throws<ArgumentException>(()=> payroll.Rate = -1);
    }

    [Fact]
    public void TaxRateNotNegative()
    {
        Payroll payroll = new Payroll(40, 25m, 0.2m);

        Assert. Throws<ArgumentException>(()=> payroll.TaxRate = -1);
    }

    [Fact]
    public void ChangeTaxRateTest()
    {
        Payroll payroll = new Payroll(40, 25m, 0.2m);

        payroll.ChangeTaxRate(0.15m);

        Assert.Equal(0.15m, payroll.TaxRate);
    }

    [Fact]
    public void GetHoursAndRate()
    {
        Payroll payroll = new Payroll(40, 25m, 0.2m);

        Assert.Equal(40, payroll.Hours);
        Assert.Equal(25m, payroll.Rate);
    }


}
