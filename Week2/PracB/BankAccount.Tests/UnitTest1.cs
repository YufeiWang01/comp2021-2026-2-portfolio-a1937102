

public class UnitTest1
{
    [Fact]
    public void OwnerTest()
    {
        BankAccount account = new BankAccount();
        account.Owner = "Yufei";

        Assert.Equal("Yufei", account.Owner);
    }


    [Fact]
    public void DepositDecimalTest()
    {
        BankAccount account = new BankAccount();
        account.Balance = 100m;
        account.Deposit(50m);

        Assert.Equal(150m, account.Balance);
    }

    [Fact]
    public void DepositIntTest()
    {
        BankAccount account = new BankAccount();
        account.Balance = 100m;
        account.Deposit(50);

        Assert.Equal(150m, account.Balance);
    }

    [Fact]
    public void DepositDoubleTest()
    {
        BankAccount account = new BankAccount();
        account.Balance = 100m;
        account.Deposit(50.5);

        Assert.Equal(150.5m, account.Balance);
    }

    [Fact]
    public void WithdrawTest()
    {
        BankAccount account = new BankAccount();
        account.Balance = 100m;
        account.Withdraw(30m);

        Assert.Equal(70m, account.Balance);
    }

    [Fact]
    public void WithdrawTest1()
    {
        BankAccount account = new BankAccount();
        account.Balance = 100m;

        Assert.Throws<ArgumentException>(()=> account.Withdraw(150m));
    }
}
