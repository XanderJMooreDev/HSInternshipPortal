using Microsoft.EntityFrameworkCore;
using InternshipPortal.Models;

public class InternshipDbContext : DbContext
{
    public InternshipDbContext(DbContextOptions<InternshipDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Ranking> Rankings { get; set; }
    public DbSet<InternshipListing> InternshipListings { get; set; }
    public DbSet<Employer> Employers { get; set; }

}