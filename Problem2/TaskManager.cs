namespace Problem2;

public delegate void TaskStatusChangedEventHandler(Task task);

public class TaskManager
{
	public event TaskStatusChangedEventHandler? TaskStatusChanged;

	public void CompleteTask(Task task)
	{
		task.Done = true;
		TaskStatusChanged?.Invoke(task);
	}
}
