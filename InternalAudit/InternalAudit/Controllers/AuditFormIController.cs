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
    public class AuditFormIController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public AuditFormIController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: AuditFormI
        public async Task<IActionResult> Index()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            List<AuditPdlFormI> olist = new List<AuditPdlFormI>();
            var Data = await (from A in _context.AuditPdlFormI
                              join B in _context.TblMasterFinancialyear on A.FinancialYear equals B.FinancialYearRecNo
                              join C in _context.TblMasterDistrict on A.District equals C.DistrictRecNo
                              join D in _context.TblMasterInstitutions on A.Institutions equals D.InstitutionsRecNo

                              select new
                              {
                                  AuditPdlFormIrecNo = A.AuditPdlFormIrecNo,
                                  InstitutionName = D.InstitutionsName,
                                  FinancialYearName = B.FinancialYear,
                                  DistrictName = C.DistrictName,
                                  CentreInstitutionDetails = A.CentreInstitutionDetails,
                                  PendencyReasons = A.PendencyReasons
                              }).ToListAsync();

            if (Data != null)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    olist.Add(new AuditPdlFormI()
                    {

                        AuditPdlFormIrecNo = Data[i].AuditPdlFormIrecNo,
                        InstitutionName = Data[i].InstitutionName,
                        FinancialYearName = Data[i].FinancialYearName,
                        DistrictName = Data[i].DistrictName,
                        CentreInstitutionDetails = Data[i].CentreInstitutionDetails,
                        PendencyReasons = Data[i].PendencyReasons
                    }
                    );
                }
            }

            return View(olist);
            
        }

        // GET: AuditFormI/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auditPdlFormI = await _context.AuditPdlFormI
                .FirstOrDefaultAsync(m => m.AuditPdlFormIrecNo == id);
            if (auditPdlFormI == null)
            {
                return NotFound();
            }

            return View(auditPdlFormI);
        }

        // GET: AuditFormI/Create
        public IActionResult Create()
        {
            using(var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

                return View();
            }

            //return View();
        }

        // POST: AuditFormI/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuditPdlFormIrecNo,FinancialYear,District,Institutions,CentreInstitutionDetails,PendencyReasons")] AuditPdlFormI auditPdlFormI)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            if (ModelState.IsValid)
            {
                _context.Add(auditPdlFormI);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "AuditFormI" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "AuditFormI" };
                }

            }
            return View(auditPdlFormI);


            //if (ModelState.IsValid)
            //{
            //    _context.Add(auditPdlFormI);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(auditPdlFormI);
        }

        // GET: AuditFormI/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }

            var auditPdlFormI = await _context.AuditPdlFormI.FindAsync(id);
            if (auditPdlFormI == null)
            {
                return NotFound();
            }
            return View(auditPdlFormI);
        }

        // POST: AuditFormI/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuditPdlFormIrecNo,FinancialYear,District,Institutions,CentreInstitutionDetails,PendencyReasons")] AuditPdlFormI auditPdlFormI)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            if (id != auditPdlFormI.AuditPdlFormIrecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auditPdlFormI);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "AuditFormI" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "AuditFormI" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuditPdlFormIExists(auditPdlFormI.AuditPdlFormIrecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            return View(auditPdlFormI);
           
        }

        // GET: AuditFormI/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auditPdlFormI = await _context.AuditPdlFormI
                .FirstOrDefaultAsync(m => m.AuditPdlFormIrecNo == id);
            if (auditPdlFormI == null)
            {
                return NotFound();
            }

            return View(auditPdlFormI);
        }

        // POST: AuditFormI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auditPdlFormI = await _context.AuditPdlFormI.FindAsync(id);
            _context.AuditPdlFormI.Remove(auditPdlFormI);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuditPdlFormIExists(int id)
        {
            return _context.AuditPdlFormI.Any(e => e.AuditPdlFormIrecNo == id);
        }
    }
}
