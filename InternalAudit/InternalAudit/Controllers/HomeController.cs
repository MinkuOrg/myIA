using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternalAudit.Models;
using InternalAudit.DTO;
using Microsoft.EntityFrameworkCore;
using InternalAudit.Common;

namespace InternalAudit.Controllers
{
    public class HomeController : Controller
    {
        private readonly auditinternalContext _context;
        private readonly ILogger _logger;

        public HomeController(auditinternalContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult HomePage()
        {
            _logger.Log();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HomePage(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var loginResult = await _context.Login.FirstOrDefaultAsync(a => a.UserName == model.UserName && a.Password == model.Password);
                if (loginResult != null)
                {
                    return RedirectToAction("AdminDashboard", "Default");
                }
                else
                { 
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/> Username and Password is incorrect. Please try again with correct login details.", Status = "E" };

                }
            }
            return View();
        }
    }
}
