using System.Collections.Generic;

namespace PortfolioWebsite.Models
{
    public interface IProjectRepository
    {
        List<Project> Projects { get; set; }

        IEnumerable<Project> InitializeProjects();

        Project GetProject(int? id);

        void AddProject(Project project);

        void UpdateProject(Project project);

        void DeleteProject(int? id);
    }
}
