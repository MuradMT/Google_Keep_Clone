namespace Domain.Entities.Concrete;

public class Reminder:IEntity
{
    public required string Id { get; set; }

    public string NoteId { get; set; }

    public Note Note { get; set; }

    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now).AddDays(1);

    public  TimeOnly Time { get; set; }=new TimeOnly(8,0,0);
    
    public Repeat? Repeat { get; set; }
    
}
