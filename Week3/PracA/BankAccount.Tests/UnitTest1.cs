
public class UnitTest1
{
    [Fact]
    public void BankAccountTest()
    {
        BankAccount account = new BankAccount("Yufei", 1000m);

        account.Deposit(100m);
        account.Withdraw(200m);

        Assert.Equal(900m, account.Balance);
    }

    [Fact]
    public void WithdrawTooMuchTest()
    {
        BankAccount account = new BankAccount("Yufei", 1000m);

        Assert.Throws<ArgumentException>(() => account.Withdraw(1100m));
    }

    [Fact]
    public void SavingsAccountTest()
    {
        SavingsAccount account = new SavingsAccount("Yufei", 1000m, 0.05m);

        account.ApplyInterest();

        Assert.Equal(1050m, account.Balance);
    }

    [Fact]
    public void CheckingAccountTest()
    {
        CheckingAccount account = new CheckingAccount("Yufei", 1000m, 5m);

        account.WithdrawWithFee(100m);

        Assert.Equal(895m, account.Balance);
    }
}