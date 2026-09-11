namespace InternshipPortal.Models;
public class InternshipListing
{
    public string Title { get; set; } = "";
    public string Site { get; set; } = "";
    public string Company { get; set; } = "";
    public string Location { get; set; } = "";
    public string Description { get; set; } = "";
    public string? ExtendedDescription { get; set; } = null;
    public int Applicants { get; set; } = 0;
    public int ListingId { get; set; } = 0;
}