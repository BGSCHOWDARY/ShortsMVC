using System.Data.Entity;
using ShortsMVC.Models;


public class ShortsDbContext : DbContext
{
    public ShortsDbContext() : base("DefaultConnection") { }

    public DbSet<Short> Shorts { get; set; }
}
