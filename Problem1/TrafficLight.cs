namespace Problem1;

public enum Color
{
	Red,
	Yellow,
	Green
}

public class TrafficLight
{
	private Color _currentColor = Color.Red;

	public event Action<Color>? ColorChanged;

	public void Start()
	{
		while (true)
		{
			var nextColor = _currentColor switch
			{
				Color.Red => Color.Yellow,
				Color.Yellow => Color.Green,
				Color.Green => Color.Red,
				_ => throw new ArgumentOutOfRangeException()
			};

			var workTime = GetColorWorkTime(nextColor);
			_currentColor = nextColor;
			ColorChanged?.Invoke(_currentColor);
			Thread.Sleep(workTime);
		}
	}

	private static TimeSpan GetColorWorkTime(Color color) =>
		color switch
		{
			Color.Red => TimeSpan.FromSeconds(20),
			Color.Yellow => TimeSpan.FromSeconds(5),
			Color.Green => TimeSpan.FromSeconds(15),
			_ => throw new ArgumentOutOfRangeException(nameof(color), color, null)
		};
}
