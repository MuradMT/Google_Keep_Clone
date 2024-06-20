using Domain.Enums;

namespace Domain.Entities.Concrete;

public class Repeat:IEntity
{
    public int Every_Time { get; set; }

    public Repetation Type { get; set; }

    public int End_Occurence { get; set; }

    public DateOnly End_Date { get; set; }=DateOnly.FromDateTime(DateTime.Now);

}
