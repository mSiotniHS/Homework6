using Problem1;

var trafficLight = new TrafficLight();
trafficLight.ColorChanged += color => Console.WriteLine($"New color: {color}");

trafficLight.Start();
