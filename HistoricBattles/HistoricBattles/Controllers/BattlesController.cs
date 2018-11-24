using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HistoricBattles.Data;
using HistoricBattles.Models;

namespace HistoricBattles.Controllers
{
    public class BattlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BattlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Battles
        public async Task<IActionResult> Index()
        {
            List<Battle> battles = await _context.Battles.Include(x=>x.Stages).ToListAsync();
           
            return View(battles);
        }



        // GET: Battles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battle = await _context.Battles.Include(x=>x.Stages)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (battle == null)
            {
                return NotFound();
            }

            List<Stage> stages = battle.Stages.ToList();
            return View(stages);
        }
        // GET: Battles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Battles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Localization,Year")] Battle battle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(battle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(battle);
        }

        // GET: Battles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battle = await _context.Battles.FindAsync(id);
            if (battle == null)
            {
                return NotFound();
            }
            return View(battle);
        }

        // POST: Battles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Localization,Year")] Battle battle)
        {
            if (id != battle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(battle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BattleExists(battle.Id))
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
            return View(battle);
        }

        // GET: Battles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battle = await _context.Battles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (battle == null)
            {
                return NotFound();
            }

            return View(battle);
        }

        // POST: Battles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var battle = await _context.Battles.FindAsync(id);
            _context.Battles.Remove(battle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BattleExists(int id)
        {
            return _context.Battles.Any(e => e.Id == id);
        }
    }
}
