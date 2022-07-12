using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderBuddy.Models
{
    public class Room
    {

        [Key]
        public int RoomID { get; set; }

        public string? RoomName { get; set; }

        //public Project? Project { get; set; }

        public int ProjectID { get; set; }

        public List<Wall>? Walls { get; set; }

        public decimal? RoomCost { get; set; }
    }
}
