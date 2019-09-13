using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternalAudit.Models;

namespace InternalAudit.Controllers
{
    public class DefaultController : Controller
    {
         
        public IActionResult AdminDashboard()
        {
            return View();
        }


    }
}