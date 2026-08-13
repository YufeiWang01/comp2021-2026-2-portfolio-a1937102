
BankAccount account = new BankAccount();

account.Owner = "Yufei";
account.Balance = 100m;

Console.WriteLine($"Owner: {account.Owner}");
Console.WriteLine($"Balance: ${account.Balance}");

account.Deposit(50m);
account.Deposit(20);
account.Deposit(5.5);
Console.WriteLine($"After deposit: ${account.Balance}");

account.Withdraw(30m);
Console.WriteLine($"After withdraw: ${account.Balance}");

