using System;
using System.Threading.Tasks;
using version_api.Interfaces;
using web_api.Models; 
using web_api.Data;
using versionapi;
using Microsoft.EntityFrameworkCore;

namespace version_api.Repository
{
    public class VersionRepository : IVersionRepository
    {
        private readonly DataContext _context;
        private object context;

        public VersionRepository(DataContext context)
        {
            _context = context;
        }

        public void AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public int AddProjectVersion(ProjectVersion projectVersion)
        {
            _context.ProjectVersions.Add(projectVersion);
            _context.SaveChanges();
            return projectVersion.Id;
        }

        public bool CreateVersion(Version version)
        {
           
            _context.Add(version);
            return Save();
        }

        public async Task<ProjectVersion> GetVersion(int projectId)
        {
            try
            {
               
                throw new NotImplementedException(); 
            }
            catch (Exception ex)
            {
                
                throw; 
            }
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool VersionExists(int Id)
        {
            throw new NotImplementedException();
        }

        Task<VersionGetResp> IVersionRepository.GetVersion(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
