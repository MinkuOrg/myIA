using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternalAudit.Models;
using InternalAudit.DTO;
using Microsoft.EntityFrameworkCore;
using InternalAudit.Common;


namespace InternalAudit.Controllers
{
    public class InstitutionsController : Controller
    {
        static string Result = string.Empty;
        static string PageLocation = string.Empty;
        private readonly auditinternalContext _context;

        public InstitutionsController(auditinternalContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> InstitutionsDetails(TblMasterInstitutions model)
        {

            var InstDetails = await _context.TblMasterInstitutions.ToListAsync();

            return View(InstDetails.ToList());
        }

         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InstitutionsCreate(TblMasterInstitutions model)
        {
            _context.TblMasterInstitutions.Add(model);
            var result = await _context.SaveChangesAsync();

            if (result == 1)
            {
                Result = "Saved";
                ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "InstitutionsDetails", BackPageController = "Institutions" };
            }
            else
            {
                ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "InstitutionsDetails", BackPageController = "Institutions" };
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> InstitutionsCreate()
        {
            return View();
        }


        public async Task<IActionResult> InstitutionsEdit(int id)
        {
            var result = await _context.TblMasterInstitutions.FindAsync(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InstitutionsEdit(int id, [Bind("InstitutionsRecNo,District,InstitutionsCategory,InstitutionsName,InstitutionsDetails,Contact,EmaiId")] TblMasterInstitutions oTblMasterInstitutions)
        {

            if (id != oTblMasterInstitutions.InstitutionsRecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oTblMasterInstitutions);
                    var result = await _context.SaveChangesAsync();
                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "InstitutionsDetails", BackPageController = "Institutions" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "InstitutionsDetails", BackPageController = "Institutions" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblMasterInstitutionsExists(oTblMasterInstitutions.InstitutionsRecNo))
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
            return View(oTblMasterInstitutions);









            //if (ModelState.IsValid)
            //{
            //    _context.TblMasterInstitutions.Update(oTblMasterInstitutions);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction("InstitutionsDetails");
            //}
            //else
            //{
            //    return View();
            //}

        }

        private bool TblMasterInstitutionsExists(int id)
        {
            return _context.TblMasterInstitutions.Any(e => e.InstitutionsRecNo == id);
        }



        public async Task<IActionResult> InstitutionsDelete(int id)
        {
            _context.TblMasterInstitutions.Remove(await _context.TblMasterInstitutions.FindAsync(id));
            var Res =await _context.SaveChangesAsync();
            if (Res >0)
            {
                //return View();
                return RedirectToAction("InstitutionsDetails", "Institutions");

            }
            else
            {
                return NotFound();
            }
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> InstitutionsDelete()
        //{
        //    var result = await _context.TblMasterInstitutions.FindAsync()
        //}






        //// GET: NoonMealForm2/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var noonMealPdlForm2 = await _context.NoonMealPdlForm2
        //        .FirstOrDefaultAsync(m => m.NoonMealRecNo == id);
        //    if (noonMealPdlForm2 == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(noonMealPdlForm2);
        //}

        //// POST: NoonMealForm2/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var noonMealPdlForm2 = await _context.NoonMealPdlForm2.FindAsync(id);
        //    _context.NoonMealPdlForm2.Remove(noonMealPdlForm2);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

    }
}