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

        public Wall thisWall = new();

        public decimal Drywall 
        { 
            get
            {
                decimal sheetsAcross = Math.Ceiling(decimal.Parse(thisWall.Length.ToString()));
                decimal topSheet = thisWall.Height % 8;
                decimal fullSheets = Math.Floor(decimal.Parse(thisWall.Height.ToString()) / 8);
                decimal totalSheets = (sheetsAcross * fullSheets) + (sheetsAcross * (Math.Floor(8 / topSheet) * 4));

                return totalSheets;
            }
        }

        public decimal DrywallFormulaTwo
        {
            get
            {
                decimal baseSheets = Math.Ceiling(thisWall.Area / 32);
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
                decimal poundsOfJointCompound = Math.Ceiling(jointCompoundPerSF * thisWall.Area);
                return poundsOfJointCompound;
            }
        }

        public decimal JointTape
        {
            get
            {
                decimal feetOfTape = Drywall * 16;
                decimal rollsofTape = Math.Ceiling(feetOfTape / 500);
                return rollsofTape;
            }
        }

        public decimal Screws 
        {
            get 
            { 
                return thisWall.Area;
            }
        }


        public decimal DrywallPrice = 15;
        public decimal JointCompoundPrice = 9;
        public decimal JointTapePrice = 5;
        public decimal ScrewsPrice = 15;


        public decimal DrywallCost
        {
            get 
            {
                return Drywall * DrywallPrice;
            }
        }

        public decimal JointCompoundCost
        {
            get
            {
                return JointCompound * JointCompoundPrice;
            }
        }


        public decimal JointTapeCost
        {
            get
            {
                return JointTape * JointTapePrice;
            }
        }

        public decimal ScrewsCost
        {
            get
            {
                return Screws * ScrewsPrice;
            }
        }

    }
}
