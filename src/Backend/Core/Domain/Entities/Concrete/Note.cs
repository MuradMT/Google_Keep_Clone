namespace Domain.Entities.Concrete;

public class Note : IEntity
{
     public required string Id { get; set; }

     public string AppUserId { get; set; }

     public AppUser AppUser { get; set; }

     public string? Title { get; set; } = string.Empty;

     public DateTime Created { get; set; } = DateTime.Now;

     public DateTime Edited { get; set; } = DateTime.Now;

     public List<Item> Items { get; set; } = new List<Item>();

     public List<Label> Labels { get; set; } = new List<Label>();

     public List<Image> Images { get; set; } = new List<Image>();

     public List<Drawing> Drawings { get; set; } = new List<Drawing>();

     public List<Collaborator> Collaborators { get; set; } = new List<Collaborator>();

     public List<Reminder> Reminders { get; set; } = new List<Reminder>();

     public bool isDeleted { get; set; }

     public bool isArchived { get; set; }
}
