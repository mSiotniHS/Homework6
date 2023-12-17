namespace Problem2;

public class Task
{
	public string Name { get; }
	public string Description { get; }
	public bool Done { get; set; }

	public Task(string name, string description)
	{
		Name = name;
		Description = description;
		Done = false;
	}
}
