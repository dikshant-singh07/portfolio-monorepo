namespace PortfolioAPI.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; } // e.g., "Frontend", "Backend", "Tools"
        public int ProficiencyLevel { get; set; } // e.g., 1 to 100
    }
}