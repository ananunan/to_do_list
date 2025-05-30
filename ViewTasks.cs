using System;

void ViewTasks()
{
	Console.Clear();
	Console.WriteLine("=== ⋆｡°✩ YOUR TASKS ⋆｡°✩ ===\n");

	if (tasks.Count == 0)
	{
		Console.WriteLine("No tasks available.");
		Console.ReadLine();
		return;
	}

	int rainbowIndex = 0;
	ConsoleColor[] rainbowColors = {
		ConsoleColor.Red, ConsoleColor.Yellow,
		ConsoleColor.Green, ConsoleColor.Cyan,
		ConsoleColor.Blue, ConsoleColor.Magenta
	};

	foreach (var task in tasks.OrderByDescending(t => t.IsPinned))
	{
		// Número colorido em arco-íris
		Console.ForegroundColor = rainbowColors[rainbowIndex % rainbowColors.Length];
		Console.Write($"#{task.Id} ");
		rainbowIndex++;

		Console.ResetColor();

		// Status: concluído ou não
		string status = task.IsCompleted ? "✅" : "❌";

		// Prioridade com cor
		switch (task.Priority)
		{
			case Priority.High:
				Console.ForegroundColor = ConsoleColor.Red;
				break;
			case Priority.Medium:
				Console.ForegroundColor = ConsoleColor.Yellow;
				break;
			case Priority.Low:
				Console.ForegroundColor = ConsoleColor.Green;
				break;
		}

		string priorityText = task.Priority.ToString();

		// Mostrar tarefa
		Console.Write($"[{priorityText}] ");
		Console.ResetColor();

		// Título e descrição
		Console.Write($"{status} {task.Title}");

		if (!string.IsNullOrWhiteSpace(task.Description))
			Console.Write($" - {task.Description}");
		// Pin
		if (task.IsPinned)
			Console.Write(" 📌");
		Console.WriteLine();
	}
	Console.WriteLine("\nPress Enter to return to the menu.");
	Console.ReadLine();
}
