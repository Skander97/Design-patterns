using System;

public class ExternalTask
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    // Constructeur de la classe ExternalTask
    public ExternalTask(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }

   
}