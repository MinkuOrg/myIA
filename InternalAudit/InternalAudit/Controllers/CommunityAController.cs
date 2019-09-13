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
    public class CommunityAController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public CommunityAController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: CommunityA
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommunityFormA.ToListAsync());
        }

        // GET: CommunityA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormA = await _context.CommunityFormA
                .FirstOrDefaultAsync(m => m.CommunityFormArecNo == id);
            if (communityFormA == null)
            {
                return NotFound();
            }

            return View(communityFormA);
        }

        // GET: CommunityA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommunityA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommunityFormArecNo,DistrictOffice,OfficerPersonnelsName,PostName,Grade,JoiningDate,Gender,Religion,Category,FormRecNo")] CommunityFormA communityFormA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(communityFormA);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "CommunityA" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "CommunityA" };
                }
            }
            return View(communityFormA);
        }

        // GET: CommunityA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormA = await _context.CommunityFormA.FindAsync(id);
            if (communityFormA == null)
            {
                return NotFound();
            }
            return View(communityFormA);
        }

        // POST: CommunityA/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommunityFormArecNo,DistrictOffice,OfficerPersonnelsName,PostName,Grade,JoiningDate,Gender,Religion,Category,FormRecNo")] CommunityFormA communityFormA)
        {
            if (id != communityFormA.CommunityFormArecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(communityFormA);
                    var result = await _context.SaveChangesAsync();

                    if (result == 1)
                    {
                        Result = "Updated";
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Updated!!.", Status = "S", BackPageAction = "Index", BackPageController = "CommunityA" };
                    }
                    else
                    {
                        ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "CommunityA" };
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommunityFormAExists(communityFormA.CommunityFormArecNo))
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
            return View(communityFormA);
        }

        // GET: CommunityA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormA = await _context.CommunityFormA
                .FirstOrDefaultAsync(m => m.CommunityFormArecNo == id);
            if (communityFormA == null)
            {
                return NotFound();
            }

            return View(communityFormA);
        }

        // POST: CommunityA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var communityFormA = await _context.CommunityFormA.FindAsync(id);
            _context.CommunityFormA.Remove(communityFormA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommunityFormAExists(int id)
        {
            return _context.CommunityFormA.Any(e => e.CommunityFormArecNo == id);
        }
    }
}
