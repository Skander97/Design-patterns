using System;
using System.Collections.Generic;
public class TaskManager
{
    private static TaskManager instance;
    private List<Task> tasks;
    
    private TaskManager()
    {
        tasks = new List<Task>();
    }
    
    public static TaskManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new TaskManager();
            }
            return instance;
        }
    }
    
    public void AddTask(Task task)
    {
        tasks.Add(task);
        Console.WriteLine("Tâche ajoutée : " + task.Name);
    }
    
    public void RemoveTask(Task task)
    {
        tasks.Remove(task);
        Console.WriteLine("Tâche supprimée : " + task.Name);
    }
    
    public void PrintAllTasks()
    {
        Console.WriteLine("Liste des tâches :");
        foreach (Task task in tasks)
        {
            Console.WriteLine("- " + task.Name);
        }
    }
}