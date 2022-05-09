using Microsoft.EntityFrameworkCore;

namespace PortfolioWebsite.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project()
                {
                    Id = 1,
                    Name = "Project 1",
                    Description = "first project",
                    ImageName1 = "BookDatabase.png",
                    ProjectDate = System.DateTime.Today,
                    HasCs = true,
                    UserInterface = "WinForms",
                    GitHubUrl = "https://github.com/",
                    PortfolioType = PortfolioType.Full
                },
                new Project()
                {
                    Id = 2,
                    Name = "Project 2",
                    ImageName1 = "CarDatabase.png",
                    PortfolioType = PortfolioType.Picture
                },
                new Project()
                {
                    Id = 3,
                    Name = "Project 3",
                    VideoUrl = "https://youtube.com/",
                    PortfolioType= PortfolioType.Video
                });
        }
    }
}
