namespace Problem3;

public delegate void OverdraftEventHandler(decimal overdraftAmount);

public delegate void BalanceChangedEventHandler(decimal newBalance);

public class BankAccount : IBankAccount
{
	private decimal _balance = 0;

	public event OverdraftEventHandler? Overdraft;
	public event BalanceChangedEventHandler? BalanceChanged;

	public void Deposit(decimal amount)
	{
		_balance += amount;
		BalanceChanged?.Invoke(_balance);
	}

	public void Withdraw(decimal amount)
	{
		if (amount > _balance)
		{
			Overdraft?.Invoke(amount - _balance);
			return;
		}

		_balance -= amount;
		BalanceChanged?.Invoke(_balance);
	}

	public decimal GetBalance() => _balance;
}
