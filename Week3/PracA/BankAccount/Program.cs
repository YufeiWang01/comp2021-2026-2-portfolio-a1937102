
SavingsAccount savings = new SavingsAccount("Yufei", 1000m, 0.05m);

Console.WriteLine($"Savings balance: {savings.Balance}");

savings.ApplyInterest();

Console.WriteLine($"Savings after interest: {savings.Balance}");


CheckingAccount checking = new CheckingAccount("Yufei", 1000m, 5m);

Console.WriteLine($"Checking balance: {checking.Balance}");

checking.WithdrawWithFee(100m);

Console.WriteLine($"Checking after withdrawal: {checking.Balance}");

savings.DisplayAccountInfo();

Console.WriteLine();

checking.DisplayAccountInfo();

