namespace Domain.Entities.Concrete;

public class Item:IEntity
{
    public required string Id { get; set; }

    public string NoteId { get; set; }
    
    public Note Note { get; set; }

    public string? Content { get; set; }=string.Empty;

    public bool isCompleted { get; set; }

    

    
}
