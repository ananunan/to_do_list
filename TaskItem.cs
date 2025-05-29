using System;

public enum Priority
{
	Urgent,
	Normal,
	Later
}

public class TaskItem
{
	public int ID { get; set; }
	public string Title { get; set; }
	public string? Description { get; set; }
	public bool IsCompleted { get; set; }
	public Priority Priority { get; set; }
	public bool IsPinned { get; set; }
	public DateTime CreatedAt { get; set; }

	public TaskItem(int id, string title, string? description, Priority Priority)
	{
		ID = id
		Title = title
		Description = description
		IsCompleted = false;
		Priority = priority;
		IsPinned = false;
		CreatedAt = DataTime.Now;
	}
}
