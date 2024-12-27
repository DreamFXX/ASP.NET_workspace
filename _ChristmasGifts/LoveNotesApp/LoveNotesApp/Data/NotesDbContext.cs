using LoveNotesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveNotesApp.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
