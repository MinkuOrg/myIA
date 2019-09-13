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
    public class Annexure2BController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;
        public Annexure2BController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: Annexure2B
        public async Task<IActionResult> Index()
        {

            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
            }
            List<Annexure2FormB> olist = new List<Annexure2FormB>();
            var Data = await (from A in _context.Annexure2FormB
                              join B in _context.TblMasterFinancialyear on A.FinancialYear equals B.FinancialYearRecNo

                              select new
                              {
                                  Annexure2FormBrecNo = A.Annexure2FormBrecNo,
                                  FinancialYearName = B.FinancialYear,
                                  AdministrativeDepartment = A.AdministrativeDepartment,
                                  InstitutionDetails = A.InstitutionDetails,
                                  AuditFees = A.AuditFees
                              }).ToListAsync();

            if (Data != null)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    olist.Add(new Annexure2FormB()
                    {

                        Annexure2FormBrecNo = Data[i].Annexure2FormBrecNo,
                        FinancialYearName = Data[i].FinancialYearName,
                        AdministrativeDepartment = Data[i].AdministrativeDepartment,
                        InstitutionDetails = Data[i].InstitutionDetails,
                        AuditFees = Data[i].AuditFees
                    }
                    );
                }
            }

            return View(olist);
            //return View(await _context.Annexure2FormB.ToListAsync());
        }

        // GET: Annexure2B/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure2FormB = await _context.Annexure2FormB
                .FirstOrDefaultAsync(m => m.Annexure2FormBrecNo == id);
            if (annexure2FormB == null)
            {
                return NotFound();
            }

            return View(annexure2FormB);
        }

        // GET: Annexure2B/Create
        public IActionResult Create()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                return View();
            }
        }

        // POST: Annexure2B/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Annexure2FormBrecNo,AdministrativeDepartment,InstitutionDetails,FinancialYear,AuditFees")] Annexure2FormB annexure2FormB)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
            }
            if (ModelState.IsValid)
            {
                _context.Add(annexure2FormB);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure2B" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure2B" };
                }
            }
            return View(annexure2FormB);
        }

        // GET: Annexure2B/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
            }
            var annexure2FormB = await _context.Annexure2FormB.FindAsync(id);
            if(annexure2FormB == null)
            {
                return NotFound();
            }
            return View(annexure2FormB);
           
        }

        // POST: Annexure2B/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Annexure2FormBrecNo,AdministrativeDepartment,InstitutionDetails,FinancialYear,AuditFees")] Annexure2FormB annexure2FormB)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
            }

            if (id != annexure2FormB.Annexure2FormBrecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(annexure2FormB);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure2B" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure2B" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Annexure2FormBExists(annexure2FormB.Annexure2FormBrecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            return View(annexure2FormB);

        }

        // GET: Annexure2B/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure2FormB = await _context.Annexure2FormB
                .FirstOrDefaultAsync(m => m.Annexure2FormBrecNo == id);
            if (annexure2FormB == null)
            {
                return NotFound();
            }

            return View(annexure2FormB);
        }

        // POST: Annexure2B/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var annexure2FormB = await _context.Annexure2FormB.FindAsync(id);
            _context.Annexure2FormB.Remove(annexure2FormB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Annexure2FormBExists(int id)
        {
            return _context.Annexure2FormB.Any(e => e.Annexure2FormBrecNo == id);
        }
    }
}
