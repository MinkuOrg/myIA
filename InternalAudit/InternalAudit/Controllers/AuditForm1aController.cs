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
    public class AuditForm1aController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public AuditForm1aController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: AuditForm1a
        public async Task<IActionResult> Index()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            List<AuditPdlForm1a> olist = new List<AuditPdlForm1a>();
            var Data = await (from A in _context.AuditPdlForm1a
                              join B in _context.TblMasterFinancialyear on A.FinancialYear equals B.FinancialYearRecNo
                              join C in _context.TblMasterDistrict on A.District equals C.DistrictRecNo
                              join D in _context.TblMasterInstitutions on A.Institutions equals D.InstitutionsRecNo

                              select new
                              {
                                  AuditPdlForm1ArecNo = A.AuditPdlForm1ArecNo,
                                  InstitutionName = D.InstitutionsName,
                                  FinancialYearName = B.FinancialYear,
                                  DistrictName = C.DistrictName,
                                  NoOfInstitutions = A.NoOfInstitutions,
                                  InstPendingPrevMonth = A.InstPendingPrevMonth,
                                  InstCompletedThisMonth = A.InstCompletedThisMonth,
                                  InstPendingEndMonth = A.InstPendingEndMonth
                              }).ToListAsync();

            if (Data != null)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    olist.Add(new AuditPdlForm1a()
                    {

                         AuditPdlForm1ArecNo = Data[i].AuditPdlForm1ArecNo,
                         InstitutionName = Data[i].InstitutionName,
                         FinancialYearName = Data[i].FinancialYearName,
                         DistrictName = Data[i].DistrictName,
                         NoOfInstitutions = Data[i].NoOfInstitutions,
                         InstPendingPrevMonth = Data[i].InstPendingPrevMonth,
                         InstCompletedThisMonth = Data[i].InstCompletedThisMonth,
                         InstPendingEndMonth = Data[i].InstPendingEndMonth
                    }
                    );
                }
            }

            return View(olist);
            // return View(await _context.AuditPdlForm1a.ToListAsync());
        }

        // GET: AuditForm1a/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auditPdlForm1a = await _context.AuditPdlForm1a
                .FirstOrDefaultAsync(m => m.AuditPdlForm1ArecNo == id);
            if (auditPdlForm1a == null)
            {
                return NotFound();
            }

            return View(auditPdlForm1a);
        }

        // GET: AuditForm1a/Create
        public IActionResult Create()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

                return View();  

            }



            //return View();
        }

        // POST: AuditForm1a/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuditPdlForm1ArecNo,FinancialYear,District,Institutions,NoOfInstitutions,InstPendingPrevMonth,InstCompletedThisMonth,InstPendingEndMonth")] AuditPdlForm1a auditPdlForm1a)
        {

            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            if (ModelState.IsValid)
            {
                _context.Add(auditPdlForm1a);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "AuditForm1a" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "AuditForm1a" };
                }

            }
            return View(auditPdlForm1a);
        }

        // GET: AuditForm1a/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }

            var auditPdlForm1a = await _context.AuditPdlForm1a.FindAsync(id);
            if(auditPdlForm1a == null)
            {
                return NotFound();
            }
            return View(auditPdlForm1a);

            
        }

        // POST: AuditForm1a/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuditPdlForm1ArecNo,FinancialYear,District,Institutions,NoOfInstitutions,InstPendingPrevMonth,InstCompletedThisMonth,InstPendingEndMonth")] AuditPdlForm1a auditPdlForm1a)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            if (id != auditPdlForm1a.AuditPdlForm1ArecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auditPdlForm1a);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "AuditForm1a" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "AuditForm1a" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuditPdlForm1aExists(auditPdlForm1a.AuditPdlForm1ArecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            return View(auditPdlForm1a);
           
        }

        // GET: AuditForm1a/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auditPdlForm1a = await _context.AuditPdlForm1a
                .FirstOrDefaultAsync(m => m.AuditPdlForm1ArecNo == id);
            if (auditPdlForm1a == null)
            {
                return NotFound();
            }

            return View(auditPdlForm1a);
        }

        // POST: AuditForm1a/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auditPdlForm1a = await _context.AuditPdlForm1a.FindAsync(id);
            _context.AuditPdlForm1a.Remove(auditPdlForm1a);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuditPdlForm1aExists(int id)
        {
            return _context.AuditPdlForm1a.Any(e => e.AuditPdlForm1ArecNo == id);
        }

        
    }
}
