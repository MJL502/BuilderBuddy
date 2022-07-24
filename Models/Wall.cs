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

        private Context _context;

        /*
        public string ProjectName
        {
            get
            {     
                var queryProjectName =
                from P in _context.Project
                from W in _context.Wall
                where P.ProjectID == W.ProjectID
                select P.ProjectName;

                return queryProjectName.ToString();
                
            }
             set
            {
            }
        }      
        */

        public int Height { get; set; }

        public int Length { get; set; }

        public decimal Area
        {
            get 
            {
                decimal area = Height * Length;
                return area;
            }
            set 
            { 
            }
        }


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
            set
            {
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
            set 
            { 
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
            set
            {
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
            set
            {
            }
        }

        public decimal Screws
        {
            get
            {
                return Math.Ceiling(Area * 1.1m);
            }
            set
            { 
            }
        }

        Materials materialPriceList = new Materials();

        public decimal DrywallCost
        {
            get
            {
                return Drywall * materialPriceList.DrywallPrice;
            }
            set
            { 
            }
        }

        public decimal JointCompoundCost
        {
            get
            {
                return JointCompound * materialPriceList.JointCompoundPrice;
            }
            set
            { 
            }
        }


        public decimal JointTapeCost
        {
            get
            {
                return JointTape * materialPriceList.JointTapePrice;
            }
            set
            { 
            }
        }

        public decimal ScrewsCost
        {
            get
            {
                return Math.Ceiling(Screws * materialPriceList.ScrewsPrice);
            }
            set
            { 
            }
        }

        public decimal WallCost
        {
            get
            {
                return DrywallCost + JointCompoundCost + JointTapeCost + ScrewsCost;
            }
            set
            { 
            }
        }
    }
}
