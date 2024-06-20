namespace Domain.Entities.Concrete;

public class Drawing:IEntity
{
    public required string Id { get; set; }

    public string NoteId { get; set; }

    public Note Note { get; set; }

    public required string Url { get; set; }
}
