using System;

List<TaskItem> tasks = new();
int taskId = 1;

while (true)
{
	Console.Clear();
	Console.WriteLine("=== TODO LIST MANAGER ===");

	Console.ForegroundColor = ConsoleColor.Red;
	Console.Write("1");
	Console.ResetColor();
	Console.WriteLine(". Add a task");

	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write("2");
	Console.ResetColor();
	Console.WriteLine(". View all tasks");

	Console.ForegroundColor = ConsoleColor.Green;
	Console.Write("3");
	Console.ResetColor();
	Console.WriteLine(". Mark a task as completed");

	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.Write("4");
	Console.ResetColor();
	Console.WriteLine(". Delete a task");

	Console.ForegroundColor = ConsoleColor.Magenta;
	Console.Write("5");
	Console.ResetColor();
	Console.WriteLine(". Exit");

	Console.Write("Choose an option: ");
	string? input = Console.ReadLine();

	switch (input)
	{
		case "1":
			AddTask();
			break;
		case "2":
			ViewTasks();
			break;
		case "3":
			MarkTaskCompleted();
			break;
		case "4":
			DeleteTask();
			break;
		case "5":
			return;
		default:
			Console.WriteLine("Invalid option. Press Enter to continue.");
			Console.ReadLine();
			break;
	}
}


