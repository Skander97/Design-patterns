using System;
using System.Collections.Generic;
public class TaskObserver
{
    public void NotifyTaskUpdated(Task task)
    {
        Console.WriteLine("Tâche mise à jour : " + task.Name);
    }
}