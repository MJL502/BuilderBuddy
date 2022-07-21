using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderBuddy.Models;

public class Project

{
    [Key]
    public int ProjectID { get; set; }

    public string? ProjectName { get; set; }

    public DateTime ProjectDate { get; set; }

    public List<Wall>? Walls { get; set; }

    private readonly Context _context;

    private decimal StartingCost = 0m;
    public decimal? TotalCost 
    { 
        get
        {
            var query =
            from P in _context.Project
            join W in _context.Wall on P.ProjectID equals W.ProjectID
            where W.WallCost > 0
            select new
            {
                IndividualWallCost = W.WallCost
            };
            foreach (var IndividualWallCost in query)
            {
                StartingCost = Convert.ToDecimal(StartingCost) + Convert.ToDecimal(IndividualWallCost);
            }

            return StartingCost;
        }
    }

}