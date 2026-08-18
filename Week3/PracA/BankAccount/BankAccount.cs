
public class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; set;}

    public BankAccount(string Owner, decimal balance)
    {
        Owner = Owner;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        Balance = Balance + amount;
    }
    public void Deposit(int amount)
    {
        Balance = Balance + amount;
    }
    public void Deposit(double amount)
    {
        Balance = Balance + (decimal)amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new ArgumentException("Balance is too low");

        }

        Balance = Balance - amount;
    }

        public virtual void DisplayAccountInfo()
    {
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: {Balance}");
    }
}

