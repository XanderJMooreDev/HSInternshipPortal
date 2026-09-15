using Microsoft.EntityFrameworkCore;
using InternshipPortal.Models;

public class InternshipDbContext : DbContext
{
    public InternshipDbContext(DbContextOptions<InternshipDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                StudentId = 1,
                FirstName = "John",
                LastName = "Doe",
                PreferredName = "Johnny",
                Email = ""
            }
            );
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Ranking> Rankings { get; set; }
    public DbSet<InternshipListing> InternshipListings { get; set; }
    public DbSet<Employer> Employers { get; set; }

}