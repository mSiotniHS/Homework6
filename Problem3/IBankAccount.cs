namespace Problem3;

public interface IBankAccount
{
	void Deposit(decimal amount);
	void Withdraw(decimal amount);
	decimal GetBalance();
}
