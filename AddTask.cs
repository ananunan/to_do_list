using System

void AddTask()
{
	Console.Clear();
	Console.WriteLine("=== ADD A NEW TASK ===");

	// Título da tarefa
	Console.Write("Enter task title: ");
	string? title = Console.ReadLine();

	// Descrição (opcional)
	Console.Write("Enter task description (optional): ");
	string? description = Console.ReadLine();

	// Definir prioridade com validação e cores
	Priority priority;
	while (true)
	{
		Console.WriteLine("Select priority:");

		// High - vermelho
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("1. High");
		Console.ResetColor();

		// Medium - amarelo
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("2. Medium");
		Console.ResetColor();

		// Low - verde
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("3. Low");
		Console.ResetColor();

		Console.Write("Choice (1-3): ");
		string? priorityInput = Console.ReadLine();

		if (priorityInput == "1")
		{
			priority = Priority.High;
			break;
		}
		else if (priorityInput == "2")
		{
			priority = Priority.Medium;
			break;
		}
		else if (priorityInput == "3")
		{
			priority = Priority.Low;
			break;
		}
		else
		{
			Console.WriteLine("Invalid choice, please select 1, 2 or 3.");
		}
	}

	// Criar nova tarefa
	TaskItem newTask = new(taskId++, title!, description, priority);

	// Adicionar tarefa à lista
	tasks.Add(newTask);

	Console.WriteLine("\nTask added successfully! Press Enter to return to menu.");
	Console.ReadLine();
}
