namespace InternshipPortal.Models;
public class UserAccount
{
    public int UserAccountId { get; set; } = 0;
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string Role { get; set; } = "";
    public int RoleSpecificId { get; set; } = 0;
    public bool Registered { get; set; } = false;
}
