using BuilderBuddy.Models;

namespace BuilderBuddy.Repository
{

    public interface IRepository
    {
        public IEnumerable<Project> AddAllProjectWalls();


    }

    public class QueryRepository : IRepository
    {
        public IEnumerable<Project> AddAllProjectWalls()
        {
            var totalCost = from p in Project
                            from w in Wall
                            where p.ProjectID == w.ProjectID
                            select w.WallCost;

            return totalCost.Sum();
        }
    }
}
