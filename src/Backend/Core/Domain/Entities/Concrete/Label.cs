namespace Domain.Entities.Concrete;

public class Label:IEntity
{ 
    public required string Id { get; set; }

    public string NoteId { get; set; }

    public Note Note { get; set; }

    public required string Detail { get; set; }
}
