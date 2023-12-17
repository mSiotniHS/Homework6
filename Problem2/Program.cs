using Problem2;
using Task = Problem2.Task;

var manager = new TaskManager();
var notificationService = new NotificationService();
manager.TaskStatusChanged += notificationService.TaskCompletedNotification;

var task1 = new Task("Название задачи!", "Описание задачи!");
// var task2 = new Task("Сделать лабу!", "Лабу которая по РПИ!");

manager.CompleteTask(task1);
