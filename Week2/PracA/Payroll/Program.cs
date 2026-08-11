Payroll payroll = new Payroll(40, 20.00m, 0.2m);

Console.WriteLine($"Net pay: {payroll.CalculateNetpay():F2}");

payroll.ChangeTaxRate(0.25m);

Console.WriteLine($"New Net pay: ${payroll.CalculateNetpay():F2}");