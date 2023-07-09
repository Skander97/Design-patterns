using System;
using System.Collections.Generic;
public class TaskBuilder
{
    private Task task;
    
    public TaskBuilder()
    {
        task = new Task("", "", DateTime.Now); // Passer des valeurs par défaut ou spécifiques
    }
    
    public TaskBuilder SetName(string name)
    {
        task.Name = name;
        return this;
    }
    
    public TaskBuilder SetDescription(string description)
    {
        task.Description = description;
        return this;
    }
    
    public TaskBuilder SetDeadline(DateTime deadline)
    {
        task.Deadline = deadline;
        return this;
    }
    
    public Task Build()
    {
        return task;
    }
}