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
    public class NoonMealForm13Controller : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public NoonMealForm13Controller(auditinternalContext context)
        {
            _context = context;
        }

        // GET: NoonMealForm13
        public async Task<IActionResult> Index()
        {

            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();
                

            }
            List<NoonMealPdlForm13> olist = new List<NoonMealPdlForm13>();
            var Data = await (from A in _context.NoonMealPdlForm13
                              join B in _context.TblMasterFinancialyear on A.FinancialYear equals B.FinancialYearRecNo
                              join C in _context.TblMasterPeriodCategory on A.PeriodCategory equals C.PeriodCategoryRecNo
                              join D in _context.TblMasterPeriod on A.Period equals D.PeriodRecNo
                              

                              select new
                              {
                                  NoonMealRecNo = A.NoonMealRecNo,
                                  FinancialYearName = B.FinancialYear,
                                  PeriodCategoryName = C.PeriodCategory,
                                  PeriodName = D.PeriodName,
                                  Subject = A.Subject,
                                  AsstDirector = A.AsstDirector,
                                  Inspector=A.Inspector,
                                  DeputyInspector =A.DeputyInspector,
                                  AssistantInspector =A.AssistantInspector,
                                  JuniorAssistant =A.JuniorAssistant,
                                  Typist =A.Typist,
                                  RecordClerk =A.RecordClerk,
                                  OfficeAssistant=A.OfficeAssistant,



                              }).ToListAsync();

            if (Data != null)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    olist.Add(new NoonMealPdlForm13()
                    {
                        NoonMealRecNo = Data[i].NoonMealRecNo,
                        FinancialYearName = Data[i].FinancialYearName,
                        PeriodCategoryName =Data[i].PeriodCategoryName,
                        PeriodName = Data[i].PeriodName,
                        Subject = Data[i].Subject,
                        AsstDirector = Data[i].AsstDirector,
                        Inspector = Data[i].Inspector,
                        DeputyInspector = Data[i].DeputyInspector,
                        AssistantInspector =Data[i].AssistantInspector,
                        JuniorAssistant = Data[i].JuniorAssistant,
                        Typist =Data[i].Typist,
                        RecordClerk = Data[i].RecordClerk,
                        OfficeAssistant = Data[i].OfficeAssistant
                       
                    }
                    );
                }
            }

            return View(olist);


            // return View(await _context.NoonMealPdlForm13.ToListAsync());
        }

        // GET: NoonMealForm13/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noonMealPdlForm13 = await _context.NoonMealPdlForm13
                .FirstOrDefaultAsync(m => m.NoonMealRecNo == id);
            if (noonMealPdlForm13 == null)
            {
                return NotFound();
            }

            return View(noonMealPdlForm13);
        }

        // GET: NoonMealForm13/Create
        public IActionResult Create()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();

                return View();
            }
        }

        // POST: NoonMealForm13/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NoonMealRecNo,Subject,AsstDirector,Inspector,DeputyInspector,AssistantInspector,JuniorAssistant,Typist,RecordClerk,OfficeAssistant,FinancialYear,PeriodCategory,Period")] NoonMealPdlForm13 noonMealPdlForm13)
        {

            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();  

            }
            if (ModelState.IsValid)
            {
                _context.Add(noonMealPdlForm13);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "NoonMealForm13" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "NoonMealForm13" };
                }
                //return RedirectToAction(nameof(Index));
            }
            return View(noonMealPdlForm13);
            
        }

        // GET: NoonMealForm13/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();

            }
            var noonMealPdlForm13 = await _context.NoonMealPdlForm13.FindAsync(id);

            GetPeriodCategory(id);
            return View(noonMealPdlForm13);

        }

        // POST: NoonMealForm13/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NoonMealRecNo,Subject,AsstDirector,Inspector,DeputyInspector,AssistantInspector,JuniorAssistant,Typist,RecordClerk,OfficeAssistant,FinancialYear,PeriodCategory,Period")] NoonMealPdlForm13 noonMealPdlForm13)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfPeriodCategory = _context.TblMasterPeriodCategory.ToList();
            }

            if (id != noonMealPdlForm13.NoonMealRecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noonMealPdlForm13);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "NoonMealForm13" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "NoonMealForm13" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoonMealPdlForm13Exists(noonMealPdlForm13.NoonMealRecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
            }
            return View(noonMealPdlForm13);
        }

        // GET: NoonMealForm13/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noonMealPdlForm13 = await _context.NoonMealPdlForm13
                .FirstOrDefaultAsync(m => m.NoonMealRecNo == id);
            if (noonMealPdlForm13 == null)
            {
                return NotFound();
            }

            return View(noonMealPdlForm13);
        }

        // POST: NoonMealForm13/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noonMealPdlForm13 = await _context.NoonMealPdlForm13.FindAsync(id);
            _context.NoonMealPdlForm13.Remove(noonMealPdlForm13);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoonMealPdlForm13Exists(int id)
        {
            return _context.NoonMealPdlForm13.Any(e => e.NoonMealRecNo == id);
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
