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
    public class RtiPdlsController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public RtiPdlsController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: RtiPdls
        public async Task<IActionResult> Index()
        {
            return View(await _context.RtiPdl.ToListAsync());
        }

        // GET: RtiPdls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rtiPdl = await _context.RtiPdl
                .FirstOrDefaultAsync(m => m.RtiPdlRecNo == id);
            if (rtiPdl == null)
            {
                return NotFound();
            }

            return View(rtiPdl);
        }

        // GET: RtiPdls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RtiPdls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RtiPdlRecNo,Details,OriginalPetitions,Appealpetitions,OriginalAppealPetitions,Total")] RtiPdl rtiPdl)
        {

            if (ModelState.IsValid)
            {
                _context.Add(rtiPdl);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "RtiPdls" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "RtiPdls" };
                }

            }
            return View(rtiPdl);






            //if (ModelState.IsValid)
            //{
            //    _context.Add(rtiPdl);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(rtiPdl);
        }

        // GET: RtiPdls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rtiPdl = await _context.RtiPdl.FindAsync(id);
            if (rtiPdl == null)
            {
                return NotFound();
            }
            return View(rtiPdl);
        }

        // POST: RtiPdls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RtiPdlRecNo,Details,OriginalPetitions,Appealpetitions,OriginalAppealPetitions,Total")] RtiPdl rtiPdl)
        {
            if (id != rtiPdl.RtiPdlRecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rtiPdl);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "RtiPdls" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "RtiPdls" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RtiPdlExists(rtiPdl.RtiPdlRecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            return View(rtiPdl);
        }

        // GET: RtiPdls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rtiPdl = await _context.RtiPdl
                .FirstOrDefaultAsync(m => m.RtiPdlRecNo == id);
            if (rtiPdl == null)
            {
                return NotFound();
            }

            return View(rtiPdl);
        }

        // POST: RtiPdls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rtiPdl = await _context.RtiPdl.FindAsync(id);
            _context.RtiPdl.Remove(rtiPdl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RtiPdlExists(int id)
        {
            return _context.RtiPdl.Any(e => e.RtiPdlRecNo == id);
        }


    }
}
