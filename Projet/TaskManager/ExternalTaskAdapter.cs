using System;
using System.Collections.Generic;

public class ExternalTaskAdapter : Task
{
    private ExternalTask externalTask;
    
    public ExternalTaskAdapter(ExternalTask externalTask, string name, string description, DateTime deadline)
        : base(name, description, deadline)
    {
        this.externalTask = externalTask;
        AdaptExternalTask();
    }
    
    private void AdaptExternalTask()
    {
        // Adaptation des données externes à la classe Task interne
        Name = externalTask.Title;
        Description = externalTask.Description;
        Deadline = externalTask.DueDate;
        
        Console.WriteLine("Tâche externe adaptée : " + Name);
    }
}