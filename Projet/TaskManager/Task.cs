using System;

public class Task
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    
    public Task(string name, string description, DateTime deadline)
    {
        Name = name;
        Description = description;
        Deadline = deadline;
    }
    
    public virtual void PerformOperation()
    {
        Console.WriteLine("Opération effectuée sur la tâche : " + Name);
    }
    
    
}