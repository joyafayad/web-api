
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Data;
using web_api.Models;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class versionController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ILogger<versionController> _logger;

        public versionController(DataContext context, ILogger<versionController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Add(Project project, ProjectVersion projectVersion)
        {
            _context.Projects.Add(project);
            _context.ProjectVersions.Add(projectVersion);
            _context.SaveChanges();

            
            _logger.LogInformation("Project and version added successfully.");

          
            if (projectVersion.Version == "2")
            {
                
                return Ok("Project and version added successfully. Version is 2.");
            }
            else
            {
                
                return Ok("Project and version added successfully.");
            }
        }
    }
}
