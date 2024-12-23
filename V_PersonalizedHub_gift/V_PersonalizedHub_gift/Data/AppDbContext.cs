using Microsoft.EntityFrameworkCore;
using V_PersonalizedHub_gift.Models;

namespace V_PersonalizedHub_gift.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Note> Notes { get; set; }
}