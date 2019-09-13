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
    public class CommunityBController : Controller
    {
        private readonly auditinternalContext _context;
        static string Result = string.Empty;

        public CommunityBController(auditinternalContext context)
        {
            _context = context;
        }

        // GET: CommunityB
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommunityFormB.ToListAsync());
        }

        // GET: CommunityB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormB = await _context.CommunityFormB
                .FirstOrDefaultAsync(m => m.CommunityFormBrecNo == id);
            if (communityFormB == null)
            {
                return NotFound();
            }

            return View(communityFormB);
        }

        // GET: CommunityB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommunityB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommunityFormBrecNo,DistrictOffice,OfficerPersonnelsName,PostName,Grade,JoiningDate,Gender,Religion,Category,FormRecNo")] CommunityFormB communityFormB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(communityFormB);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    Result = "Saved";
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/>Details Successfully Saved!!.", Status = "S", BackPageAction = "Index", BackPageController = "CommunityB" };
                }
                else
                {
                    ViewData["Msg"] = new MessageDTO { Message = "Dear User,<br/><b>Some Error Ocurred Please try Later. if the problem persists contact your system administrator..", Status = "E", BackPageAction = "Index", BackPageController = "CommunityB" };
                }
            }
            return View(communityFormB);
        }

        // GET: CommunityB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormB = await _context.CommunityFormB.FindAsync(id);
            if (communityFormB == null)
            {
                return NotFound();
            }
            return View(communityFormB);
        }

        // POST: CommunityB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommunityFormBrecNo,DistrictOffice,OfficerPersonnelsName,PostName,Grade,JoiningDate,Gender,Religion,Category,FormRecNo")] CommunityFormB communityFormB)
        {
            if (id != communityFormB.CommunityFormBrecNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(communityFormB);
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
                    if (!CommunityFormBExists(communityFormB.CommunityFormBrecNo))
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
            return View(communityFormB);
        }

        // GET: CommunityB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communityFormB = await _context.CommunityFormB
                .FirstOrDefaultAsync(m => m.CommunityFormBrecNo == id);
            if (communityFormB == null)
            {
                return NotFound();
            }

            return View(communityFormB);
        }

        // POST: CommunityB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var communityFormB = await _context.CommunityFormB.FindAsync(id);
            _context.CommunityFormB.Remove(communityFormB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommunityFormBExists(int id)
        {
            return _context.CommunityFormB.Any(e => e.CommunityFormBrecNo == id);
        }
    }
}
