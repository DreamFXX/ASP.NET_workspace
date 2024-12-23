using Microsoft.AspNetCore.Mvc;
using V_PersonalizedHub_gift.Models;
using V_PersonalizedHub_gift.Data;

namespace PersonalizedHub.Controllers;

public class NotesController : Controller
{
    private readonly AppDbContext _context;

    public NotesController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var notes = _context.Notes.ToList();
        return View(notes);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Note note)
    {
        if (ModelState.IsValid)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(note);
    }

    public IActionResult Delete(int id)
    {
        var note = _context.Notes.Find(id);
        if (note == null) return NotFound();

        _context.Notes.Remove(note);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}