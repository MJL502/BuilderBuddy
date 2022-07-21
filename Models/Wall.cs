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

        //public decimal WallCost { get; set; }

        /*
        public decimal DrywallFormulaTwo
        {
            get
            {
                decimal sheetsAcross = Math.Ceiling(decimal.Parse(Length.ToString()));
                decimal topSheet = Height % 8;
                decimal fullSheets = Math.Floor(decimal.Parse(Height.ToString()) / 8);
                decimal totalSheets = (sheetsAcross * fullSheets) + (sheetsAcross * (Math.Floor(8 / topSheet) * 4));

                return totalSheets;
            }
        }
        */

        public decimal Drywall
        {
            get
            {
                decimal baseSheets = Math.Ceiling(Area / 32);
                decimal overage = 1.1m;
                decimal totalSheets = Math.Ceiling(baseSheets * overage);

                return totalSheets;
            }
        }

        public decimal JointCompound
        {
            get
            {
                decimal jointCompoundPerSF = 0.053m;
                decimal poundsOfJointCompound = Math.Ceiling(jointCompoundPerSF * Area);
                return poundsOfJointCompound;
            }
        }

        public decimal JointTape
        {
            get
            {
                decimal feetOfTape = Drywall * 16;
                decimal rollsofTape = feetOfTape / 500m * 1.1m;
                return rollsofTape;
            }
        }

        public decimal Screws
        {
            get
            {
                return Math.Ceiling(Area * 1.1m);
            }
        }

        Materials materialPriceList = new Materials();

        public decimal DrywallCost
        {
            get
            {
                return Drywall * materialPriceList.DrywallPrice;
            }
        }

        public decimal JointCompoundCost
        {
            get
            {
                return JointCompound * materialPriceList.JointCompoundPrice;
            }
        }


        public decimal JointTapeCost
        {
            get
            {
                return JointTape * materialPriceList.JointTapePrice;
            }
        }

        public decimal ScrewsCost
        {
            get
            {
                return Math.Ceiling(Screws * materialPriceList.ScrewsPrice);
            }
        }

        public decimal WallCost
        {
            get
            {
                return DrywallCost + JointCompoundCost + JointTapeCost + ScrewsCost;
            }
        }

        /*
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
