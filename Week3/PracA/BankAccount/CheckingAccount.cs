
public class CheckingAccount : BankAccount
{
    public decimal TransactionFee { get; set;}

    public CheckingAccount(string owner, decimal balance, decimal transactionFee) : base(owner, balance) {TransactionFee = transactionFee;}

    public void WithdrawWithFee(decimal amount) 
    {
        Withdraw(amount + TransactionFee);
    }
    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Account: CheckingAccount");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine($"Transaction fee: {TransactionFee}");
    }
}