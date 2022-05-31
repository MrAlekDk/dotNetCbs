using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cbsStudents.Data;
using students.Models.Entities;

namespace cbsStudents.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly CbsStudentsContext _context;

        public VolunteerController(CbsStudentsContext context)
        {
            _context = context;
        }

        // GET: Volunteer
        public async Task<IActionResult> Index()
        {
            var cbsStudentsContext = _context.Volunteer.Include(v => v.Group);
            return View(await cbsStudentsContext.ToListAsync());
        }

        // GET: Volunteer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteer
                .Include(v => v.Group)
                .FirstOrDefaultAsync(m => m.VolunteerId == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            return PartialView("Details", volunteer);
        }

        // GET: Volunteer/Create
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "Name");
            return View();
        }

        // POST: Volunteer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VolunteerId,Name,Age,StudyProgramme,CreatedDate,Status,GroupId")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                volunteer.Status = VolunteerStatus.PENDING;
                _context.Add(volunteer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "Name", volunteer.GroupId);
            return View(volunteer);
        }

        // GET: Volunteer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteer.FindAsync(id);
            if (volunteer == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "Name", volunteer.GroupId);
            return View(volunteer);
        }

        // POST: Volunteer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VolunteerId,Name,Age,StudyProgramme,CreatedDate,Status,GroupId")] Volunteer volunteer)
        {
            if (id != volunteer.VolunteerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(volunteer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VolunteerExists(volunteer.VolunteerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "Name", volunteer.GroupId);
            return View(volunteer);
        }

        // GET: Volunteer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteer
                .Include(v => v.Group)
                .FirstOrDefaultAsync(m => m.VolunteerId == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }

        // POST: Volunteer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var volunteer = await _context.Volunteer.FindAsync(id);
            _context.Volunteer.Remove(volunteer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //[HttpPost, ActionName("AcceptApplication")]
        public async Task<IActionResult> AcceptApplication(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteer
                .Include(v => v.Group)
                .FirstOrDefaultAsync(m => m.VolunteerId == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            volunteer.Status = VolunteerStatus.ACCEPTED; 
            try
                {
                    _context.Update(volunteer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {}
                   
           return RedirectToAction(nameof(Index));
        }

       // [HttpPost, ActionName("DeclineApplication")]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeclineApplication(int? id)
        {
           if (id == null)
            {
                return NotFound();
            }

            var volunteer = await _context.Volunteer
                .Include(v => v.Group)
                .FirstOrDefaultAsync(m => m.VolunteerId == id);
            if (volunteer == null)
            {
                return NotFound();
            }

            volunteer.Status = VolunteerStatus.DECLINED; 
            try
                {
                    _context.Update(volunteer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {}
                   
           return RedirectToAction(nameof(Index));
        }

        private bool VolunteerExists(int id)
        {
            return _context.Volunteer.Any(e => e.VolunteerId == id);
        }
    }
}