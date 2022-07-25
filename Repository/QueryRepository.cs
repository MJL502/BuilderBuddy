using BuilderBuddy.Models;
using System.Linq;

namespace BuilderBuddy.Repository
{

    public interface IRepository
    {
        public IEnumerable<Project> AddAllProjectWalls();

        public IEnumerable<Project> GetProjectName();


    }

    public class QueryRepository : IRepository
    {
        private readonly Context _context;
        public IEnumerable<Project> AddAllProjectWalls()
        {
            var totalCost = from p in _context.Project
                            from w in _context.Wall
                            where p.ProjectID == w.ProjectID
                            select w.WallCost;

            return (IEnumerable<Project>)_context.Wall.ToList();
        }

        public IEnumerable<Project> GetProjectName()
        {
            var projectName = from p in _context.Project
                            from w in _context.Wall
                            where p.ProjectID == w.ProjectID
                            select p.ProjectName;

            return (IEnumerable<Project>)projectName;
        }

        /*
        public IEnumerable<Project> AddAllProjectWalls()
        {
            var totalCost = from p in _context.Project
                            from w in _context.Wall
                            where p.ProjectID == w.ProjectID
                            select w.WallCost;

            return _context.Wall.Where(w => w.ProjectID == ProjectID).Select(x => x.WallCost).Sum();
        }
        */
    }
}
