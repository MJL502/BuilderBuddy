using BuilderBuddy.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BuilderBuddy.Models;

public class Queries : DbContext

{

    private readonly Context _context;

    public string? ProjectName { get; set; }

    public decimal DrywallSheets { get; set; }

    public decimal DrywallCost { get; set; }

    public decimal PoundsOfJointCompound { get; set; }

    public decimal JointCompoundCost { get; set; }

    public decimal RollsOfTape { get; set; }

    public decimal JointTapeCost { get; set; }

    public decimal BoxesOfScrews { get; set; }

    public decimal ScrewsCost { get; set; }

    public decimal TotalCost 
    {
        get
        {
            var query =
            from P in _context.Project
            join W in _context.Wall on P.ProjectID equals W.ProjectID into FinalProject

            from item in FinalProject
            where (item.ProjectID != null) && (item.ProjectID == P.ProjectID)
            select item.WallCost;

            decimal sum = query.Sum();
            return sum;
        }
        set
        { 
        }
    }

    /*
    { 
        get
        {
            var query =
            from P in _context.Project
            join W in _context.Wall on P.ProjectID equals W.ProjectID into FinalProject
            select new { Name = item == null ? "Nothing!" : item.Name, P.ProjectID = W.ProjectID };

            Console.WriteLine("LeftOuterJoin2: {0} items in 1 group", query.Count());
            // Store the count of total items
            int totalItems = 0;

            Console.WriteLine("Left Outer Join 2:");

            // Groups have been flattened.
            foreach (var item in query)
            {
                totalItems++;
                Console.WriteLine("{0,-10}{1}", item.Name, item.CategoryID);
            }
            Console.WriteLine("LeftOuterJoin2: {0} items in 1 group", totalItems);
        }
            
            foreach (decimal w in query)
            {
                StartingCost = w;
            }

   
            foreach (var IndividualWallCost in query)
            {
                StartingCost = Convert.ToDecimal(StartingCost) + Convert.ToDecimal(IndividualWallCost);
            }
           

            return StartingCost;
        }
   
    }
     */
}