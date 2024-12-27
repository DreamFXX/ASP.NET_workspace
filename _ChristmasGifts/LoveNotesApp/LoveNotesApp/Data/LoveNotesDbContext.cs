using LoveNotesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveNotesApp.Data;

public class LoveNotesDbContext : DbContext
{
    public LoveNotesDbContext(DbContextOptions<LoveNotesDbContext> options) : base(options) { }

    public DbSet<Note> Notes { get; set; }
}