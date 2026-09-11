namespace InternshipPortal.Models;

public class Ranking
{
    public int RankingId { get; set; } = 0;
    public int StudentId { get; set; } = 0;
    public int InternshipId { get; set; } = 0;
    public int Rank { get; set; } = 0;
    public string Comment { get; set; } = "";
}
