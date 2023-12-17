using Problem4;

var employee = new Employee();
employee.WorkPerformed += hours => Console.WriteLine($"Was doing work for {hours} hours");
employee.BreakTaken += minutes => Console.WriteLine($"Took a {minutes} minutes break");

employee.Work(4);
employee.TakeBreak(60);
employee.Work(4);
