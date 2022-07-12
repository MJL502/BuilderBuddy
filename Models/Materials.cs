using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderBuddy.Models
{
    public class Materials
    {
        [Key]
        public int MaterialID { get; set; }

        public Wall? Wall { get; set; }

        public int WallID { get; set; }

        public decimal Drywall { get; set; }
        public decimal JointCompound { get; set; }
        public decimal JointTape { get; set; }
        public decimal Screws { get; set; }
        public decimal DrywallCost { get; set; }
        public decimal JointCompoundCost { get; set; }
        public decimal JointTapeCost { get; set; }
        public decimal ScrewsCost { get; set; }

    }
}
