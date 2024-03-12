using Microsoft.AspNetCore.Mvc;
using web_api.Data;
using web_api.Models;
namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly DataContext _context;

        public VersionController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Add(Project project, ProjectVersion projectVersion)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();

            projectVersion.ProjectId = project.Id;
            _context.ProjectVersions.Add(projectVersion);
            _context.SaveChanges();

            return Ok("Project and version added successfully.");

        }
    }
}







