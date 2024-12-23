using Microsoft.EntityFrameworkCore;
using VsPersonalizedHub_gift.Models;

namespace VsPersonalizedHub_gift.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Note> Notes { get; set; }
}
