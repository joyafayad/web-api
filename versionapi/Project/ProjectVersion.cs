using System.Collections.Generic;
using web_api.Models;


namespace versionapi
{
    public class ProjectVersion
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string VersionId { get; set; }
        public Project Project { get; set; } 

    }
}
