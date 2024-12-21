using eMungesat.Data.Models;
using eMungesat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMungesat.Controllers
{
    [Produces("application/json")]
    [Route("api/resources")]
    public class ResourcesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResourcesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/resources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchedulerResource>>> GetResources()
        {
            return await _context.Resources.ToListAsync();
        }
    }
}
