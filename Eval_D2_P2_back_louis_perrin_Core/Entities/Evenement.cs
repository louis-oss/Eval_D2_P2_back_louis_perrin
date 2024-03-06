namespace Eval_D2_P2_back_louis_perrin_Core.Entities;

public class Evenement
{
    public Evenement(string? title, string? description, string? location, DateTime date)
    {
        Title = title;
        Description = description;
        Location = location;
        Date = date;
    }

    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public DateTime Date { get; set; }

}
