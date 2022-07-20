using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuilderBuddy.Models;

namespace BuilderBuddy.Controllers
{
    public class WallController : Controller
    {
        private readonly Context _context;

        public WallController(Context context)
        {
            _context = context;
        }

        // GET: Wall
        public async Task<IActionResult> Index()
        {
              return _context.Wall != null ? 
                          View(await _context.Wall.ToListAsync()) :
                          Problem("Entity set 'Context.Wall'  is null.");
        }

        // GET: Wall/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Wall == null)
            {
                return NotFound();
            }

            var wall = await _context.Wall
                .FirstOrDefaultAsync(m => m.WallID == id);
            if (wall == null)
            {
                return NotFound();
            }

            return View(wall);
        }

        // GET: Wall/Create
        public IActionResult Create()
        {
            ViewBag.ProjectID = new SelectList(_context.Project, "ProjectID", "ProjectName");
            return View();
        }

        // POST: Wall/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WallID,Height,Length,WallCost,ProjectID")] Wall wall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.ProjectID = new SelectList(_context.Project, "ProjectID", "ProjectName", wall.ProjectID);
            return View(wall);
        }

        // GET: Wall/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Wall == null)
            {
                return NotFound();
            }

            var wall = await _context.Wall.FindAsync(id);
            if (wall == null)
            {
                return NotFound();
            }
            return View(wall);
        }

        // POST: Wall/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WallID,Height,Length,WallCost,ProjectID")] Wall wall)
        {
            if (id != wall.WallID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WallExists(wall.WallID))
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
            return View(wall);
        }

        // GET: Wall/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Wall == null)
            {
                return NotFound();
            }

            var wall = await _context.Wall
                .FirstOrDefaultAsync(m => m.WallID == id);
            if (wall == null)
            {
                return NotFound();
            }

            return View(wall);
        }

        // POST: Wall/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Wall == null)
            {
                return Problem("Entity set 'Context.Wall'  is null.");
            }
            var wall = await _context.Wall.FindAsync(id);
            if (wall != null)
            {
                _context.Wall.Remove(wall);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WallExists(int id)
        {
          return (_context.Wall?.Any(e => e.WallID == id)).GetValueOrDefault();
        }
    }
}
