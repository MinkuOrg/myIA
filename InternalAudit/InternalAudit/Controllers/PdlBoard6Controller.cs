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
    public class PdlBoard6Controller : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public PdlBoard6Controller(auditinternalContext context)
        {
            _context = context;
        }

        // GET: PdlBoard6
        public async Task<IActionResult> Index()
        {
            return View(await _context.PdlBoardForm6.ToListAsync());
        }

        // GET: PdlBoard6/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdlBoardForm6 = await _context.PdlBoardForm6
                .FirstOrDefaultAsync(m => m.PdlBoradForm6RecNo == id);
            if (pdlBoardForm6 == null)
            {
                return NotFound();
            }

            return View(pdlBoardForm6);
        }

        // GET: PdlBoard6/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PdlBoard6/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PdlBoradForm6RecNo,NameDesignation,StaffMeeting,OfficeWorkBillWork,AuditWork,PucWork,PensionCertificationWork,OtherDuty,GovtHoliday,LeaveAvailed,TotalDays")] PdlBoardForm6 pdlBoardForm6)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pdlBoardForm6);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pdlBoardForm6);
        }

        // GET: PdlBoard6/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdlBoardForm6 = await _context.PdlBoardForm6.FindAsync(id);
            if (pdlBoardForm6 == null)
            {
                return NotFound();
            }
            return View(pdlBoardForm6);
        }

        // POST: PdlBoard6/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PdlBoradForm6RecNo,NameDesignation,StaffMeeting,OfficeWorkBillWork,AuditWork,PucWork,PensionCertificationWork,OtherDuty,GovtHoliday,LeaveAvailed,TotalDays")] PdlBoardForm6 pdlBoardForm6)
        {
            if (id != pdlBoardForm6.PdlBoradForm6RecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pdlBoardForm6);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PdlBoardForm6Exists(pdlBoardForm6.PdlBoradForm6RecNo))
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
            return View(pdlBoardForm6);
        }

        // GET: PdlBoard6/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdlBoardForm6 = await _context.PdlBoardForm6
                .FirstOrDefaultAsync(m => m.PdlBoradForm6RecNo == id);
            if (pdlBoardForm6 == null)
            {
                return NotFound();
            }

            return View(pdlBoardForm6);
        }

        // POST: PdlBoard6/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pdlBoardForm6 = await _context.PdlBoardForm6.FindAsync(id);
            _context.PdlBoardForm6.Remove(pdlBoardForm6);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PdlBoardForm6Exists(int id)
        {
            return _context.PdlBoardForm6.Any(e => e.PdlBoradForm6RecNo == id);
        }
    }
}
