using Problem3;

var account = new BankAccount();
account.BalanceChanged += balance => Console.WriteLine($"New balance: {balance}");
account.Overdraft += amount => Console.WriteLine($"Insufficient funds! You ain’t got no money! Too much by {amount}");

account.Deposit(500);
account.Withdraw(250);
account.Deposit(100);
account.Withdraw(400);
Console.WriteLine(account.GetBalance());
