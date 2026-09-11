namespace InternshipPortal.Models;
public class Application
{
    public int ApplicationId { get; set; } = 0;
    public int StudentId { get; set; } = 0;
    public int InternshipId { get; set; } = 0;
    public DateTime AppliedDateTime { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Pending";
}
