using System.Collections;
using versionapi;
using web_api.Models;

namespace version_api.Interfaces
{
    public interface IVersionRepository
    {
        Task<VersionGetResp> GetVersion(int Id);
        bool VersionExists(int Id);
        bool CreateVersion(Version version);
        bool Save();
    }
}

