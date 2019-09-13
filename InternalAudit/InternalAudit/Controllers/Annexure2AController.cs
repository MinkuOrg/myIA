using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternalAudit.Models;
using InternalAudit.DTO;

namespace InternalAudit.Controllers
{
    public class Annexure2AController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public Annexure2AController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: Annexure2A
        public async Task<IActionResult> Index()
        {
            return View(await _context.Annexure2FormA.ToListAsync());
        }

        // GET: Annexure2A/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure2FormA = await _context.Annexure2FormA
                .FirstOrDefaultAsync(m => m.Annexure2FormArecNo == id);
            if (annexure2FormA == null)
            {
                return NotFound();
            }

            return View(annexure2FormA);
        }

        // GET: Annexure2A/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Annexure2A/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Annexure2FormArecNo,WeightMeasurementLabour,Pendency2013To14,Pendency2014To15,Pendency2015To16,Pendency2016To17")] Annexure2FormA annexure2FormA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(annexure2FormA);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure2A" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure2A" };
                }
            }
            return View(annexure2FormA);


           
        }

        // GET: Annexure2A/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure2FormA = await _context.Annexure2FormA.FindAsync(id);
            if (annexure2FormA == null)
            {
                return NotFound();
            }
            return View(annexure2FormA);
        }

        // POST: Annexure2A/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Annexure2FormArecNo,WeightMeasurementLabour,Pendency2013To14,Pendency2014To15,Pendency2015To16,Pendency2016To17")] Annexure2FormA annexure2FormA)
        {

            if (id != annexure2FormA.Annexure2FormArecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(annexure2FormA);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure2A" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure2A" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Annexure2FormAExists(annexure2FormA.Annexure2FormArecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(annexure2FormA);
           
        }

        // GET: Annexure2A/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure2FormA = await _context.Annexure2FormA
                .FirstOrDefaultAsync(m => m.Annexure2FormArecNo == id);
            if (annexure2FormA == null)
            {
                return NotFound();
            }

            return View(annexure2FormA);
        }

        // POST: Annexure2A/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var annexure2FormA = await _context.Annexure2FormA.FindAsync(id);
            _context.Annexure2FormA.Remove(annexure2FormA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Annexure2FormAExists(int id)
        {
            return _context.Annexure2FormA.Any(e => e.Annexure2FormArecNo == id);
        }
    }
}
