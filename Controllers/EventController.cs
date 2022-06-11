
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tracerapi.Models;

namespace tracerapi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Event>>> Get()
        {
            return Ok(await _context.Events.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> Get(int id)
        {
            var myevent = await _context.Events.FindAsync(id);
            if (myevent == null)
                return BadRequest("Event not found.");
            return Ok(myevent);
        }

        [HttpPost]
        public async Task<ActionResult<List<Event>>> AddEvent(Event myevent)
        {
            _context.Events.Add(myevent);
            await _context.SaveChangesAsync();

            return Ok(await _context.Events.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Event>>> UpdateEvent(Event request)
        {
            var dbevent = await _context.Events.FindAsync(request.Id);
            if (dbevent == null)
                return BadRequest("incident not found.");

            
            dbevent.Sujet = request.Sujet;
            

            await _context.SaveChangesAsync();

            return Ok(await _context.Events.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Event>>> Delete(int id)
        {
            var dbevent = await _context.Events.FindAsync(id);
            if (dbevent == null)
                return BadRequest("Event not found.");

            _context.Events.Remove(dbevent);
            await _context.SaveChangesAsync();

            return Ok(await _context.Events.ToListAsync());
        }

    }
}
