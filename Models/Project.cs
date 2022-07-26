using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BuilderBuddy.Models;

public class Project

{
    [Key]
    public int ProjectID { get; set; }

    public string? ProjectName { get; set; }

    public DateTime ProjectDate { get; set; }

    public List<Wall>? Walls { get; set; }

    public decimal DrywallSheets { get; set; }

    public decimal DrywallCost { get; set; }

    public decimal PoundsOfJointCompound { get; set; }

    public decimal JointCompoundCost { get; set; }

    public decimal RollsOfTape { get; set; }

    public decimal JointTapeCost { get; set; }

    public decimal BoxesOfScrews { get; set; }

    public decimal ScrewsCost { get; set; }


    private readonly Context _context;

    private decimal StartingCost = 0m;

    public decimal TotalCost { get; set; }

    
}