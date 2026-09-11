namespace InternshipPortal.Models;

public class Interview
{
    public int InterviewId { get; set; } = 0;
    public int StudentId { get; set; } = 0;
    public int InternshipId { get; set; } = 0;
    public DateTime InterviewDateTime { get; set; } = DateTime.Now;
    public string Status = "Scheduled";
}
