using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternalAudit.Models;
using InternalAudit.DTO;
using InternalAudit.Common;

namespace InternalAudit.Controllers
{
    public class NoonMealForm2Controller : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public NoonMealForm2Controller(auditinternalContext context)
        {
            _context = context;
        }

        // GET: NoonMealForm2
        public async Task<IActionResult> Index()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();
               
            }
            List<NoonMealPdlForm2> olist = new List<NoonMealPdlForm2>();
            var Data = await (from A in _context.NoonMealPdlForm2
                              join B in _context.TblMasterFinancialyear on A.FinancialYear equals B.FinancialYearRecNo
                              join C in _context.TblMasterPeriodCategory on A.PeriodCategory equals C.PeriodCategoryRecNo
                              join D in _context.TblMasterPeriod on A.Period equals D.PeriodRecNo
                              join E in _context.TblMasterInstitutions on A.InstitutionsName equals E.InstitutionsRecNo
                           
                              select new
                              {
                                  NoonMealRecNo = A.NoonMealRecNo,
                                  InstitutionName = E.InstitutionsName,
                                  FinancialYearName = B.FinancialYear,
                                  PeriodCategoryName = C.PeriodCategory,
                                  Period = D.PeriodName,

                                  TotalCenter = A.TotalCenter,
                                  Completed = A.Completed,
                                  Pending = A.Pending,

                              }).ToListAsync();

            if (Data != null)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    olist.Add(new NoonMealPdlForm2()
                    {

                        NoonMealRecNo = Data[i].NoonMealRecNo,
                        InstitutionName =Data[i].InstitutionName,
                        FinancialYearName = Data[i].FinancialYearName,
                        PeriodCategoryName = Data[i].PeriodCategoryName,
                        PeriodName = Data[i].Period,
                        TotalCenter = Data[i].TotalCenter,
                        Completed = Data[i].Completed,
                        Pending = Data[i].Pending
                    }
                    );
                }
            }

            return View(olist);

           // return View(await _context.NoonMealPdlForm2.ToListAsync());

        }

        // GET: NoonMealForm2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noonMealPdlForm2 = await _context.NoonMealPdlForm2
                .FirstOrDefaultAsync(m => m.NoonMealRecNo == id);
            if (noonMealPdlForm2 == null)
            {
                return NotFound();
            }

            return View(noonMealPdlForm2);
        }

        // GET: NoonMealForm2/Create
        public IActionResult Create()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

                return View();
            }
        }



        // POST: NoonMealForm2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NoonMealRecNo,InstitutionsName,TotalCenter,Completed,Pending,CreatedBy,CreatedDate,FinancialYear,PeriodCategory,Period")] NoonMealPdlForm2 noonMealPdlForm2)
        {

            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();
            
            }
            if (ModelState.IsValid)
            {
                _context.Add(noonMealPdlForm2);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "NoonMealForm2" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "NoonMealForm2" };
                }
                 
            }
            return View(noonMealPdlForm2);
        }


        // GET: NoonMealForm2/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
             
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();

            }
            var noonMealPdlForm2 = await _context.NoonMealPdlForm2.FindAsync(id);
            
            GetPeriodCategory(id);
            return View(noonMealPdlForm2);
             
        }

        // POST: NoonMealForm2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NoonMealRecNo,InstitutionsName,TotalCenter,Completed,Pending,CreatedBy,CreatedDate,FinancialYear,PeriodCategory,Period")] NoonMealPdlForm2 noonMealPdlForm2)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();
                ViewBag.ListOfInstitutions = _context.TblMasterInstitutions.ToList();
            }

            if (id != noonMealPdlForm2.NoonMealRecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noonMealPdlForm2);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "NoonMealForm2" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Details", BackPageController = "NoonMealPdlForm1" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoonMealPdlForm2Exists(noonMealPdlForm2.NoonMealRecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
               // return RedirectToAction(nameof(Index));
            }
            return View(noonMealPdlForm2);
            
        }

        // GET: NoonMealForm2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noonMealPdlForm2 = await _context.NoonMealPdlForm2
                .FirstOrDefaultAsync(m => m.NoonMealRecNo == id);
            if (noonMealPdlForm2 == null)
            {
                return NotFound();
            }

            return View(noonMealPdlForm2);
        }

        // POST: NoonMealForm2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noonMealPdlForm2 = await _context.NoonMealPdlForm2.FindAsync(id);
            _context.NoonMealPdlForm2.Remove(noonMealPdlForm2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoonMealPdlForm2Exists(int id)
        {
            return _context.NoonMealPdlForm2.Any(e => e.NoonMealRecNo == id);
        }

        [HttpPost]
        public JsonResult GetPeriodCategory(int id)
        {
          
            var Period = _context.TblMasterPeriod.Where(c => c.PeriodCategory == id).OrderBy(c => c.PeriodName).Select(c => new
            { RecNo = c.PeriodRecNo, Name = c.PeriodName });
            return Json(Period);

        }



    }
}
