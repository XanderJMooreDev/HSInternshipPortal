namespace InternshipPortal.Models;
public class Student
{
    public int StudentId { get; set; } = 0;
    public string Email { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string PreferredName { get; set; } = "";
    public string Concentration { get; set; } = "";
    public int CoordinatorId { get; set; } = 0;

}
