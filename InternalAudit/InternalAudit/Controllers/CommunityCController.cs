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
    public class CommunityCController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public CommunityCController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: CommunityC
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommunityFormC.ToListAsync());
        }

        // GET: CommunityC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormC = await _context.CommunityFormC
                .FirstOrDefaultAsync(m => m.CommunityFormCrecNo == id);
            if (communityFormC == null)
            {
                return NotFound();
            }

            return View(communityFormC);
        }

        // GET: CommunityC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommunityC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommunityFormCrecNo,DistrictOffice,OfficerPersonnelsName,PostName,Grade,JoiningDate,Gender,Religion,Category,FormRecNo")] CommunityFormC communityFormC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(communityFormC);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "CommunityC" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "CommunityC" };
                }
            }
            return View(communityFormC);
        }

        // GET: CommunityC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormC = await _context.CommunityFormC.FindAsync(id);
            if (communityFormC == null)
            {
                return NotFound();
            }
            return View(communityFormC);
        }

        // POST: CommunityC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommunityFormCrecNo,DistrictOffice,OfficerPersonnelsName,PostName,Grade,JoiningDate,Gender,Religion,Category,FormRecNo")] CommunityFormC communityFormC)
        {
            if (id != communityFormC.CommunityFormCrecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(communityFormC);
                    var result = await _context.SaveChangesAsync();

                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "CommunityC" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "CommunityC" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommunityFormCExists(communityFormC.CommunityFormCrecNo))
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
            return View(communityFormC);
        }

        // GET: CommunityC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormC = await _context.CommunityFormC
                .FirstOrDefaultAsync(m => m.CommunityFormCrecNo == id);
            if (communityFormC == null)
            {
                return NotFound();
            }

            return View(communityFormC);
        }

        // POST: CommunityC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var communityFormC = await _context.CommunityFormC.FindAsync(id);
            _context.CommunityFormC.Remove(communityFormC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommunityFormCExists(int id)
        {
            return _context.CommunityFormC.Any(e => e.CommunityFormCrecNo == id);
        }
    }
}
