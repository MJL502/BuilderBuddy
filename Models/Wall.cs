using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderBuddy.Models
{
    public class Wall
    {

        [Key]
        public int WallID { get; set; }

        public Project? Project { get; set; }

        public int ProjectID { get; set; }

        public int Height { get; set; }
        public int Length { get; set; }

        public decimal WallArea()
        {
            decimal area = Height * Length;
            return area;
        }

        public decimal Area => WallArea();

        public decimal WallCost { get; set; }

        /*
        public Materials materials = new Materials();

        public decimal WallCost
        {
            get
            {
                return materials.DrywallCost + materials.JointCompoundCost + materials.JointTapeCost + materials.ScrewsCost;
            }
        }


        public decimal Drywall
        {
            get
            {
                return materials.Drywall;
            }
        }

        public decimal JointCompound
        {
            get
            {
                return materials.JointCompound;
            }
        }

        public decimal JointTape
        {
            get
            {
                return materials.JointTape;
            }
        }

        public decimal Screws
        {
            get
            {
                return materials.Screws;
            }
        }

        */
    }
}
