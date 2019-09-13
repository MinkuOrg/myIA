using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalAudit.DTO;
using InternalAudit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InternalAudit.Common;
using System.Data;

namespace InternalAudit.Controllers
{
    public class Financial_YearController : Controller
    {
        static string Result = string.Empty;
        static string PageLocation = string.Empty;

        public readonly auditinternalContext _FinancialContext;

        public Financial_YearController(auditinternalContext context)
        {
            _FinancialContext = context;
        }

        public IActionResult Financial_Year()
        {
            return View();
        }

        //For Get the value
        public async Task<IActionResult> Financial_Year_List()
        {
            return View(await _FinancialContext.TblMasterFinancialyear.ToListAsync());
        }

        //For Post the Value

        [HttpPost]
        public async Task<IActionResult> Financial_Year(TblMasterFinancialyear Financial)//model object Ref
        {
            await _FinancialContext.TblMasterFinancialyear.AddAsync(Financial);

            var result = await _FinancialContext.SaveChangesAsync();
            if (result == 1)
            {
                Result = "Details are Added!!";
                ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Financial Year(" + Financial.FinancialYear + ")</b> Details Successfully Saved!!.", Status = "S", BackPageAction = "Financial_Year_List", BackPageController = "Financial_Year" };
            }
            else
            {
                ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Unable to Update Financial Year(" + Financial.FinancialYear + ")</b> Details!! and if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Financial_Year_List", BackPageController = "Financial_Year" };
            }
            return View();
        }

        //For Update the value

        public IActionResult EditFinancial_Year(int id)
        {
            return View(_FinancialContext.TblMasterFinancialyear.Find(id));
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditFinancial_Year(int FinancialYearRecNo, [Bind("FinancialYearRecNo,FinancialYear")] TblMasterFinancialyear finance)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _FinancialContext.Update(finance);
                    await _FinancialContext.SaveChangesAsync();
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Financial Year(" + finance.FinancialYear + ")</b> Details Successfully Updated!!.", Status = "S", BackPageAction = "Financial_Year_List", BackPageController = "Financial_Year" };
                    return View();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Unable to Update Financial Year(" + finance.FinancialYear + ")</b> Details!! and if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Financial_Year_List", BackPageController = "Financial_Year" };
                    ModelState.AddModelError(string.Empty, "Unable to Update. Try again, and if the problem persists contact your system administrator.");
                    return View(finance);
                }
                catch (DataException)
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Unable to Update Financial Year(" + finance.FinancialYear + ")</b> Details!! and if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Financial_Year_List", BackPageController = "Financial_Year" };
                    ModelState.AddModelError(string.Empty, "Unable to Update. Try again, and if the problem persists contact your system administrator.");
                    return View(finance);
                } 
            }
            else
            {
                return View();
            }

        }
    }
}
