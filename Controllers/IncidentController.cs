
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tracerapi.Models;

namespace tracerapi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class IncidentController : ControllerBase
    {
        private readonly DataContext _context;

        public IncidentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Incident>>> Get()
        {
            return Ok(await _context.Incidents.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Incident>> Get(int id)
        {
            var incident = await _context.Incidents.FindAsync(id);
            if (incident == null)
                return BadRequest("incident not found.");
            return Ok(incident);
        }

        [HttpPost]
        public async Task<ActionResult<List<Incident>>> AddIncident(Incident incident)
        {
            _context.Incidents.Add(incident);
            await _context.SaveChangesAsync();

            return Ok(await _context.Incidents.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Incident>>> UpdateIncident(Incident request)
        {
            var dbincident = await _context.Incidents.FindAsync(request.Id);
            if (dbincident == null)
                return BadRequest("incident not found.");

            dbincident.DateIncident = request.DateIncident;
            dbincident.Sujet = request.Sujet;
            dbincident.Statut = request.Statut;
            dbincident.Description = request.Description;

            await _context.SaveChangesAsync();

            return Ok(await _context.Incidents.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Incident>>> Delete(int id)
        {
            var dbincident = await _context.Incidents.FindAsync(id);
            if (dbincident == null)
                return BadRequest("incident not found.");

            _context.Incidents.Remove(dbincident);
            await _context.SaveChangesAsync();

            return Ok(await _context.Incidents.ToListAsync());
        }

    }
}
