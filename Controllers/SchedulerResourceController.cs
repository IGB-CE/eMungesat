using eMungesat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMungesat.Controllers
{
    public class SchedulerResourceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchedulerResourceController(ApplicationDbContext context)
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
