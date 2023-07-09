using System;
using System.Collections.Generic;

public class CompositeTask : Task
{
    private List<Task> subTasks;
    
    public CompositeTask(string name, string description, DateTime deadline)
        : base(name, description, deadline)
    {
        subTasks = new List<Task>();
    }
    
    public void AddTask(Task task)
    {
        subTasks.Add(task);
        Console.WriteLine("Sous-tâche ajoutée à la tâche composite : " + task.Name);
    }
    
    public void RemoveTask(Task task)
    {
        subTasks.Remove(task);
        Console.WriteLine("Sous-tâche supprimée de la tâche composite : " + task.Name);
    }
    
    public List<Task> GetSubTasks()
    {
        return subTasks;
    }
    
    public void PerformOperationOnSubTasks()
    {
        foreach (Task subTask in subTasks)
        {
            subTask.PerformOperation();
        }
    }
    
    // Autres méthodes et propriétés de la classe CompositeTask
    // ...
}