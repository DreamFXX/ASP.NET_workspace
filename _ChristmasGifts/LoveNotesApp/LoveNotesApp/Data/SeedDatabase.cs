using LoveNotesApp.Models;
using System;
using System.Linq;

namespace LoveNotesApp.Data;

public static class NoteSeeder
{
    public static void SeedNotes(LoveNotesDbContext context)
    {
        if (!context.Notes.Any())
        {
            context.Notes.AddRange(new[]
            {
                new Note { Message = "You brighten my world!", UnlockDate = DateTime.Today, IsUnlocked = true },
                new Note { Message = "You are my sunshine!", UnlockDate = DateTime.Today.AddDays(1) },
                new Note { Message = "I’m so lucky to have you!", UnlockDate = DateTime.Today.AddDays(2) }
            });

            context.SaveChanges();
        }
    }
}
