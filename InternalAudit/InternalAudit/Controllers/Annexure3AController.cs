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
    public class Annexure3AController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public Annexure3AController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: Annexure3A
        public async Task<IActionResult> Index()
        {
            return View(await _context.Annexure3FormA.ToListAsync());
        }

        // GET: Annexure3A/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure3FormA = await _context.Annexure3FormA
                .FirstOrDefaultAsync(m => m.Annexure3FormArecNo == id);
            if (annexure3FormA == null)
            {
                return NotFound();
            }

            return View(annexure3FormA);
        }

        // GET: Annexure3A/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Annexure3A/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Annexure3FormArecNo,AdministrativeDepartment,InstitutionDetails,Pendency2013To14,Pendency2014To15,Pendency2015To16,Pendency2016To17")] Annexure3FormA annexure3FormA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(annexure3FormA);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure3A" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure3A" };
                }
            }
            return View(annexure3FormA);
             
        }

        // GET: Annexure3A/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure3FormA = await _context.Annexure3FormA.FindAsync(id);
            if (annexure3FormA == null)
            {
                return NotFound();
            }
            return View(annexure3FormA);
        }

        // POST: Annexure3A/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Annexure3FormArecNo,AdministrativeDepartment,InstitutionDetails,Pendency2013To14,Pendency2014To15,Pendency2015To16,Pendency2016To17")] Annexure3FormA annexure3FormA)
        {
            if (id != annexure3FormA.Annexure3FormArecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(annexure3FormA);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure3A" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure3A" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Annexure3FormAExists(annexure3FormA.Annexure3FormArecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(annexure3FormA);
        }

        // GET: Annexure3A/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure3FormA = await _context.Annexure3FormA
                .FirstOrDefaultAsync(m => m.Annexure3FormArecNo == id);
            if (annexure3FormA == null)
            {
                return NotFound();
            }

            return View(annexure3FormA);
        }

        // POST: Annexure3A/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var annexure3FormA = await _context.Annexure3FormA.FindAsync(id);
            _context.Annexure3FormA.Remove(annexure3FormA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Annexure3FormAExists(int id)
        {
            return _context.Annexure3FormA.Any(e => e.Annexure3FormArecNo == id);
        }
    }
}
