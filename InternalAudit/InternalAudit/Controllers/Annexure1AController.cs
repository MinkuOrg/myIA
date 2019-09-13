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
    //Change by Minku
    public class Annexure1AController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public Annexure1AController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: Annexure1A
        public async Task<IActionResult> Index()
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
            }
            List<Annexure1FormA> olist = new List<Annexure1FormA>();
            var Data = await (from A in _context.Annexure1FormA
                              join B in _context.TblMasterFinancialyear on A.FinancialYear equals B.FinancialYearRecNo
                              join C in _context.TblMasterDistrict on A.District equals C.DistrictRecNo
                              

                              select new
                              {
                                  Annexure1FormArecNo = A.Annexure1FormArecNo,
                                  FinancialYearName = B.FinancialYear,
                                  DistrictName = C.DistrictName,
                                  AgricultureExtenCentre = A.AgricultureExtenCentre,
                                  PendencyDetail = A.PendencyDetail,
                              }).ToListAsync();

            if (Data != null)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    olist.Add(new Annexure1FormA()
                    {

                        Annexure1FormArecNo = Data[i].Annexure1FormArecNo,
                        FinancialYearName = Data[i].FinancialYearName,
                        DistrictName = Data[i].DistrictName,
                        AgricultureExtenCentre = Data[i].AgricultureExtenCentre,
                        PendencyDetail = Data[i].PendencyDetail
                    }
                    );
                }
            }

            return View(olist);
        }

        // GET: Annexure1A/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure1FormA = await _context.Annexure1FormA
                .FirstOrDefaultAsync(m => m.Annexure1FormArecNo == id);
            if (annexure1FormA == null)
            {
                return NotFound();
            }

            return View(annexure1FormA);
        }

        // GET: Annexure1A/Create
        public IActionResult Create()
        {

            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
                return View();
            }
        }

        // POST: Annexure1A/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Annexure1FormArecNo,FinancialYear,District,AgricultureExtenCentre,PendencyDetail")] Annexure1FormA annexure1FormA)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();   
            }
            if (ModelState.IsValid)
            {
                _context.Add(annexure1FormA);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure1A" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure1A" };
                }
            }
            return View(annexure1FormA);
        }

        // GET: Annexure1A/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
            }
            var annexure1FormA = await _context.Annexure1FormA.FindAsync(id);
            if(annexure1FormA == null)
            {
                return NotFound();
            }
            return View(annexure1FormA);
        }

        // POST: Annexure1A/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Annexure1FormArecNo,FinancialYear,District,AgricultureExtenCentre,PendencyDetail")] Annexure1FormA annexure1FormA)
        {
            using (var _context = new auditinternalContext())
            {
                ViewBag.ListOfFinancialYear = _context.TblMasterFinancialyear.ToList();
                ViewBag.ListOfDistrict = _context.TblMasterDistrict.ToList();
            }
            if (id != annexure1FormA.Annexure1FormArecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(annexure1FormA);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "Annexure1A" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "Annexure1A" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Annexure1FormAExists(annexure1FormA.Annexure1FormArecNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(annexure1FormA);

        }

        // GET: Annexure1A/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annexure1FormA = await _context.Annexure1FormA
                .FirstOrDefaultAsync(m => m.Annexure1FormArecNo == id);
            if (annexure1FormA == null)
            {
                return NotFound();
            }

            return View(annexure1FormA);
        }

        // POST: Annexure1A/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var annexure1FormA = await _context.Annexure1FormA.FindAsync(id);
            _context.Annexure1FormA.Remove(annexure1FormA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Annexure1FormAExists(int id)
        {
            return _context.Annexure1FormA.Any(e => e.Annexure1FormArecNo == id);
        }
    }
}
