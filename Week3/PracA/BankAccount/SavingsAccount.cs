
public class SavingsAccount : BankAccount
{
    public decimal interestRate { get; set; }

    public SavingsAccount(string Owner, decimal balance, decimal interestRate) : base(Owner, balance) {this.interestRate = interestRate;}

    public void ApplyInterest()
    {
        Balance = Balance + (Balance * interestRate);
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Account: SavingsAccount");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine($"Interest rate: {interestRate}");
    }
}