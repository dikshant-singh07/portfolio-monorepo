namespace PortfolioAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public string? TechStack { get; set; } 
        public string? ImageUrl { get; set; }
        public string? GithubLink { get; set; }
        public string? LiveLink { get; set; }
        public int DisplayOrder { get; set; }
    }
}