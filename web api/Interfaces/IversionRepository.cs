namespace web_api.Interfaces
{
    using System.Collections.Generic;
    using web_api.Models;

    public interface IVersionRepository
    {
        void AddProject(Project project);
        void AddProjectVersion(ProjectVersion projectVersion);
    }

}
