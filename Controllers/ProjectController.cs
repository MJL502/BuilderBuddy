using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderBuddy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BuilderBuddy.Controllers
{
    public class ProjectController : Controller
    {
        private readonly Context _context;

        public ProjectController(Context context)
        {
            _context = context;
        }

        // GET: Project
        public async Task<IActionResult> Index()
        {
            return _context.Project != null ?
                        View(await _context.Project.ToListAsync()) :
                        Problem("Entity set 'Context.Project'  is null.");

            //query data - build json array - modify View  

            var RoomQuery =
                from p in _context.Set<Project>()
                join r in _context.Set<Room>()
                    on p.ProjectID equals r.ProjectID into grouping
                from r in grouping.DefaultIfEmpty()
                select new { p, r };

            var WallQuery =
                from r in _context.Set<Room>()
                join w in _context.Set<Wall>()
                    on r.RoomID equals w.RoomID into grouping
                from w in grouping.DefaultIfEmpty()
                select new { r, w };

            string RoomJson = JsonConvert.SerializeObject(RoomQuery);
            Console.WriteLine(RoomJson);

            string WallJson = JsonConvert.SerializeObject(WallQuery);
            Console.WriteLine(WallJson);


            /*
                        var ProjectIDS = new List<ProjectID>() {
                            new Student(){ Id = 1, Name="Bill"},
                            new Student(){ Id = 2, Name="Steve"},
                            new Student(){ Id = 3, Name="Ram"},
                            new Student(){ Id = 4, Name="Abdul"}
                        };

                        //get all students whose name is Bill
                        var result = from p in ProjectIDs
                                     where p.ID => 0
                                     select p;

                        foreach (var Project in result)
                            ;


                        int ProjectIDS = new List<int>; 
                        ProjectIDS = "SELECT ProjectID FROM Project"


                        List<int> ProjectIDS = "SELECT ProjectID FROM Project";

                        foreach (int IDNumber in ProjectIDS)
                        {

                        string queryProjectDetails =
                        "SELECT p.ProjectID, p.ProjectName, p.ProjectDate, p.TotalCost, r.RoomName, r.RoomCost, w.WallID, w.Height, w.Length, w.WallCost" +
                        "FROM Project p" +
                        "LEFT JOIN Room r" +
                        "ON p.ProjectID = r.ProjectID" +
                        "LEFT JOIN Wall w" +
                        "ON r.RoomID = w.RoomID" +
                        "WHERE p.ProjectID = 1; ";

                        //NEED to make the project ID feed dynamically

                        string stringjson = JsonConvert.SerializeObject(queryProjectDetails);
                        Console.WriteLine(stringjson);




                        /* THIS QUERY WORKS
                        from Project
                        SELECT p.ProjectID, p.ProjectName, p.ProjectDate, p.TotalCost, r.RoomName, r.RoomCost, w.WallID, w.Height, w.Length, w.WallCost
                        FROM Project p
                        LEFT JOIN Room r
                        ON p.ProjectID = r.ProjectID
                        LEFT JOIN Wall w
                        ON r.RoomID = w.RoomID
                        WHERE p.ProjectID = 1;
                        */
        }


        // GET: Project/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Project == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Project/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectID,ProjectName,ProjectDate,TotalCost")] Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Project/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Project == null)
            {
                return NotFound();
            }

            var project = await _context.Project.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectID,ProjectName,ProjectDate,TotalCost")] Project project)
        {
            if (id != project.ProjectID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ProjectID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Project/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Project == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Project == null)
            {
                return Problem("Entity set 'Context.Project'  is null.");
            }
            var project = await _context.Project.FindAsync(id);
            if (project != null)
            {
                _context.Project.Remove(project);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
          return (_context.Project?.Any(e => e.ProjectID == id)).GetValueOrDefault();
        }
    }
}
