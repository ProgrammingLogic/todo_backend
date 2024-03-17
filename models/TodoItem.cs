namespace todo_backend.Models;

public class TodoItem {
    public long Id {get; set;}
    public string? Name {get; set;}
    public bool isComplete {get; set;}
    public DateTime dueDate {get; set;}
    public DateTime createdDate {get; set;}
}