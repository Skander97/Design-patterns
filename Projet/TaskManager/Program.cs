using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Création d'un gestionnaire de tâches
        TaskManager taskManager = TaskManager.Instance;

        // Création de tâches avec le TaskBuilder
        TaskBuilder taskBuilder = new TaskBuilder();
        Task task1 = taskBuilder.SetName("Tâche 1").SetDescription("Description de la tâche 1").SetDeadline(DateTime.Now.AddDays(2)).Build();
        Task task2 = taskBuilder.SetName("Tâche 2").SetDescription("Description de la tâche 2").SetDeadline(DateTime.Now.AddDays(3)).Build();
        
        // Ajout des tâches au gestionnaire
        taskManager.AddTask(task1);
        taskManager.AddTask(task2);
        
        // Création d'une tâche externe
        ExternalTask externalTask = new ExternalTask("Tâche externe", "Description de la tâche externe", DateTime.Now.AddDays(5));
        
        // Adaptation de la tâche externe avec l'adaptateur
        ExternalTaskAdapter adapter = new ExternalTaskAdapter(externalTask, "Tâche adaptée", "Description de la tâche adaptée", DateTime.Now);
        Task adaptedTask = adapter;
        
        // Ajout de la tâche adaptée au gestionnaire
        taskManager.AddTask(adaptedTask);
        
        // Création d'une tâche composite
        CompositeTask compositeTask = new CompositeTask("Tâche composite", "Description de la tâche composite", DateTime.Now);
        compositeTask.AddTask(task1);
        compositeTask.AddTask(task2);
        
        // Exécution d'une opération sur les sous-tâches de la tâche composite
        compositeTask.PerformOperationOnSubTasks();
        
        // Récupération et affichage des sous-tâches de la tâche composite
        Console.WriteLine("Sous-tâches de la tâche composite :");
        foreach (Task subTask in compositeTask.GetSubTasks())
        {
            Console.WriteLine(subTask.Name);
        }
        
        // Création d'un observateur de tâches
        TaskObserver taskObserver = new TaskObserver();
        
        // Notification d'une mise à jour de tâche à l'observateur
        taskObserver.NotifyTaskUpdated(task1);
        
        // Affichage de toutes les tâches gérées
        taskManager.PrintAllTasks();
    }
}