namespace Problem2;

public class NotificationService
{
	public void TaskCompletedNotification(Task task)
	{
		Console.WriteLine($"Task '{task.Name}' is done!");
	}
}
