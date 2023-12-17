namespace Problem4;

public delegate void WorkPerformedEventHandler(int hours);

public delegate void BreakTakenEventHandler(int minutes);

public class Employee : IEmployee
{
	private int _totalWorkHours;
	private int _totalBreakMinutes;

	public event WorkPerformedEventHandler? WorkPerformed;
	public event BreakTakenEventHandler? BreakTaken;

	public void Work(int hours)
	{
		_totalWorkHours += hours;
		WorkPerformed?.Invoke(hours);
	}

	public void TakeBreak(int minutes)
	{
		_totalBreakMinutes += minutes;
		BreakTaken?.Invoke(minutes);
	}
}
