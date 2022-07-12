using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderBuddy.Models
{
    public class Wall
    {

        [Key]
        public int WallID { get; set; }

        public Room? Room { get; set; }

        public int RoomID { get; set; }

        public int Height { get; set; }

        public int Length { get; set; }

        public decimal? WallCost { get; set; }

        public List<Materials>? MaterialsNeeded { get; set; }


    }

    public enum WallHeights
    {
        Eight,
        Nine,
        Ten,
        Twelve,
        Fourteen,
        Sixteen,
        Twenty
    }
}
