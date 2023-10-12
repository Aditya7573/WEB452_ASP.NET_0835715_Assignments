using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aditya_Tie.Data;
using Aditya_Tie.Models;

namespace Aditya_Tie.Controllers
{
    public class TiesController : Controller
    {
        private readonly TieContext _context;

        public TiesController(TieContext context)
        {
            _context = context;
        }

       

        // GET: Ties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tie = await _context.Tie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tie == null)
            {
                return NotFound();
            }

            return View(tie);
        }

        // GET: Ties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Design,ReleaseDate,Material,Price,IsAvailable,Rating")] Tie tie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tie);
        }

        // GET: Ties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tie = await _context.Tie.FindAsync(id);
            if (tie == null)
            {
                return NotFound();
            }
            return View(tie);
        }

        // POST: Ties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Design,ReleaseDate,Material,Price,IsAvailable,Rating")] Tie tie)
        {
            if (id != tie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TieExists(tie.Id))
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
            return View(tie);
        }

        // GET: Ties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tie = await _context.Tie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tie == null)
            {
                return NotFound();
            }

            return View(tie);
        }

        // POST: Ties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tie = await _context.Tie.FindAsync(id);
            _context.Tie.Remove(tie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index(string tieMaterial, string searchString)
        {
            // Use LINQ to get list of tie materials.
            IQueryable<string> materialQuery = from t in _context.Tie
                                               orderby t.Material
                                               select t.Material;

            var ties = from t in _context.Tie
                       select t;

            if (!string.IsNullOrEmpty(searchString))
            {
                ties = ties.Where(s => s.Design.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(tieMaterial))
            {
                ties = ties.Where(x => x.Material == tieMaterial);
            }

            var tieMaterialVM = new TieMaterialViewModel
            {
                Materials = new SelectList(await materialQuery.Distinct().ToListAsync()),
                Ties = await ties.ToListAsync()
            };

            return View(tieMaterialVM);
        }


        private bool TieExists(int id)
        {
            return _context.Tie.Any(e => e.Id == id);
        }

      
    }
}
