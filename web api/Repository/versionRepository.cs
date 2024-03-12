namespace web_api.Repository
{
    using System;
    using web_api.Data;
    using web_api.Interfaces;
    using web_api.Models;

    public class VersionRepository : IVersionRepository
    {
        private readonly DataContext _context;

        public VersionRepository(DataContext context)
        {
            _context = context;
        }

        public void AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void AddProjectVersion(ProjectVersion projectVersion)
        {
            _context.ProjectVersions.Add(projectVersion);
            _context.SaveChanges();
        }
    }

}
