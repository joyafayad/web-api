using versionapi;

namespace web_api.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProjectVersion> ProjectVersions { get; set; } = new List<ProjectVersion>();
        
    }
}
