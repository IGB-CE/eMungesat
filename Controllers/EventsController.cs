using eMungesat.Data.Models;
using eMungesat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMungesat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchedulerEvent>>> GetSchedulerEvents([FromQuery] DateTime start, [FromQuery] DateTime end)
        {
            if (_context.Events == null)
            {
                return NotFound();
            }
            return await _context.Events.Where(e => !((e.End <= start) || (e.Start >= end))).ToListAsync();
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchedulerEvent>> GetSchedulerEvent(int id)
        {
            if (_context.Events == null)
            {
                return NotFound();
            }
            var schedulerEvent = await _context.Events.FindAsync(id);

            if (schedulerEvent == null)
            {
                return NotFound();
            }

            return schedulerEvent;
        }

        // PUT: api/Events/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchedulerEvent(int id, SchedulerEvent schedulerEvent)
        {
            if (id != schedulerEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(schedulerEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchedulerEventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Events
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SchedulerEvent>> PostSchedulerEvent(SchedulerEvent schedulerEvent)
        {
            if (_context.Events == null)
            {
                return Problem("Entity set 'SchedulerDbContext.Events'  is null.");
            }
            _context.Events.Add(schedulerEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchedulerEvent", new { id = schedulerEvent.Id }, schedulerEvent);
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchedulerEvent(int id)
        {
            if (_context.Events == null)
            {
                return NotFound();
            }
            var schedulerEvent = await _context.Events.FindAsync(id);
            if (schedulerEvent == null)
            {
                return NotFound();
            }

            _context.Events.Remove(schedulerEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SchedulerEventExists(int id)
        {
            return (_context.Events?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
