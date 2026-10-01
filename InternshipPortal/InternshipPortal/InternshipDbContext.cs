using Microsoft.EntityFrameworkCore;
using InternshipPortal.Models;
using Microsoft.AspNetCore.Mvc;

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

        modelBuilder.Entity<UserAccount>().HasData(
            new UserAccount
            {
                UserAccountId = 1,
                Username = "student",
                Password = "12341234",
                Role = "Student",
                RoleSpecificId = 0
            },
            new UserAccount
            {
                UserAccountId = 2,
                Username = "coord",
                Password = "12341234",
                Role = "Coordinator",
                RoleSpecificId = 0
            }
        );

        modelBuilder.Entity<InternshipListing>().HasData(
            new InternshipListing
            {
                InternshipListingId = 1,
                Title = "Software Engineering Intern",
                Site = "https://www.example.com/internship",
                Company = "Example Company",
                Location = "New York, NY",
                Description = "This is a software engineering internship.",
                ExtendedDescription = "This is an extended description of the software engineering internship."
            }
        );
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Ranking> Rankings { get; set; }
    public DbSet<InternshipListing> InternshipListings { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Coordinator> Coordinators { get; set; }
    public DbSet<UserAccount> UserAccounts { get; set; }

}