using System;

void DeleteTask()
{
	Console.Clear();
	Console.WriteLine("=== ⋆｡°✩ DELETE TASK ⋆｡°✩ ===");

	if (tasks.Count == 0)
	{
		Console.WriteLine("No tasks to delete.");
		Console.ReadLine();
		return;
	}
	foreach (var task in tasks)
		Console.WriteLine($"{task.Id}: {task.Title}");
	Console.Write("\nEnter the ID of the task to delete: ");
	string? input = Console.ReadLine();

	if (int.TryParse(input, out int idToDelete))
	{
		TaskItem? taskToRemove = tasks.FirstOrDefault(t => t.Id == idToDelete);

		if (taskToRemove != null)
		{
			tasks.Remove(taskToRemove);
			Console.WriteLine("Task deleted successfully.");
		}
		else
			Console.WriteLine("Task not found.");
	}
	else
		Console.WriteLine("Invalid ID format.");
	Console.WriteLine("Press Enter to return to the menu.");
	Console.ReadLine();
}
