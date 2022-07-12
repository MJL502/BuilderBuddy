using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderBuddy.Models;

public class Project

{
    [Key]
    public int ProjectID { get; set; }

    public string? ProjectName { get; set; }

    public DateTime ProjectDate { get; set; }

    public List<Room>? Rooms { get; set; }

    public decimal? TotalCost { get; set; }

}