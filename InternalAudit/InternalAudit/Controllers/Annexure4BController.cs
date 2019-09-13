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
    public class Annexure4BController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public Annexure4BController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: Annexure4B
        public async Task<IActionResult> Index()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();
                
            }
            List<Annexure4FormB> olist = new List<Annexure4FormB>();
            var Data = await (from A in _context.Annexure4FormB
                              join B in _context.TblMasterFinancialyear on A.FinancialYear equals B.FinancialYearRecNo
                              join C in _context.TblMasterInstitutions on A.Institutions equals C.InstitutionsRecNo

                              select new
                              {
                                  Annexure4FormBrecNo = A.Annexure4FormBrecNo,
                                  FinancialYearName = B.FinancialYear,
                                  InstitutionName = C.InstitutionsName,
                                  AuditFees = A.AuditFees
                              }).ToListAsync();

            if (Data != null)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    olist.Add(new Annexure4FormB()
                    {
                        Annexure4FormBrecNo = Data[i].Annexure4FormBrecNo,
                        FinancialYearName = Data[i].FinancialYearName,
                        InstitutionName = Data[i].InstitutionName,
                        AuditFees = Data[i].AuditFees
                    }
                    );
                }
            }

            return View(olist);




            //return View(await _context.Annexure4FormB.ToListAsync());
        }

        // GET: Annexure4B/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure4FormB = await _context.Annexure4FormB
                .FirstOrDefaultAsync(m => m.Annexure4FormBrecNo == id);
            if (annexure4FormB == null)
            {
                return NotFound();
            }

            return View(annexure4FormB);
        }

        // GET: Annexure4B/Create
        public IActionResult Create()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();
                return View();

            }
            //return View();
        }

        // POST: Annexure4B/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Annexure4FormBrecNo,Institutions,FinancialYear,AuditFees")] Annexure4FormB annexure4FormB)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            if (ModelState.IsValid)
            {
                _context.Add(annexure4FormB);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure4B" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure4B" };
                }
            }
            return View(annexure4FormB);
        }

        // GET: Annexure4B/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();
            }
            var annexure4FormB = await _context.Annexure4FormB.FindAsync(id);
            if (annexure4FormB == null)
            {
                return NotFound();
            }
            return View(annexure4FormB);
        }

        // POST: Annexure4B/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Annexure4FormBrecNo,Institutions,FinancialYear,AuditFees")] Annexure4FormB annexure4FormB)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();
            }
            if (id != annexure4FormB.Annexure4FormBrecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(annexure4FormB);
                 var result = await _context.SaveChangesAsync();
                    if(result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure4B" };

                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure4B" };

                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Annexure4FormBExists(annexure4FormB.Annexure4FormBrecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
               
            }
            return View(annexure4FormB);
        }

        // GET: Annexure4B/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure4FormB = await _context.Annexure4FormB
                .FirstOrDefaultAsync(m => m.Annexure4FormBrecNo == id);
            if (annexure4FormB == null)
            {
                return NotFound();
            }

            return View(annexure4FormB);
        }

        // POST: Annexure4B/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var annexure4FormB = await _context.Annexure4FormB.FindAsync(id);
            _context.Annexure4FormB.Remove(annexure4FormB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Annexure4FormBExists(int id)
        {
            return _context.Annexure4FormB.Any(e => e.Annexure4FormBrecNo == id);
        }
    }
}
