using System

void AddTask()
{
	Console.Clear();
	Console.WriteLine("=== ⋆｡°✩ ADD A NEW TASK ⋆｡°✩ ===");

	Console.Write("Enter task title: ");
	string? title = Console.ReadLine();

	Console.Write("Enter task description (optional): ");
	string? description = Console.ReadLine();

	Priority priority;
	while (true)
	{
		Console.WriteLine("Select priority:");

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("1. Urgent");
		Console.ResetColor();

		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("2. Normal");
		Console.ResetColor();

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("3. Later");
		Console.ResetColor();

		Console.Write("Choice (1-3): ");
		string? priorityInput = Console.ReadLine();

		if (priorityInput == "1")
		{
			priority = Priority.Urgent;
			break;
		}
		else if (priorityInput == "2")
		{
			priority = Priority.Normal;
			break;
		}
		else if (priorityInput == "3")
		{
			priority = Priority.Later;
			break;
		}
		else
			Console.WriteLine("Invalid choice ˙◠˙, please select 1, 2 or 3.");
	}

	// Criar nova tarefa
	TaskItem newTask = new(taskId++, title!, description, priority);

	// Adicionar tarefa à lista
	tasks.Add(newTask);

	Console.WriteLine("\nTask added successfully! ★彡 Press Enter to return to menu.");
	Console.ReadLine();
}
