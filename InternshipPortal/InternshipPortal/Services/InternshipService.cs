using InternshipPortal.Models;

namespace InternshipPortal.Services;
public class InternshipService
{
    public List<InternshipListing> Internships { get; } = new()
    {
            new InternshipListing
            {
                Title = "Software Engineering Intern",
                Site = "https://example.com/internship1",
                Company = "TechCorp",
                Location = "New York, NY",
                Description = "Work on cutting-edge software projects.",
                ExtendedDescription = "This internship offers hands-on experience in software development, including coding, testing, " +
                "and deployment. Interns will collaborate with experienced engineers and gain insights into the software development lifecycle.",
                InternshipListingId = 0
            },
            new InternshipListing
            {
                Title = "Data Science Intern",
                Site = "https://example.com/internship2",
                Company = "DataSolutions",
                Location = "San Francisco, CA",
                Description = "Analyze and interpret complex data sets.",
                InternshipListingId = 1
            },
            new InternshipListing
            {
                Title = "Marketing Intern",
                Site = "https://example.com/internship3",
                Company = "MarketMakers",
                Location = "Chicago, IL",
                Description = "Assist in developing marketing strategies.",
                InternshipListingId = 2
            }
    };
}