using System.Collections.Generic;

namespace PortfolioWebsite.Models
{
    public class DBRepository : IProjectRepository
    {
        private ProjectContext _projectContext;

        public List<Project> Projects { get; set; }

        public DBRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void AddProject(Project project)
        {
            _projectContext.Projects.Add(project);
            _projectContext.SaveChanges();
        }

        public void DeleteProject(int? id)
        {
            var proj = _projectContext.Projects.Find(id);
            if (proj != null)
            {
                _projectContext.Projects.Remove(proj);
                _projectContext.SaveChanges();
            }
        }

        public Project GetProject(int? id)
        {
            return _projectContext.Projects.Find(id);
        }

        public IEnumerable<Project> InitializeProjects()
        {
            return _projectContext.Projects;
        }

        public void UpdateProject(Project project)
        {
            Project proj = _projectContext.Projects.Find(project.Id);
            if (proj != null)
            {
                proj.Id = project.Id;
                proj.Name = project.Name;
                proj.Description = project.Description;
                proj.PortfolioType = project.PortfolioType;
                proj.ImageName1 = project.ImageName1;
                proj.ImageName2 = project.ImageName2;
                proj.ImageName3 = project.ImageName3;
                proj.GitHubUrl = project.GitHubUrl;
                proj.VideoUrl = project.VideoUrl;
                proj.UserInterface = project.UserInterface;
                proj.ProjectDate = project.ProjectDate;
                proj.HasAsp = project.HasAsp;
                proj.HasCs = project.HasCs;
                proj.HasCss = project.HasCss;
                proj.HasHtml = project.HasHtml;
                proj.HasJs = project.HasJs;
                proj.HasSql = project.HasSql;
            }
            _projectContext.SaveChanges();
        }
    }
}
