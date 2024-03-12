using AutoMapper;
using web_api.Models;
using web_api.Dto;

namespace versionapi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Project, ProjectDto>();
            CreateMap<ProjectVersion, ProjectVersionDto>();
        }
    }
}
